namespace BERKAYDENIZPersonelTakipOtomasyonu
{
    partial class frmGrafik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Maaş";
            series19.YValuesPerPoint = 4;
            series20.ChartArea = "ChartArea1";
            series20.Enabled = false;
            series20.Legend = "Legend1";
            series20.Name = "Yaş Ortalaması";
            series21.ChartArea = "ChartArea1";
            series21.Enabled = false;
            series21.Legend = "Legend1";
            series21.Name = "Kişi Sayısı";
            series22.ChartArea = "ChartArea1";
            series22.Enabled = false;
            series22.Legend = "Legend1";
            series22.Name = "Maaş Ortalaması";
            series23.ChartArea = "ChartArea1";
            series23.Color = System.Drawing.Color.Blue;
            series23.Enabled = false;
            series23.Legend = "Legend1";
            series23.Name = "Erkek";
            series24.ChartArea = "ChartArea1";
            series24.Color = System.Drawing.Color.Fuchsia;
            series24.Enabled = false;
            series24.Legend = "Legend1";
            series24.Name = "Kadın";
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(501, 321);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Maaş - Cinsiyet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Maaş - Yaş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Maaş - Departman";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(631, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Yaş Ortalaması - Departman";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(631, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Yaş Ortalaması - Cinsiyet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(519, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 51);
            this.button6.TabIndex = 6;
            this.button6.Text = "Maaş - İl";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(519, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 51);
            this.button7.TabIndex = 7;
            this.button7.Text = "Kişi Sayısı - Maaş Aralığı ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(743, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 51);
            this.button8.TabIndex = 8;
            this.button8.Text = "Kişi Sayısı - Yaş";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(743, 126);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 51);
            this.button9.TabIndex = 9;
            this.button9.Text = "Kişi Sayısı - Departman";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(743, 183);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 51);
            this.button10.TabIndex = 10;
            this.button10.Text = "Kişi Sayısı - İl";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(743, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(106, 51);
            this.button11.TabIndex = 11;
            this.button11.Text = "Kişi Sayısı - Cinsiyet";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(631, 183);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(106, 51);
            this.button12.TabIndex = 12;
            this.button12.Text = "Yaş Ortalaması - İl";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(855, 69);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(106, 51);
            this.button13.TabIndex = 13;
            this.button13.Text = "Maaş Ortalaması - Yaş";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(631, 69);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(106, 51);
            this.button14.TabIndex = 14;
            this.button14.Text = "Yaş Ortalaması -Maaş";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(855, 183);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(106, 51);
            this.button15.TabIndex = 15;
            this.button15.Text = "Maaş Ortalaması -  İl";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(855, 12);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(106, 51);
            this.button16.TabIndex = 16;
            this.button16.Text = "Maaş Ortalaması - Cinsiyet";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(855, 126);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(106, 51);
            this.button17.TabIndex = 17;
            this.button17.Text = "Maaş Ortalaması - Departman";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(631, 240);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(106, 51);
            this.button18.TabIndex = 18;
            this.button18.Text = "Departman - Kişi Sayısı ,Cinsiyet";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(743, 240);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(106, 51);
            this.button19.TabIndex = 19;
            this.button19.Text = "Maaş Ortalaması,Departman - Kişi Sayısı,Cinsiyet";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(855, 240);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(106, 51);
            this.button20.TabIndex = 20;
            this.button20.Text = "Çıkış";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // frmGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 345);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "frmGrafik";
            this.Text = "Grafik Sayfası";
            this.Load += new System.EventHandler(this.frmGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}