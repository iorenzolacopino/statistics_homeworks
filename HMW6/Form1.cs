using System.Security.Cryptography.Pkcs;
using System.Windows.Forms.DataVisualization.Charting;

namespace HMW6
{
    public partial class Form1 : Form
    {
        TextBox[] probabilities;                                        // textboxes containing probabilities
        int dimension;                                                  // dimension of the distribution set
        int n;                                                          // dimension of sample set
        int[] values;
        double[] distribution;
        double tm, em, tv, ev;                                          // respectively:
                                                                        // theoretical mean
                                                                        // empirical mean
                                                                        // theoretical variance
                                                                        // empirical variance
        List<double> empiricalMeans;
        List<double> empiricalVariances;

        public Form1()
        {
            InitializeComponent();
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;
            p4.Enabled = false;
            p5.Enabled = false;
            probabilities = new TextBox[] { p1, p2, p3, p4, p5 };
            samples.Enabled = false;
            generate.Enabled = false;
            tm = 0.0;
            em = 0.0;
            tv = 0.0;
            ev = 0.0;
        }

        private void theoretical()
        {
            tm = 0;
            tv = 0;
            for (int i = 0; i < dimension; i++)
            {
                tm += values[i] * distribution[i];
            }
            for (int i = 0; i < dimension; i++)
            {
                tv += Math.Pow(values[i] - tm, 2) * distribution[i];
            }
        }

        // Welford's recursion
        private void empirical()
        {
            double M = 0.0;
            double S = 0.0;
            Random random = new Random();
            empiricalMeans = new List<double>();
            empiricalVariances = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double sample = getRandomSample(values, distribution, random);
                double delta = sample - M;
                double previous = M;
                M += delta / (i + 1);
                S += delta * (sample - previous);
                em = M;
                ev = S / (i + 1);
                empiricalMeans.Add(em);
                empiricalVariances.Add(ev);
            }
        }

        public static double getRandomSample(int[] values, double[] probabilities, Random random)
        {
            double p = random.NextDouble();
            double cumulative = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                cumulative += probabilities[i];
                if (p < cumulative)
                    return values[i];
            }

            return values[values.Length - 1];
        }


        private void draw()
        {
            theoretical();
            empirical();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);
            chart1.Series.Add("Theoretical Mean");
            chart1.Series.Add("Empirical Mean");
            chart1.Series.Add("Theoretical Variance");
            chart1.Series.Add("Empirical Variance");
            chart1.Series["Theoretical Mean"].ChartType = SeriesChartType.Line;
            chart1.Series["Empirical Mean"].ChartType = SeriesChartType.Line;
            chart1.Series["Theoretical Variance"].ChartType = SeriesChartType.Line;
            chart1.Series["Empirical Variance"].ChartType = SeriesChartType.Line;
            chart1.Series["Theoretical Mean"].Color = Color.Blue;
            chart1.Series["Empirical Mean"].Color = Color.Green;
            chart1.Series["Theoretical Variance"].Color = Color.Red;
            chart1.Series["Empirical Variance"].Color = Color.Orange;
            for (int i = 0; i < n; i++)
            {
                chart1.Series["Theoretical Mean"].Points.AddXY(i + 1, tm);
                chart1.Series["Empirical Mean"].Points.AddXY(i + 1, empiricalMeans[i]);
                chart1.Series["Theoretical Variance"].Points.AddXY(i + 1, tv);
                chart1.Series["Empirical Variance"].Points.AddXY(i + 1, empiricalVariances[i]);
            }
            tml.Text = "Theoretical mean: " + tm;
            tvl.Text = "Theoretical variance: " + tv;
            eml.Text = "Empirical mean: " + em;
            evl.Text = "Empirical variance: " + ev;
        }

        private void update_Click(object sender, EventArgs e)
        {
            dimension = int.Parse(dim.Text);
            if (dimension > 5)
            {
                dimension = 5;
            }
            values = new int[dimension];
            distribution = new double[dimension];
            for (int i = 0; i < 5; i++)
            {
                if (i < dimension)
                {
                    values[i] = i + 1;
                    probabilities[i].Enabled = true;
                }
                else
                {
                    probabilities[i].Enabled = false;
                }
            }
            samples.Enabled = true;
            generate.Enabled = true;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dimension; i++)
            {
                if (probabilities[i].Text == "" || !double.TryParse(probabilities[i].Text, out double p) || samples.Text == "" || !int.TryParse(samples.Text, out int n)){
                    MessageBox.Show("Invalid input");
                    return;
                }
                else
                {
                    sum += double.Parse(probabilities[i].Text);
                }
            }
            if (sum != 1.0)
            {
                MessageBox.Show("The sum of the probabilities has to be equal to 1");
                return;
            }
            for (int i = 0; i < dimension; i++)
            {
                distribution[i] = double.Parse(probabilities[i].Text);
            }
            n = int.Parse(samples.Text);
            draw();
        }
    }
}
