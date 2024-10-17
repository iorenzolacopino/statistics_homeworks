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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            mean = new Label();
            variance = new Label();
            label6 = new Label();
            relmean = new Label();
            relvar = new Label();
            label5 = new Label();
            label8 = new Label();
            txtT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
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
            chartArea4.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart1.Legends.Add(legend4);
            chart1.Location = new Point(12, 80);
            chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart1.Series.Add(series4);
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
            reset.Click += reset_Click;
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
            chartArea5.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chart2.Legends.Add(legend5);
            chart2.Location = new Point(467, 80);
            chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chart2.Series.Add(series5);
            chart2.Size = new Size(449, 412);
            chart2.TabIndex = 10;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chart3.Legends.Add(legend6);
            chart3.Location = new Point(922, 80);
            chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 2;
            chart3.Series.Add(series6);
            chart3.Size = new Size(449, 412);
            chart3.TabIndex = 11;
            chart3.Text = "chart4";
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
            variance.Location = new Point(922, 12);
            variance.Name = "variance";
            variance.Size = new Size(68, 20);
            variance.TabIndex = 17;
            variance.Text = "Variance:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 57);
            label6.Name = "label6";
            label6.Size = new Size(196, 20);
            label6.TabIndex = 19;
            label6.Text = "Absolute/Relative frequency";
            // 
            // relmean
            // 
            relmean.AutoSize = true;
            relmean.Location = new Point(631, 32);
            relmean.Name = "relmean";
            relmean.Size = new Size(106, 20);
            relmean.TabIndex = 21;
            relmean.Text = "Relative mean:";
            // 
            // relvar
            // 
            relvar.AutoSize = true;
            relvar.Location = new Point(922, 32);
            relvar.Name = "relvar";
            relvar.Size = new Size(124, 20);
            relvar.TabIndex = 22;
            relvar.Text = "Relative variance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(922, 57);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 23;
            label5.Text = "Distribution";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 45);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 24;
            label8.Text = "Time";
            // 
            // txtT
            // 
            txtT.Location = new Point(344, 42);
            txtT.Name = "txtT";
            txtT.Size = new Size(54, 27);
            txtT.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 503);
            Controls.Add(txtT);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(relvar);
            Controls.Add(relmean);
            Controls.Add(label6);
            Controls.Add(variance);
            Controls.Add(mean);
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
        private Label mean;
        private Label variance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Label label6;
        private Label relmean;
        private Label relvar;
        private Label label5;
        private Label label8;
        private TextBox txtT;
    }
}
