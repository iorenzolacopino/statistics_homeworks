namespace HMW2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            txtN = new TextBox();
            label2 = new Label();
            txtM = new TextBox();
            label3 = new Label();
            txtP = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            graph = new Button();
            reset = new Button();
            label4 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            relfreq = new RadioButton();
            absfreq = new RadioButton();
            panel2 = new Panel();
            distr = new Button();
            Nsteps = new TextBox();
            label5 = new Label();
            mean = new Label();
            variance = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Servers";
            // 
            // txtN
            // 
            txtN.Location = new Point(74, 9);
            txtN.Name = "txtN";
            txtN.Size = new Size(54, 27);
            txtN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 12);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Attackers";
            // 
            // txtM
            // 
            txtM.Location = new Point(223, 9);
            txtM.Name = "txtM";
            txtM.Size = new Size(54, 27);
            txtM.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 12);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Probability";
            // 
            // txtP
            // 
            txtP.Location = new Point(383, 9);
            txtP.Name = "txtP";
            txtP.Size = new Size(54, 27);
            txtP.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 80);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(449, 412);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // graph
            // 
            graph.Location = new Point(457, 9);
            graph.Name = "graph";
            graph.Size = new Size(58, 27);
            graph.TabIndex = 7;
            graph.Text = "Graph";
            graph.UseVisualStyleBackColor = true;
            graph.Click += graph_Click;
            // 
            // reset
            // 
            reset.Location = new Point(532, 9);
            reset.Name = "reset";
            reset.Size = new Size(58, 27);
            reset.TabIndex = 8;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(12, 57);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 9;
            label4.Text = "Random Walk chart";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(467, 80);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(449, 412);
            chart2.TabIndex = 10;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(922, 80);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart3.Series.Add(series3);
            chart3.Size = new Size(449, 412);
            chart3.TabIndex = 11;
            chart3.Text = "chart3";
            // 
            // panel1
            // 
            panel1.Controls.Add(relfreq);
            panel1.Controls.Add(absfreq);
            panel1.Location = new Point(467, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 26);
            panel1.TabIndex = 14;
            // 
            // relfreq
            // 
            relfreq.AutoSize = true;
            relfreq.Location = new Point(164, 4);
            relfreq.Name = "relfreq";
            relfreq.Size = new Size(152, 24);
            relfreq.TabIndex = 14;
            relfreq.TabStop = true;
            relfreq.Text = "Relative frequency";
            relfreq.UseVisualStyleBackColor = true;
            // 
            // absfreq
            // 
            absfreq.AutoSize = true;
            absfreq.Location = new Point(0, 4);
            absfreq.Name = "absfreq";
            absfreq.Size = new Size(158, 24);
            absfreq.TabIndex = 13;
            absfreq.TabStop = true;
            absfreq.Text = "Absolute frequency";
            absfreq.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(distr);
            panel2.Controls.Add(Nsteps);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(922, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 32);
            panel2.TabIndex = 15;
            // 
            // distr
            // 
            distr.Location = new Point(325, 3);
            distr.Name = "distr";
            distr.Size = new Size(58, 27);
            distr.TabIndex = 3;
            distr.Text = "Graph";
            distr.UseVisualStyleBackColor = true;
            // 
            // Nsteps
            // 
            Nsteps.Location = new Point(265, 3);
            Nsteps.Name = "Nsteps";
            Nsteps.Size = new Size(54, 27);
            Nsteps.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 12);
            label5.Name = "label5";
            label5.Size = new Size(259, 20);
            label5.TabIndex = 1;
            label5.Text = "Final/Intermediate distribution (steps)";
            // 
            // mean
            // 
            mean.AutoSize = true;
            mean.Location = new Point(631, 12);
            mean.Name = "mean";
            mean.Size = new Size(49, 20);
            mean.TabIndex = 16;
            mean.Text = "Mean:";
            // 
            // variance
            // 
            variance.AutoSize = true;
            variance.Location = new Point(913, 12);
            variance.Name = "variance";
            variance.Size = new Size(68, 20);
            variance.TabIndex = 17;
            variance.Text = "Variance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 504);
            Controls.Add(variance);
            Controls.Add(mean);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(chart3);
            Controls.Add(chart2);
            Controls.Add(label4);
            Controls.Add(reset);
            Controls.Add(graph);
            Controls.Add(chart1);
            Controls.Add(txtP);
            Controls.Add(label3);
            Controls.Add(txtM);
            Controls.Add(label2);
            Controls.Add(txtN);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Homework 2";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtN;
        private Label label2;
        private TextBox txtM;
        private Label label3;
        private TextBox txtP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button graph;
        private Button reset;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Panel panel1;
        private RadioButton relfreq;
        private RadioButton absfreq;
        private Panel panel2;
        private TextBox Nsteps;
        private Label label5;
        private Button distr;
        private Label mean;
        private Label variance;
    }
}
