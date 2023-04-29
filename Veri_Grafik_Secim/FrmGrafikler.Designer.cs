namespace Veri_Grafik_Secim
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblE = new System.Windows.Forms.Label();
            this.LblSiralama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblEE = new System.Windows.Forms.Label();
            this.LblDD = new System.Windows.Forms.Label();
            this.LblCC = new System.Windows.Forms.Label();
            this.LblBB = new System.Windows.Forms.Label();
            this.LblAA = new System.Windows.Forms.Label();
            this.LblSira1 = new System.Windows.Forms.Label();
            this.LblSira2 = new System.Windows.Forms.Label();
            this.LblSira3 = new System.Windows.Forms.Label();
            this.LblSira5 = new System.Windows.Forms.Label();
            this.LblSira4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1070, 345);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblSira5);
            this.groupBox2.Controls.Add(this.LblSira4);
            this.groupBox2.Controls.Add(this.LblSira3);
            this.groupBox2.Controls.Add(this.LblSira2);
            this.groupBox2.Controls.Add(this.LblSira1);
            this.groupBox2.Controls.Add(this.LblEE);
            this.groupBox2.Controls.Add(this.LblDD);
            this.groupBox2.Controls.Add(this.LblCC);
            this.groupBox2.Controls.Add(this.LblBB);
            this.groupBox2.Controls.Add(this.LblAA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LblSiralama);
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(143, 105);
            this.progressBar1.Maximum = 250;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 40);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(143, 151);
            this.progressBar2.Maximum = 250;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(272, 40);
            this.progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(143, 197);
            this.progressBar3.Maximum = 250;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(272, 40);
            this.progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(143, 243);
            this.progressBar4.Maximum = 250;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(272, 40);
            this.progressBar4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(143, 289);
            this.progressBar5.Maximum = 250;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(272, 40);
            this.progressBar5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(458, 115);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(21, 21);
            this.LblA.TabIndex = 12;
            this.LblA.Text = "0";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(458, 161);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(21, 21);
            this.LblB.TabIndex = 13;
            this.LblB.Text = "0";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(458, 207);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(21, 21);
            this.LblC.TabIndex = 14;
            this.LblC.Text = "0";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(458, 253);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(21, 21);
            this.LblD.TabIndex = 15;
            this.LblD.Text = "0";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(458, 299);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(21, 21);
            this.LblE.TabIndex = 16;
            this.LblE.Text = "0";
            // 
            // LblSiralama
            // 
            this.LblSiralama.AutoSize = true;
            this.LblSiralama.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSiralama.Location = new System.Drawing.Point(746, 51);
            this.LblSiralama.Name = "LblSiralama";
            this.LblSiralama.Size = new System.Drawing.Size(217, 39);
            this.LblSiralama.TabIndex = 17;
            this.LblSiralama.Text = "SIRALAMA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Yüzdeler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Aldığı Oy";
            // 
            // LblEE
            // 
            this.LblEE.AutoSize = true;
            this.LblEE.Location = new System.Drawing.Point(568, 299);
            this.LblEE.Name = "LblEE";
            this.LblEE.Size = new System.Drawing.Size(21, 21);
            this.LblEE.TabIndex = 24;
            this.LblEE.Text = "0";
            // 
            // LblDD
            // 
            this.LblDD.AutoSize = true;
            this.LblDD.Location = new System.Drawing.Point(568, 253);
            this.LblDD.Name = "LblDD";
            this.LblDD.Size = new System.Drawing.Size(21, 21);
            this.LblDD.TabIndex = 23;
            this.LblDD.Text = "0";
            // 
            // LblCC
            // 
            this.LblCC.AutoSize = true;
            this.LblCC.Location = new System.Drawing.Point(568, 207);
            this.LblCC.Name = "LblCC";
            this.LblCC.Size = new System.Drawing.Size(21, 21);
            this.LblCC.TabIndex = 22;
            this.LblCC.Text = "0";
            // 
            // LblBB
            // 
            this.LblBB.AutoSize = true;
            this.LblBB.Location = new System.Drawing.Point(568, 161);
            this.LblBB.Name = "LblBB";
            this.LblBB.Size = new System.Drawing.Size(21, 21);
            this.LblBB.TabIndex = 21;
            this.LblBB.Text = "0";
            // 
            // LblAA
            // 
            this.LblAA.AutoSize = true;
            this.LblAA.Location = new System.Drawing.Point(568, 115);
            this.LblAA.Name = "LblAA";
            this.LblAA.Size = new System.Drawing.Size(21, 21);
            this.LblAA.TabIndex = 20;
            this.LblAA.Text = "0";
            // 
            // LblSira1
            // 
            this.LblSira1.AutoSize = true;
            this.LblSira1.Location = new System.Drawing.Point(807, 115);
            this.LblSira1.Name = "LblSira1";
            this.LblSira1.Size = new System.Drawing.Size(82, 21);
            this.LblSira1.TabIndex = 25;
            this.LblSira1.Text = "Aldığı Oy";
            // 
            // LblSira2
            // 
            this.LblSira2.AutoSize = true;
            this.LblSira2.Location = new System.Drawing.Point(807, 161);
            this.LblSira2.Name = "LblSira2";
            this.LblSira2.Size = new System.Drawing.Size(82, 21);
            this.LblSira2.TabIndex = 26;
            this.LblSira2.Text = "Aldığı Oy";
            // 
            // LblSira3
            // 
            this.LblSira3.AutoSize = true;
            this.LblSira3.Location = new System.Drawing.Point(807, 207);
            this.LblSira3.Name = "LblSira3";
            this.LblSira3.Size = new System.Drawing.Size(82, 21);
            this.LblSira3.TabIndex = 27;
            this.LblSira3.Text = "Aldığı Oy";
            // 
            // LblSira5
            // 
            this.LblSira5.AutoSize = true;
            this.LblSira5.Location = new System.Drawing.Point(807, 299);
            this.LblSira5.Name = "LblSira5";
            this.LblSira5.Size = new System.Drawing.Size(82, 21);
            this.LblSira5.TabIndex = 29;
            this.LblSira5.Text = "Aldığı Oy";
            // 
            // LblSira4
            // 
            this.LblSira4.AutoSize = true;
            this.LblSira4.Location = new System.Drawing.Point(807, 253);
            this.LblSira4.Name = "LblSira4";
            this.LblSira4.Size = new System.Drawing.Size(82, 21);
            this.LblSira4.TabIndex = 28;
            this.LblSira4.Text = "Aldığı Oy";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1125, 759);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEE;
        private System.Windows.Forms.Label LblDD;
        private System.Windows.Forms.Label LblCC;
        private System.Windows.Forms.Label LblBB;
        private System.Windows.Forms.Label LblAA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSiralama;
        private System.Windows.Forms.Label LblSira5;
        private System.Windows.Forms.Label LblSira4;
        private System.Windows.Forms.Label LblSira3;
        private System.Windows.Forms.Label LblSira2;
        private System.Windows.Forms.Label LblSira1;
    }
}