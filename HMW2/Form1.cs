using System.Runtime.Intrinsics.X86;
using System.Windows.Forms.DataVisualization.Charting;

namespace HMW2
{
    public partial class Form1 : Form
    {
        private int n, m;
        private int t;              // time
        private float p;
        private bool[,] dbu;
        private int[] fd;
        private int[] fd_rel;       // frequency distribution at time t
        private readonly Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple };

        public Form1()
        {
            InitializeComponent();
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
        }

        private bool penetrates(float p)
        {
            return (new Random().Next(0, 100) < (p * 100)) ? true : false;
        }

        private int count(int[] a, int l, int n)
        {
            int c = 0;
            for (int i = 0; i < l; i++)
                if (a[i] == n) c++;
            return c;
        }

        private float recursive_mean(int[] fd, float M_k = 0, int k = 0)
        {
            if (k == fd.Length) return M_k;
            return recursive_mean(fd, M_k + (fd[k] - M_k) / (k + 1), k + 1);
        }

        private double variance_calc(int[] fd)
        {
            double sum = 0.0, sumSquare = 0.0;
            for (int i = 0; i < fd.Length; i++)
            {
                sum += fd[i];
                sumSquare += fd[i] * fd[i];
            }
            if (n < 2) return 0;
            else
            {
                double mean = recursive_mean(fd);
                double variance = (sumSquare / m) - (mean * mean);
                return variance;
            }
        }

        private void graph_Click(object sender, EventArgs e)
        {
            this.n = int.Parse(txtN.Text);
            this.m = int.Parse(txtM.Text);
            if (txtT.Text != "") 
                if (int.Parse(txtT.Text) <= this.n) this.t = int.Parse(txtT.Text);
            else this.t = 0;
            this.p = float.Parse(txtP.Text);
            this.dbu = new bool[this.m, this.n];
            this.fd = new int[this.m];
            if (this.t != 0) fd_rel = new int[this.t];
            for (int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < this.n; j++)
                {
                    if (penetrates(this.p))
                    {
                        this.dbu[i, j] = true;
                        this.fd[i]++;
                    }
                    else
                    {
                        this.dbu[i, j] = false;
                        this.fd[i]--;
                    }
                }
            }
            if (this.t != 0)
            {
                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.t; j++)
                    {
                        if (this.dbu[i, j]) this.fd_rel[i]++;
                        else this.fd_rel[i]--;
                    }
                }
            }
            mean.Text = "Mean: " + recursive_mean(fd).ToString();
            if (this.t != 0) relmean.Text = "Relative mean: " + recursive_mean(fd_rel).ToString();
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
                    else y--;
                    series.Points.AddXY(x++, y);
                    series.Points.AddXY(x, y);
                }
                chart1.Series.Add(series);
            }
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = this.n;
            chart1.ChartAreas[0].AxisY.Minimum = (this.n - (2 * this.n));
            chart1.ChartAreas[0].AxisY.Maximum = this.n;
            chart2.Series.Clear();
            chart2.Visible = true;
            var series_abs = new Series("Absolute frequency")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
            };
            for (int i = (this.n - (2 * this.n)); i < this.n + 1; i++)
            {
                
                int c = count(fd, this.m, i);
                if (c > 0) series_abs.Points.AddXY(i, c);
            }
            chart2.Series.Add(series_abs);
            if (this.t != 0)
            {
                var series_rel = new Series("Relative frequency")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.Orange
                };
                for (int i = 0; i < this.t; i++)
                {
                    int c = count(fd_rel, this.t, i);
                    if (c > 0) series_rel.Points.AddXY(i, c);
                }
                chart2.Series.Add(series_rel);
            }
            chart2.Legends[0].Enabled = true;
            chart2.ChartAreas[0].AxisX.Minimum = this.n - (2 * this.n);
            chart2.ChartAreas[0].AxisX.Maximum = this.n;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Title = "Penetrations";
            chart2.ChartAreas[0].AxisY.Title = "How many attackers penetrated x times";
            variance.Text = "Variance: " + variance_calc(fd);
            if (this.t != 0) relvar.Text = "Relative variance: " + variance_calc(fd_rel);
            chart3.Series.Clear();
            chart3.Visible = true;
            if (this.t != 0)
            {
                var mean_series = new Series("Relative mean")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.Green
                };
                var var_series = new Series("Relative variance")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.Red
                };
                for (int i = 1; i < this.t; i++)
                {
                    int[] fd_rel_aux = new int[i];
                    for (int j = 0; j < i; j++) fd_rel_aux[j] = fd_rel[j];
                    mean_series.Points.AddXY(i, recursive_mean(fd_rel_aux));
                    var_series.Points.AddXY(i, variance_calc(fd_rel_aux));
                }
                chart3.Series.Add(mean_series);
                chart3.Series.Add(var_series);
                chart3.Legends[0].Enabled = true;
                chart3.ChartAreas[0].AxisX.Minimum = 0;
                chart3.ChartAreas[0].AxisX.Maximum = this.n;
                chart3.ChartAreas[0].AxisY.Minimum = this.n - (2 * this.n);
                chart3.ChartAreas[0].AxisY.Maximum = this.n;
                chart3.ChartAreas[0].AxisX.Title = "Time";
                chart3.ChartAreas[0].AxisY.Title = "Relative mean/variance";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Chart chart1 = this.Controls["chart1"] as Chart;
            Chart chart2 = this.Controls["chart2"] as Chart;
            Chart chart3 = this.Controls["chart3"] as Chart;
            if (chart1 != null & chart2 != null)
            {
                chart1.Series.Clear();
                chart1.Visible = false;
                chart2.Series.Clear();
                chart2.Visible = false;
                if (chart3 != null)
                {
                    chart3.Series.Clear();
                    chart3.Visible = false;
                }
                txtN.Text = "";
                txtM.Text = "";
                txtP.Text = "";
                txtT.Text = "";
                mean.Text = "Mean:";
                relmean.Text = "Relative mean:";
                variance.Text = "Variance:";
                relvar.Text = "Relative variance:";
            }
        }
    }
}
