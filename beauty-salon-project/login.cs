using System;
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

namespace beauty_salon_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.SalonDb_connectionString);

        private void userNameLb_Click(object sender, EventArgs e)
        {
            userNameTxtBx.Visible = true;
            userNameLb.Visible = false;
            userNameTxtBx.Focus();
        }

        private void passLb_Click(object sender, EventArgs e)
        {
            passwordTxtBx.Visible = true;
            passLb.Visible = false;
            userNameTxtBx.Focus();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Rectangle circle1 = new Rectangle(0, 0, exitPic.Width, exitPic.Height);
            var path1 = new GraphicsPath();
            path1.AddEllipse(circle1);
            exitPic.Region = new Region(path1);


            ToolTip tt1 = new ToolTip();
            tt1.ShowAlways = true;
            tt1.SetToolTip(exitPic, "خروج");
        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("آیا میخواهید از نرم افزار خارج شوید؟", "پیغام سیستم", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

            if (re == DialogResult.Yes)
            {

                Application.Exit();

            }
            else
            {
                return;
                // e.Cancel = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxtBx.Text == "" || passwordTxtBx.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات را کامل وارد کنید");
                return;
            }


            con.Open();
            DataTable UserTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("Select * from  tb_admins  where userName = '" + userNameTxtBx.Text + "' AND password = '" + passwordTxtBx.Text + "' ", con);
            Adapter.Fill(UserTable);


            if (UserTable.Rows.Count == 0)
            {
                MessageBox.Show("نام کاربری یا رمز وارد شده معتبر نمی باشد");
                passwordTxtBx.Text = "";
                con.Close();
            }

            else if (UserTable.Rows.Count > 0)
            {
                //MessageBox.Show("Wellllcommm!!");

                main MainForm = new main(userNameTxtBx.Text);
                this.Hide();
                MainForm.Show();


                con.Close();
            }
        }
        private void exitPic_MouseHover(object sender, EventArgs e)
        {
            exitPic.Image = Properties.Resources.cancel_ico_selected;
        }

        private void exitPic_MouseLeave(object sender, EventArgs e)
        {
            exitPic.Image = Properties.Resources.cancel_ico1;
        }

        private void userNameTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                passLb.Visible = false;
                passwordTxtBx.Visible = true;
                passwordTxtBx.Focus();
                MessageBox.Show(":)");
            }
        }

        private void userNameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                passLb.Visible = false;
                passwordTxtBx.Visible = true;
                passwordTxtBx.Focus();
                MessageBox.Show(":)");
            }
        }
    }
}
