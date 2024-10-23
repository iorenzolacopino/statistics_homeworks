using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace HMW3
{
    public partial class Form1 : Form
    {
        private int t, n, lambda;

        public Form1()
        {
            InitializeComponent();
            chart1.Visible = false;
        }

        private bool penetrates(int lambda, int n)
        {
            float p = (float)lambda / (float)n;
            return new Random().Next(0, 100) < p * 100 ? true : false;
        }

        private void draw_chart()
        {
            chart1.Series.Clear();
            chart1.Visible = true;
            var series = new Series("Attacker")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red
            };
            int y = 0;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = this.t;
            chart1.ChartAreas[0].AxisX.Interval = this.t / this.n;
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Penetrations";
            series.Points.AddXY(0, y);
            for (int i = 0; i < this.t; i++)
            {
                if (penetrates(this.lambda, this.n)) y++;
                series.Points.AddXY((this.t / this.n) * i, y);
            }
            chart1.Series.Add(series);
        }

        private void graph_Click(object sender, EventArgs e)
        {
            this.t = int.Parse(txtT.Text);
            this.n = int.Parse(txtN.Text);
            this.lambda = int.Parse(txtL.Text);
            if (this.lambda <= this.n) draw_chart();
            else MessageBox.Show("Lambda cannot be higher than the number of intervals");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtT.Text = "";
            txtN.Text = "";
            txtL.Text = "";
            Chart chart1 = this.Controls["chart1"] as Chart;
            if (chart1 != null)
            {
                chart1.Series.Clear();
                chart1.Visible = false;
            }
        }
    }
}
