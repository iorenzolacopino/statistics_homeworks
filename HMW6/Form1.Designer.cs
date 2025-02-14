namespace HMW6
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
            label1 = new Label();
            dim = new TextBox();
            p1 = new TextBox();
            p2 = new TextBox();
            p3 = new TextBox();
            p4 = new TextBox();
            p5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            generate = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            update = new Button();
            label7 = new Label();
            samples = new TextBox();
            tml = new Label();
            tvl = new Label();
            eml = new Label();
            evl = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Distribution size";
            // 
            // dim
            // 
            dim.Location = new Point(134, 13);
            dim.Name = "dim";
            dim.Size = new Size(54, 27);
            dim.TabIndex = 1;
            // 
            // p1
            // 
            p1.Location = new Point(91, 132);
            p1.Name = "p1";
            p1.Size = new Size(54, 27);
            p1.TabIndex = 2;
            // 
            // p2
            // 
            p2.Location = new Point(91, 188);
            p2.Name = "p2";
            p2.Size = new Size(54, 27);
            p2.TabIndex = 3;
            // 
            // p3
            // 
            p3.Location = new Point(91, 246);
            p3.Name = "p3";
            p3.Size = new Size(54, 27);
            p3.TabIndex = 4;
            // 
            // p4
            // 
            p4.Location = new Point(91, 308);
            p4.Name = "p4";
            p4.Size = new Size(54, 27);
            p4.TabIndex = 5;
            // 
            // p5
            // 
            p5.Location = new Point(91, 372);
            p5.Name = "p5";
            p5.Size = new Size(54, 27);
            p5.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 135);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 7;
            label2.Text = "p1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 191);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 8;
            label3.Text = "p2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 249);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 9;
            label4.Text = "p3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 311);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 10;
            label5.Text = "p4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 372);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 11;
            label6.Text = "p5";
            // 
            // generate
            // 
            generate.Location = new Point(59, 476);
            generate.Name = "generate";
            generate.Size = new Size(86, 29);
            generate.TabIndex = 12;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(267, 13);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(734, 492);
            chart1.TabIndex = 13;
            chart1.Text = "chart1";
            // 
            // update
            // 
            update.Location = new Point(59, 55);
            update.Name = "update";
            update.Size = new Size(86, 29);
            update.TabIndex = 14;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 441);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 15;
            label7.Text = "Samples";
            // 
            // samples
            // 
            samples.Location = new Point(91, 438);
            samples.Name = "samples";
            samples.Size = new Size(97, 27);
            samples.TabIndex = 16;
            // 
            // tml
            // 
            tml.AutoSize = true;
            tml.Location = new Point(1007, 145);
            tml.Name = "tml";
            tml.Size = new Size(127, 20);
            tml.TabIndex = 17;
            tml.Text = "Theoretical mean:";
            // 
            // tvl
            // 
            tvl.AutoSize = true;
            tvl.Location = new Point(1007, 201);
            tvl.Name = "tvl";
            tvl.Size = new Size(145, 20);
            tvl.TabIndex = 18;
            tvl.Text = "Theoretical variance:";
            // 
            // eml
            // 
            eml.AutoSize = true;
            eml.Location = new Point(1007, 257);
            eml.Name = "eml";
            eml.Size = new Size(115, 20);
            eml.TabIndex = 19;
            eml.Text = "Empirical mean:";
            // 
            // evl
            // 
            evl.AutoSize = true;
            evl.Location = new Point(1007, 315);
            evl.Name = "evl";
            evl.Size = new Size(133, 20);
            evl.TabIndex = 20;
            evl.Text = "Empirical variance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 517);
            Controls.Add(evl);
            Controls.Add(eml);
            Controls.Add(tvl);
            Controls.Add(tml);
            Controls.Add(samples);
            Controls.Add(label7);
            Controls.Add(update);
            Controls.Add(chart1);
            Controls.Add(generate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(p5);
            Controls.Add(p4);
            Controls.Add(p3);
            Controls.Add(p2);
            Controls.Add(p1);
            Controls.Add(dim);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Homework 6";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dim;
        private TextBox p1;
        private TextBox p2;
        private TextBox p3;
        private TextBox p4;
        private TextBox p5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button update;
        private Label label7;
        private TextBox samples;
        private Label tml;
        private Label tvl;
        private Label eml;
        private Label evl;
    }
}
