namespace HMW1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            txtN = new TextBox();
            txtM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtP = new TextBox();
            graph = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            reset = new Button();
            avg = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(151, 6);
            txtN.Name = "txtN";
            txtN.Size = new Size(54, 27);
            txtN.TabIndex = 0;
            // 
            // txtM
            // 
            txtM.Location = new Point(383, 6);
            txtM.Name = "txtM";
            txtM.Size = new Size(54, 27);
            txtM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "Number of servers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 9);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 3;
            label2.Text = "Number of attackers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 9);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 4;
            label3.Text = "Probability of success";
            // 
            // txtP
            // 
            txtP.Location = new Point(621, 6);
            txtP.Name = "txtP";
            txtP.Size = new Size(54, 27);
            txtP.TabIndex = 5;
            // 
            // graph
            // 
            graph.Location = new Point(681, 6);
            graph.Name = "graph";
            graph.Size = new Size(58, 27);
            graph.TabIndex = 7;
            graph.Text = "Graph";
            graph.UseVisualStyleBackColor = true;
            graph.Click += graph_Click;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(12, 39);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(786, 786);
            chart1.TabIndex = 8;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart2.Legends.Add(legend4);
            chart2.Location = new Point(813, 39);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart2.Series.Add(series4);
            chart2.Size = new Size(786, 786);
            chart2.TabIndex = 9;
            chart2.Text = "chart2";
            // 
            // reset
            // 
            reset.Location = new Point(745, 6);
            reset.Name = "reset";
            reset.Size = new Size(53, 27);
            reset.TabIndex = 10;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // avg
            // 
            avg.AutoSize = true;
            avg.Location = new Point(813, 9);
            avg.Name = "avg";
            avg.Size = new Size(138, 20);
            avg.TabIndex = 11;
            avg.Text = "Arithmetic average:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 836);
            Controls.Add(avg);
            Controls.Add(reset);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(graph);
            Controls.Add(txtP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtM);
            Controls.Add(txtN);
            Name = "Form1";
            Text = "Homework 1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private TextBox txtM;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtP;
        private Button graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Button reset;
        private Label avg;
    }
}
