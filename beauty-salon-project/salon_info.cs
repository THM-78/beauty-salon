using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace beauty_salon_project
{
    public partial class salon_info : Form
    {
        public salon_info()
        {
            InitializeComponent();
        }
        ToolTip toolTip110;
        string filename = string.Empty;
        byte[] logoData;
        
        bool flag = false;
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.SalonDb_connectionString);
        private makeup_salon_dbEntities db = new makeup_salon_dbEntities();
        private void select_from_SQL()
        {
            con.Open();
            string rule;

            try
            {
                rule = "SELECT TOP 1 * FROM tb_salonInfo";
                SqlCommand cmd = new SqlCommand(rule, con);
                cmd.Connection = con;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    salonNameTxt.Text = dr["salonName"].ToString();
                    adminNameTxt.Text = dr["adminName"].ToString();
                    tellTxt.Text = dr["tell"].ToString();
                    postalCodeTxt.Text = dr["postalCode"].ToString();
                    emailTxt.Text = dr["email"].ToString();
                    faxTxt.Text = dr["fax"].ToString();
                    addressTxt.Text = dr["address"].ToString();
                    messageTxt.Text = dr["message"].ToString();
                    if (logoData != null)
                    {
                        logoData = (byte[])dr["logo"];
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(logoData))
                            {
                                Image image = Image.FromStream(ms);
                                logo.Image = image;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                // MessageBox.Show("error :(");
                con.Close();
            }

        }

        private void read_data()
        {
            //tb_personnel personnel_tb = new tb_personnel();
            tb_salonInfo salonInfo_tb = new tb_salonInfo();

            //LibraryContext db = new LibraryContext();


            //   return db.tb_salonInfo.ToList();
            salonInfo_tb = db.tb_salonInfo.FirstOrDefault();

            salonNameTxt.Text = salonInfo_tb.salonName;
            adminNameTxt.Text = salonInfo_tb.adminName;
            tellTxt.Text = salonInfo_tb.tell.ToString();
            emailTxt.Text = salonInfo_tb.email;
            postalCodeTxt.Text = salonInfo_tb.postalCode.ToString();
            faxTxt.Text = salonInfo_tb.fax.ToString();
            addressTxt.Text = salonInfo_tb.address;
            messageTxt.Text = salonInfo_tb.message;
            logoData = (byte[])salonInfo_tb.logo;
            if (logoData != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(logoData))
                    {
                        Image image = Image.FromStream(ms);
                        logo.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void update_form_SQL()
        {
            try
            {
                con.Open();
                var adminName = db.tb_salonInfo.FirstOrDefault().adminName;
                SqlCommand cmd = new SqlCommand("UPDATE tb_salonInfo SET salonName = @salonName, adminName = @adminName,tell = @tell," +
                    "email = @email, postalCode = @postalCode, fax = @fax, address = @address, logo = @logo, message = @message WHERE adminName = @firstRowAdminName", con);
                cmd.Parameters.AddWithValue("@salonName", salonNameTxt.Text);
                cmd.Parameters.AddWithValue("@adminName", adminNameTxt.Text);
                cmd.Parameters.AddWithValue("@tell", tellTxt.Text);
                cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                cmd.Parameters.AddWithValue("@postalCode", postalCodeTxt.Text);
                cmd.Parameters.AddWithValue("@fax", faxTxt.Text);
                cmd.Parameters.AddWithValue("@address", addressTxt.Text);
                cmd.Parameters.AddWithValue("@logo", logoData);
                cmd.Parameters.AddWithValue("@message", messageTxt.Text);
                cmd.Parameters.AddWithValue("@firstRowAdminName", adminName);

                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.UpdateCommand = cmd;
                MessageBox.Show("اطلاعات آرایشگاه آپدیت شد");
                con.Close();
                // this.Hide();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                //MessageBox.Show(" نشد ");
                con.Close();

            }
        }

        private void salon_info_Load(object sender, EventArgs e)
        {
            //ToolTip
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(homePicBx, "بازگشت به صفحه اصلی");

            ToolTip toolTip21 = new ToolTip();
            toolTip21.ShowAlways = true;
            toolTip21.SetToolTip(logo, "برای تغییر لوگو کلیک کنید");

            ToolTip toolTip11 = new ToolTip();
            toolTip11.ShowAlways = true;
            toolTip11.SetToolTip(editPicBx, "ویرایش");

            ToolTip toolTip111 = new ToolTip();
            toolTip111.ShowAlways = true;
            toolTip111.SetToolTip(cancelPicBx, "لغو تغییرات");

            //picture box graphic 
            Rectangle circle1 = new Rectangle(0, 0, logo.Width, logo.Height);
            var path1 = new GraphicsPath();
            path1.AddEllipse(circle1);
            logo.Region = new Region(path1);

            Rectangle circle11 = new Rectangle(0, 0, homePicBx.Width, homePicBx.Height);
            var path11 = new GraphicsPath();
            path11.AddEllipse(circle11);
            homePicBx.Region = new Region(path11);

            Rectangle circle111 = new Rectangle(0, 0, editPicBx.Width, editPicBx.Height);
            var path111 = new GraphicsPath();
            path111.AddEllipse(circle111);
            editPicBx.Region = new Region(path111);

            Rectangle circle22 = new Rectangle(0, 0, cancelPicBx.Width, cancelPicBx.Height);
            var path22 = new GraphicsPath();
            path22.AddEllipse(circle22);
            cancelPicBx.Region = new Region(path22);


            //select_from_SQL();
            read_data();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg image(*.jpg)|*.jpg|" + "png image (*.png)|*.png|" + "all file(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image logoToSave = Image.FromFile(openFileDialog1.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    logoToSave.Save(ms, ImageFormat.Jpeg);
                    logoData = ms.ToArray();
                }
            }
            filename = openFileDialog1.FileName;
            MessageBox.Show(filename);
        }

        private void editPicBx_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                //Change buttons
                homePicBx.Enabled = false;
                cancelPicBx.Visible = true;
                editPicBx.Image = Properties.Resources.submit_ico;

                //Tooltips
                toolTip110 = new ToolTip();
                if (!flag)
                    toolTip110.SetToolTip(editPicBx, "ثبت تغییرات");

                //Enables
                salonNameTxt.Enabled = true;
                adminNameTxt.Enabled = true;
                tellTxt.Enabled = true;
                emailTxt.Enabled = true;
                postalCodeTxt.Enabled = true;
                faxTxt.Enabled = true;
                addressTxt.Enabled = true;
                messageTxt.Enabled = true;
                logo.Enabled = true;

                //Change flag
                flag = true;
            }
            else if (flag)
            {
                //Update database SQL
                update_form_SQL();

                //Update form
                select_from_SQL();

                //Enables
                salonNameTxt.Enabled = false;
                adminNameTxt.Enabled = false;
                tellTxt.Enabled = false;
                emailTxt.Enabled = false;
                postalCodeTxt.Enabled = false;
                faxTxt.Enabled = false;
                addressTxt.Enabled = false;
                messageTxt.Enabled = false;
                logo.Enabled = false;

                //Change buttons
                homePicBx.Enabled = true;
                cancelPicBx.Visible = false;
                editPicBx.Image = Properties.Resources.edit_ico__1_;

                //Tooltips
                // toolTip110 = new ToolTip();    
                if (flag)
                    toolTip110.SetToolTip(editPicBx, "ویرایش");

                //Change flag
                flag = false;
            }
        }

        private void homePicBx_Click(object sender, EventArgs e)
        {
            main form = new main("str");
            this.Hide();
            form.Show();
        }
    }
}
