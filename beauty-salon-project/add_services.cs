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
    public partial class add_services : Form
    {
        public add_services()
        {
            InitializeComponent();
        }

        private void add_services_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'makeup_salon_dbDataSet.tb_services' table. You can move, or remove it, as needed.
            this.tb_servicesTableAdapter.Fill(this.makeup_salon_dbDataSet.tb_services);

        }
    }
}
