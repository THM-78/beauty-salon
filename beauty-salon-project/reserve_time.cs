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
    public partial class reserve_time : Form
    {
        public reserve_time()
        {
            InitializeComponent();
        }

        private void reserve_time_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.tb_personnel' table. You can move, or remove it, as needed.
            this.tb_personnelTableAdapter.Fill(this.mainDataSet.tb_personnel);

        }
    }
}
