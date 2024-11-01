namespace HMW4
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtT = new TextBox();
            txtN = new TextBox();
            txtP = new TextBox();
            graph = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            reset = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(264, 7);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1061, 431);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // txtT
            // 
            txtT.Location = new Point(102, 63);
            txtT.Name = "txtT";
            txtT.Size = new Size(125, 27);
            txtT.TabIndex = 1;
            // 
            // txtN
            // 
            txtN.Location = new Point(102, 139);
            txtN.Name = "txtN";
            txtN.Size = new Size(125, 27);
            txtN.TabIndex = 2;
            // 
            // txtP
            // 
            txtP.Location = new Point(102, 217);
            txtP.Name = "txtP";
            txtP.Size = new Size(125, 27);
            txtP.TabIndex = 3;
            // 
            // graph
            // 
            graph.Location = new Point(118, 298);
            graph.Name = "graph";
            graph.Size = new Size(94, 29);
            graph.TabIndex = 4;
            graph.Text = "Graph";
            graph.UseVisualStyleBackColor = true;
            graph.Click += graph_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 66);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 142);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Intervals";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 220);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 7;
            label3.Text = "Probability";
            // 
            // reset
            // 
            reset.Location = new Point(118, 350);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 8;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 450);
            Controls.Add(reset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(graph);
            Controls.Add(txtP);
            Controls.Add(txtN);
            Controls.Add(txtT);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Homework 4";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox txtT;
        private TextBox txtN;
        private TextBox txtP;
        private Button graph;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button reset;
    }
}
