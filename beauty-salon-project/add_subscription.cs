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
    public partial class add_subscription : Form
    {
        public add_subscription()
        {
            InitializeComponent();
        }

        private void add_subscription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tb_customer_DataSet.tb_customer' table. You can move, or remove it, as needed.
            this.tb_customerTableAdapter.Fill(this.tb_customer_DataSet.tb_customer);

        }
    }
}
