using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Linq;

namespace HMW1
{
    public partial class Form1 : Form
    {
        private int n;  // number of servers
        private int m;  // number of attackers
        private float p;    // probability of successful penetration
        private bool[,] dbu;    // distribution of units dataset
        private int[] fd;   // frequency distribution array
        private readonly Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple };

        public Form1()
        {
            InitializeComponent();
        }

        private bool penetrates(float p)
        {
            return (new Random().Next(0, 100) < (p * 100)) ? true : false;
        }

        // counts how many times a number n appears in an array a of length l
        private int count(int[] a, int l, int n)
        {
            int c = 0;
            for (int i = 0; i < l; i++)
                if (a[i] == n) c++;
            return c;
        }

        // recursive formula of arithmetic average
        private float recursive_mean(int[] fd, float M_k = 0, int k = 0)
        {
            if (k == fd.Length) return M_k;
            return recursive_mean(fd, M_k + (fd[k] - M_k) / (k + 1), k + 1);
        }

        private void graph_Click(object sender, EventArgs e)
        {
            this.n = int.Parse(txtN.Text);
            this.m = int.Parse(txtM.Text);
            this.p = float.Parse(txtP.Text);
            this.dbu = new bool[this.m, this.n];
            this.fd = new int[this.m];
            for (int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < this.n; j++)
                {
                    if (penetrates(this.p))
                    {
                        this.dbu[i, j] = true;
                        this.fd[i]++;
                    }
                }
            }
            avg.Text += " " + recursive_mean(this.fd).ToString();
            chart1.Series.Clear();
            chart1.Visible = true;
            for (int i = 0; i < this.m; i++)
            {
                var series = new Series("Attacker " + (i + 1))
                {
                    ChartType = SeriesChartType.Line,
                    Color = colors[new Random().Next(0, colors.Length)],
                    BorderWidth = 2
                };
                int x = 0;
                int y = 0;
                series.Points.AddXY(x, y);
                for (int j = 0; j < n; j++)
                {
                    if (this.dbu[i, j]) y++;
                    series.Points.AddXY(x++, y);
                    series.Points.AddXY(x, y);
                }
                chart1.Series.Add(series);
            }
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = this.n;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = this.n;
            chart1.ChartAreas[0].AxisX.Title = "Servers";
            chart2.Series.Clear();
            chart2.Visible = true;
            for (int i = 0; i < this.n + 1; i++)
            {
                var series = new Series(i + " penetrations")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.DarkCyan,
                };
                series.Points.AddXY(i, count(fd, this.m, i));
                chart2.Series.Add(series);
            }
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Title = "Penetrations";
            chart2.ChartAreas[0].AxisY.Title = "How many attackers penetrated y times";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Chart chart1 = this.Controls["chart1"] as Chart;
            Chart chart2 = this.Controls["chart2"] as Chart;
            if (chart1 != null && chart2 != null)
            {
                chart1.Series.Clear();
                chart1.Visible = false;
                chart2.Series.Clear();
                chart2.Visible = false;
                txtN.Text = "";
                txtM.Text = "";
                txtP.Text = "";
                avg.Text = "Arithmetic average:";
            }
        }
    }
}
