namespace HMW3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            txtT = new TextBox();
            label2 = new Label();
            txtN = new TextBox();
            label3 = new Label();
            txtL = new TextBox();
            graph = new Button();
            label4 = new Label();
            reset = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(205, 42);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(1152, 458);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Time:";
            // 
            // txtT
            // 
            txtT.Location = new Point(77, 19);
            txtT.Name = "txtT";
            txtT.Size = new Size(54, 27);
            txtT.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Intervals:";
            // 
            // txtN
            // 
            txtN.Location = new Point(88, 74);
            txtN.Name = "txtN";
            txtN.Size = new Size(54, 27);
            txtN.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Lambda: ";
            // 
            // txtL
            // 
            txtL.Location = new Point(88, 134);
            txtL.Name = "txtL";
            txtL.Size = new Size(54, 27);
            txtL.TabIndex = 6;
            // 
            // graph
            // 
            graph.Location = new Point(37, 199);
            graph.Name = "graph";
            graph.Size = new Size(94, 29);
            graph.TabIndex = 7;
            graph.Text = "Graph";
            graph.UseVisualStyleBackColor = true;
            graph.Click += graph_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 19);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 8;
            label4.Text = "SDE simulator";
            // 
            // reset
            // 
            reset.Location = new Point(37, 257);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 9;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 512);
            Controls.Add(reset);
            Controls.Add(label4);
            Controls.Add(graph);
            Controls.Add(txtL);
            Controls.Add(label3);
            Controls.Add(txtN);
            Controls.Add(label2);
            Controls.Add(txtT);
            Controls.Add(label1);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Homework 3";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private TextBox txtT;
        private Label label2;
        private TextBox txtN;
        private Label label3;
        private TextBox txtL;
        private Button graph;
        private Label label4;
        private Button reset;
    }
}
