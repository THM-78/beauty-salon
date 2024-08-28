using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beauty_salon_project
{
    public partial class main : Form
    {
        string _userName;
        public main(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private void tsb_salonInfo_Click(object sender, EventArgs e)
        {
            salon_info MainForm = new salon_info();
            this.Hide();
            MainForm.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //styleManager2.ManagerColorTint = Color.Aquamarine;
            //panelEx3.Style.BackgroundImage = Image.FromFile("red");

            tsb_salonInfo.AutoToolTip = false;

            //login time
            label2.Text = "";
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsb_exitapp_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "اخطار", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);

            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void tsb_addPersonnel_Click(object sender, EventArgs e)
        {
            add_personnel m = new add_personnel(0);
            m.ShowDialog();
        }

        private void tsb_addService_Click(object sender, EventArgs e)
        {
            add_services MainForm = new add_services();
            this.Hide();
            MainForm.Show();
        }

        private void tsb_addSubscription_Click(object sender, EventArgs e)
        {
            add_subscription MainForm = new add_subscription();
            this.Hide();
            MainForm.Show();
        }

        private void tsb_reserveTime_Click(object sender, EventArgs e)
        {
            reserve_time MainForm = new reserve_time();
            this.Hide();
            MainForm.Show();
        }

        private void tsb_chart_Click(object sender, EventArgs e)
        {
            chart chartForm = new chart();
            this.Hide();
            chartForm.Show();
        }
    }
}
