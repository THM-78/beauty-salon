using beauty_salon_project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beauty_salon_project
{
    public partial class add_personnel : Form
    {
        public string check_work_days()
        {
            string _workDays = "";

            if (saturday_chkBx.Checked == true)
                _workDays += "1";

            if (sunday_chkBx.Checked == true)
                _workDays += "2";

            if (monday_chkBx.Checked == true)
                _workDays += "3";

            if (tuesday_chkBx.Checked == true)
                _workDays += "4";

            if (wednesday_chkBx.Checked == true)
                _workDays += "5";

            if (thursday_chkBx.Checked == true)
                _workDays += "6";

            return _workDays;
        }

        public void clear_textboxs()
        {
            name_txtBx.Text = null;
            lastName_txtBx.Text = null;
            nationalCode_txtBx.Text = null;
            mobile_txtBx.Text = null;
            address_txtBx.Text = null;
            birthDay_datePicker.PersianDate = null;
        }
        public void clear_checkboxs()
        {
            saturday_chkBx.Checked = false;
            sunday_chkBx.Checked = false;
            monday_chkBx.Checked = false;
            tuesday_chkBx.Checked = false;
            thursday_chkBx.Checked = false;
            wednesday_chkBx.Checked = false;
        }

        int _userName = -1;

        public add_personnel(int userName)
        {
            InitializeComponent();
            _userName = userName;
        }
        private makeup_salon_dbEntities db = new makeup_salon_dbEntities();
        SqlConnection con = new SqlConnection(Properties.Settings.Default.SalonDb_connectionString);

        private void add_personnel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'makeup_salon_dbDataSet.tb_personnel' table. You can move, or remove it, as needed.
            this.tb_personnelTableAdapter.Fill(this.makeup_salon_dbDataSet.tb_personnel);
            //ToolTip
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(homePicBx, "بازگشت به صفحه اصلی");

            //picture box graphic 
            Rectangle circle11 = new Rectangle(0, 0, homePicBx.Width, homePicBx.Height);
            var path11 = new GraphicsPath();
            path11.AddEllipse(circle11);
            homePicBx.Region = new Region(path11);

            toolStripButton4.Enabled = false;
        }

        //cancel operation (لغو عملیات)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clear_checkboxs();
            clear_textboxs();
            dataGridView1.ClearSelection();
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
        }


        //submit new record (ثبت)
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var validator = new PersonnelValidator();
            //Check textBoxs not null
            if (name_txtBx.Text == "" || lastName_txtBx.Text == "" || nationalCode_txtBx.Text == ""
                || address_txtBx.Text == "")
            {
                MessageBox.Show("لطفا فیلدها را کامل کنید");
                return;
            }
            //Check checkBoxes selected
            if (saturday_chkBx.Checked == false && sunday_chkBx.Checked == false &&
                   thursday_chkBx.Checked == false && wednesday_chkBx.Checked == false &&
                   monday_chkBx.Checked == false && tuesday_chkBx.Checked == false)
            {
                MessageBox.Show("حداقل یک روز کاری انتخاب کنید");
                return;
            }
            DateTime BirthDayDate;
            try
            {
                var persianDateInfo = birthDay_datePicker.PersianDate;
                PersianCalendar calendar = new PersianCalendar();
                BirthDayDate = calendar.ToDateTime(persianDateInfo.Year, persianDateInfo.Month, persianDateInfo.Day, 0, 0, 0, 0);
            }
            catch
            {
                MessageBox.Show("لطفا تاریخ تولد را به درستی وارد نمایید");
                return;
            }

            tb_personnel tb_personnel = new tb_personnel
            {
                name = name_txtBx.Text.Trim(),
                lastName = lastName_txtBx.Text.Trim(),
                nationalCode = long.Parse(nationalCode_txtBx.Text.Trim()),
                birthDay = BirthDayDate,
                workDays = check_work_days(),
                mobile = long.Parse(mobile_txtBx.Text.Trim()),
                address = address_txtBx.Text,
                employeDate = DateTime.Today,
                edittingDate = DateTime.Today,
                adminId = 1
            };
            var validationResult = validator.Validate(tb_personnel);
            if (!validationResult.IsValid)
            {
                string errorMsg = "";
                foreach(var error in validationResult.Errors)
                {
                    errorMsg += error.ErrorMessage+"\n";
                }
                MessageBox.Show(errorMsg.Trim() ,"خطا"); return;
            }
            db.tb_personnel.Add(tb_personnel);
            db.SaveChanges();
            MessageBox.Show("ثبت موفقیت آمیز");
            this.tb_personnelTableAdapter.Fill(this.makeup_salon_dbDataSet.tb_personnel);
            dataGridView1.Update();

            //فراخوانی متد کلییر
            clear_textboxs();
            clear_checkboxs();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()))
            {
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = false;
                toolStripButton2.Enabled = false;
                clear_textboxs();
                clear_checkboxs();
                return;
            }
            toolStripButton4.Enabled = true;
            toolStripButton2.Enabled = true;
            name_txtBx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastName_txtBx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            nationalCode_txtBx.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var rowDate = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            var persianDate = new PersianDateInfo(rowDate);
            birthDay_datePicker.PersianDate = persianDate;
            mobile_txtBx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            address_txtBx.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            //workDays
            string a = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            for (int i = 0; i <= a.Length - 1; i++)
            {
                switch (a[i])
                {
                    case '1':
                        saturday_chkBx.Checked = true;
                        break;
                    case '2':
                        sunday_chkBx.Checked = true;
                        break;
                    case '3':
                        monday_chkBx.Checked = true;
                        break;
                    case '4':
                        tuesday_chkBx.Checked = true;
                        break;
                    case '5':
                        wednesday_chkBx.Checked = true;
                        break;
                    case '6':
                        thursday_chkBx.Checked = true;
                        break;
                    case '0':
                        saturday_chkBx.Checked = false;
                        sunday_chkBx.Checked = false;
                        monday_chkBx.Checked = false;
                        tuesday_chkBx.Checked = false;
                        wednesday_chkBx.Checked = false;
                        thursday_chkBx.Checked = false;
                        break;
                    default:
                        break;
                }
            }

            toolStripButton3.Enabled = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int pc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_personnel personnel = db.tb_personnel.SingleOrDefault(i => i.personnelCode == pc);
                if (personnel != null)
                {
                    if (name_txtBx.Text == "" || lastName_txtBx.Text == "" || nationalCode_txtBx.Text == "" || mobile_txtBx.Text == ""
                    || address_txtBx.Text == "")
                    {
                        MessageBox.Show("لطفا فیلدها را کامل کنید");
                        return;
                    }
                    if (saturday_chkBx.Checked == false && sunday_chkBx.Checked == false &&
                    thursday_chkBx.Checked == false && wednesday_chkBx.Checked == false &&
                    monday_chkBx.Checked == false && tuesday_chkBx.Checked == false)
                    {
                        MessageBox.Show("حداقل یک روز کاری انتخاب کنید");
                        return;
                    }
                    //if (validator.EditIsExist(nationalCode_txtBx.Text.Trim(), pc))
                    //{
                    //    MessageBox.Show("کد ملی تکراری و یا اشتباه است");
                    //    return;
                    //}
                    //var mobileCheck = validator.Validate(mobile_txtBx.Text.Trim());
                    //if (!mobileCheck.IsValid)
                    //{
                    //    foreach (var error in mobileCheck.Errors)
                    //    {
                    //        MessageBox.Show(error.ErrorMessage);
                    //    }
                    //    mobile_txtBx.Focus();
                    //    return;
                    //}
                    personnel.name = name_txtBx.Text;
                    personnel.lastName = lastName_txtBx.Text;
                    personnel.nationalCode = long.Parse(nationalCode_txtBx.Text.Trim());
                    try
                    {
                        var persianDateInfo = birthDay_datePicker.PersianDate;
                        PersianCalendar calendar = new PersianCalendar();
                        var BirthDayDate = calendar.ToDateTime(persianDateInfo.Year, persianDateInfo.Month, persianDateInfo.Day, 0, 0, 0, 0);
                        personnel.birthDay = BirthDayDate;
                    }
                    catch
                    {
                        MessageBox.Show("لطفا تاریخ تولد را به درستی وارد نمایید");
                        return;
                    }
                    personnel.workDays = check_work_days();
                    personnel.mobile = long.Parse(mobile_txtBx.Text.Trim());
                    personnel.address = address_txtBx.Text;
                    DateTime todaysDate = DateTime.Today;
                    personnel.edittingDate = todaysDate.Date;
                    db.tb_personnel.AddOrUpdate(personnel);
                    db.SaveChanges();
                    this.tb_personnelTableAdapter.Fill(this.makeup_salon_dbDataSet.tb_personnel);
                    dataGridView1.Update();
                    MessageBox.Show("ویرایش موفقیت آمیز");

                    //فراخوانی متد کلییر
                    clear_textboxs();
                    clear_checkboxs();
                }
            }
            else
            {
                return;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int pc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                tb_personnel personnel = db.tb_personnel.SingleOrDefault(i => i.personnelCode == pc);
                if (personnel != null)
                {
                    DialogResult re = MessageBox.Show("آیا از حذف داده مورد نظر اطمینان دارید؟", "اخطار", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

                    if (re == DialogResult.Yes)
                    {
                        db.tb_personnel.Remove(personnel);
                        db.SaveChanges();
                        this.tb_personnelTableAdapter.Fill(this.makeup_salon_dbDataSet.tb_personnel);
                        dataGridView1.Update();
                        clear_textboxs();
                        clear_checkboxs();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                return;
            }
        }

        private void homePicBx_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
