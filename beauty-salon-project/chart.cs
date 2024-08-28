using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace beauty_salon_project
{
    public partial class chart : Form
    {
        makeup_salon_dbEntities db = new makeup_salon_dbEntities();
        private List<tb_reserve> _Reserves;
        private List<tb_services> services;
        public chart()
        {
            InitializeComponent();
        }

        public void chartOperation(DateTime date, List<tb_reserve> _Reserves, List<tb_services> service)
        {

            try
            {
                chart1.Series.Clear();

                // ایجاد یک مجموعه داده جدید
                Series series1 = new Series();
                series1.ChartType = SeriesChartType.Column;
                List<int> forChartInterval = new List<int>();
                List<tb_reserve> todays = _Reserves.Where(i => i.date >= date).ToList();
                foreach (tb_services d in service)
                {
                    if (todays.Any(i => i.tb_personnelServiceRel.serviceCode == d.serviceCode))
                    {
                        int reserveCount = todays.Where(i => i.tb_personnelServiceRel.serviceCode == d.serviceCode).ToList().Count;
                        series1.Points.AddXY(d.serviceName, reserveCount);
                        forChartInterval.Add(reserveCount);
                    }
                    else
                    {
                        series1.Points.AddXY(d.serviceName, 0);
                    }
                }
                series1.Color = Color.FromArgb(140, 255, 100);

                chart1.ChartAreas[0].AxisY.Interval = Math.Round(forChartInterval.Average(), MidpointRounding.AwayFromZero); ;

                chart1.Series.Add(series1);
            }
            catch (Exception ex)
            {

            }
        }

        private void chart_Load(object sender, EventArgs e)
        {
            _Reserves = db.tb_reserve.ToList();
            services = db.tb_services.ToList();
            chartOperation(DateTime.Today, _Reserves, services);
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            BtnToday.BackColor = Color.FromArgb(140, 255, 100);
            BtnWeekly.BackColor = Color.White;
            BtnMonthly.BackColor = Color.White;
            chartOperation(DateTime.Today, _Reserves, services);
        }

        private void BtnWeekly_Click(object sender, EventArgs e)
        {
            BtnToday.BackColor = Color.White;
            BtnMonthly.BackColor = Color.White;
            BtnWeekly.BackColor = Color.FromArgb(140, 255, 100);
            chartOperation(DateTime.Now.Subtract(TimeSpan.FromDays(7)), _Reserves, services);
        }

        private void BtnMonthly_Click(object sender, EventArgs e)
        {
            BtnToday.BackColor = Color.White;
            BtnMonthly.BackColor = Color.FromArgb(140, 255, 100);
            BtnWeekly.BackColor = Color.White;
            chartOperation(DateTime.Now.Subtract(TimeSpan.FromDays(30)), _Reserves, services);
        }

        private void homePicBx_Click(object sender, EventArgs e)
        {
            main f2 = new main("str");
            f2.Show();
            this.Hide();
        }
    }
}
