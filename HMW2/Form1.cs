namespace HMW2
{
    public partial class Form1 : Form
    {
        private int n, m;
        private float p;
        private bool[,] dbu;
        private int[] fd;
        private readonly Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple };

        public Form1()
        {
            InitializeComponent();
            absfreq.Checked = true;
            relfreq.Checked = false;
            Nsteps.Enabled = false;
            distr.Enabled = false;
        }

        private bool penetrates(float p)
        {
            return (new Random().Next(0, 100) < (p * 100)) ? true : false;
        }

        private void checkFrequency(object sender, EventArgs e)
        {
            if (absfreq.Checked) relfreq.Checked = false;
            else
            {
                relfreq.Checked = true;
                absfreq.Checked = false;
            }
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
        }
    }
}
