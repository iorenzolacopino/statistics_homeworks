using System.Windows.Forms.DataVisualization.Charting;

namespace HMW4
{
    public partial class Form1 : Form
    {
        private int t, n;
        private float p;

        public Form1()
        {
            InitializeComponent();
            chart1.Visible = false;
        }

        private bool penetrates(double p)
        {
            return new Random().Next(0, 100) < (p * 100) ? true : false;
        }

        private void graph_Click(object sender, EventArgs e)
        {
            this.t = int.Parse(txtT.Text);
            this.n = int.Parse(txtN.Text);
            this.p = float.Parse(txtP.Text);
            chart1.Series.Clear();
            chart1.Visible = true;
            var series = new Series("Attacker")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red
            };
            float y = 0;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = this.t;
            chart1.ChartAreas[0].AxisX.Interval = this.t / this.n;
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Wiener process";
            // series.Points.AddXY(0, y);
            for (int i = 0; i < this.n + 1; i++)
            {
                if (i != 0) series.Points.AddXY((this.t / this.n) * i, y);
                if (penetrates(this.p)) y += (float)1 / (float)this.n;
                else y -= (float)1 / (float)this.n;
                if (i < this.n) series.Points.AddXY((this.t / this.n) * i, y);
            }
            chart1.Series.Add(series);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtT.Text = "";
            txtN.Text = "";
            txtP.Text = "";
            Chart chart1 = this.Controls["chart1"] as Chart;
            if (chart1 != null)
            {
                chart1.Series.Clear();
                chart1.Visible = false;
            }
        }
    }
}
