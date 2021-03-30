namespace Proiect
{
    partial class Form1
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
            this.pathTB = new System.Windows.Forms.TextBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.aplicareFiltreBtn = new System.Windows.Forms.Button();
            this.rezultatFiltrareTB = new System.Windows.Forms.TextBox();
            this.playFilterBtn = new System.Windows.Forms.Button();
            this.stopFilterBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filtreCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ordinFnUD = new System.Windows.Forms.NumericUpDown();
            this.frecventaTnUD = new System.Windows.Forms.NumericUpDown();
            this.frecventaT1nUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adaugareZBtn = new System.Windows.Forms.Button();
            this.SNRnUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.informatieLabel = new System.Windows.Forms.Label();
            this.zaGRB = new System.Windows.Forms.RadioButton();
            this.fRB = new System.Windows.Forms.RadioButton();
            this.cERB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.zaGGB = new System.Windows.Forms.GroupBox();
            this.fGB = new System.Windows.Forms.GroupBox();
            this.creareEBtn = new System.Windows.Forms.Button();
            this.reducereEBtn = new System.Windows.Forms.Button();
            this.reducereERB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinFnUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecventaTnUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecventaT1nUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNRnUD)).BeginInit();
            this.zaGGB.SuspendLayout();
            this.fGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTB
            // 
            this.pathTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTB.Location = new System.Drawing.Point(167, 40);
            this.pathTB.Name = "pathTB";
            this.pathTB.ReadOnly = true;
            this.pathTB.Size = new System.Drawing.Size(290, 24);
            this.pathTB.TabIndex = 1;
            // 
            // playBtn
            // 
            this.playBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playBtn.AutoSize = true;
            this.playBtn.Location = new System.Drawing.Point(463, 34);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(84, 30);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopBtn.AutoSize = true;
            this.stopBtn.Location = new System.Drawing.Point(553, 34);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(84, 30);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chooseFileBtn.AutoSize = true;
            this.chooseFileBtn.Location = new System.Drawing.Point(-2, 34);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(163, 30);
            this.chooseFileBtn.TabIndex = 4;
            this.chooseFileBtn.Text = "Alegeti fisierul audio";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // aplicareFiltreBtn
            // 
            this.aplicareFiltreBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aplicareFiltreBtn.AutoSize = true;
            this.aplicareFiltreBtn.Location = new System.Drawing.Point(465, 19);
            this.aplicareFiltreBtn.Name = "aplicareFiltreBtn";
            this.aplicareFiltreBtn.Size = new System.Drawing.Size(84, 30);
            this.aplicareFiltreBtn.TabIndex = 6;
            this.aplicareFiltreBtn.Text = "Aplicati";
            this.aplicareFiltreBtn.UseVisualStyleBackColor = true;
            this.aplicareFiltreBtn.Click += new System.EventHandler(this.aplicareFiltreBtn_Click);
            // 
            // rezultatFiltrareTB
            // 
            this.rezultatFiltrareTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rezultatFiltrareTB.Location = new System.Drawing.Point(-2, 272);
            this.rezultatFiltrareTB.Name = "rezultatFiltrareTB";
            this.rezultatFiltrareTB.ReadOnly = true;
            this.rezultatFiltrareTB.Size = new System.Drawing.Size(459, 24);
            this.rezultatFiltrareTB.TabIndex = 7;
            // 
            // playFilterBtn
            // 
            this.playFilterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playFilterBtn.AutoSize = true;
            this.playFilterBtn.Location = new System.Drawing.Point(463, 266);
            this.playFilterBtn.Name = "playFilterBtn";
            this.playFilterBtn.Size = new System.Drawing.Size(84, 30);
            this.playFilterBtn.TabIndex = 8;
            this.playFilterBtn.Text = "Play";
            this.playFilterBtn.UseVisualStyleBackColor = true;
            this.playFilterBtn.Click += new System.EventHandler(this.playFilterBtn_Click);
            // 
            // stopFilterBtn
            // 
            this.stopFilterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopFilterBtn.AutoSize = true;
            this.stopFilterBtn.Location = new System.Drawing.Point(553, 266);
            this.stopFilterBtn.Name = "stopFilterBtn";
            this.stopFilterBtn.Size = new System.Drawing.Size(84, 30);
            this.stopFilterBtn.TabIndex = 9;
            this.stopFilterBtn.Text = "Stop";
            this.stopFilterBtn.UseVisualStyleBackColor = true;
            this.stopFilterBtn.Click += new System.EventHandler(this.stopFilterBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // filtreCB
            // 
            this.filtreCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filtreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtreCB.FormattingEnabled = true;
            this.filtreCB.Items.AddRange(new object[] {
            "Filtru trece - jos",
            "Filtru trece - sus",
            "Filtru trece - banda",
            "Filtru opreste banda"});
            this.filtreCB.Location = new System.Drawing.Point(169, 23);
            this.filtreCB.Name = "filtreCB";
            this.filtreCB.Size = new System.Drawing.Size(290, 26);
            this.filtreCB.TabIndex = 12;
            this.filtreCB.SelectedIndexChanged += new System.EventHandler(this.filtreCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Alegeti tipul filtrului";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ordinul de filtrare (N)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Frecventa de taiere (Wn)";
            // 
            // ordinFnUD
            // 
            this.ordinFnUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ordinFnUD.Enabled = false;
            this.ordinFnUD.Location = new System.Drawing.Point(327, 55);
            this.ordinFnUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ordinFnUD.Name = "ordinFnUD";
            this.ordinFnUD.Size = new System.Drawing.Size(100, 24);
            this.ordinFnUD.TabIndex = 19;
            this.ordinFnUD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // frecventaTnUD
            // 
            this.frecventaTnUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frecventaTnUD.DecimalPlaces = 2;
            this.frecventaTnUD.Enabled = false;
            this.frecventaTnUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frecventaTnUD.Location = new System.Drawing.Point(327, 86);
            this.frecventaTnUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.frecventaTnUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frecventaTnUD.Name = "frecventaTnUD";
            this.frecventaTnUD.Size = new System.Drawing.Size(100, 24);
            this.frecventaTnUD.TabIndex = 20;
            this.frecventaTnUD.Value = new decimal(new int[] {
            80,
            0,
            0,
            131072});
            // 
            // frecventaT1nUD
            // 
            this.frecventaT1nUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frecventaT1nUD.DecimalPlaces = 2;
            this.frecventaT1nUD.Enabled = false;
            this.frecventaT1nUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frecventaT1nUD.Location = new System.Drawing.Point(433, 86);
            this.frecventaT1nUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.frecventaT1nUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frecventaT1nUD.Name = "frecventaT1nUD";
            this.frecventaT1nUD.Size = new System.Drawing.Size(100, 24);
            this.frecventaT1nUD.TabIndex = 21;
            this.frecventaT1nUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zgomot alb Gaussian (SNR)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Rezultat";
            // 
            // adaugareZBtn
            // 
            this.adaugareZBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adaugareZBtn.AutoSize = true;
            this.adaugareZBtn.Location = new System.Drawing.Point(333, 15);
            this.adaugareZBtn.Name = "adaugareZBtn";
            this.adaugareZBtn.Size = new System.Drawing.Size(135, 28);
            this.adaugareZBtn.TabIndex = 24;
            this.adaugareZBtn.Text = "Adaugare zgomot";
            this.adaugareZBtn.UseVisualStyleBackColor = true;
            this.adaugareZBtn.Click += new System.EventHandler(this.adaugareZBtn_Click);
            // 
            // SNRnUD
            // 
            this.SNRnUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SNRnUD.Location = new System.Drawing.Point(178, 18);
            this.SNRnUD.Name = "SNRnUD";
            this.SNRnUD.Size = new System.Drawing.Size(100, 24);
            this.SNRnUD.TabIndex = 25;
            this.SNRnUD.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "dB";
            // 
            // informatieLabel
            // 
            this.informatieLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.informatieLabel.AutoSize = true;
            this.informatieLabel.Location = new System.Drawing.Point(326, 113);
            this.informatieLabel.Name = "informatieLabel";
            this.informatieLabel.Size = new System.Drawing.Size(101, 18);
            this.informatieLabel.TabIndex = 27;
            this.informatieLabel.Text = "0 < Wn < 1.00";
            this.informatieLabel.Visible = false;
            // 
            // zaGRB
            // 
            this.zaGRB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zaGRB.AutoSize = true;
            this.zaGRB.Location = new System.Drawing.Point(167, 74);
            this.zaGRB.Name = "zaGRB";
            this.zaGRB.Size = new System.Drawing.Size(171, 22);
            this.zaGRB.TabIndex = 28;
            this.zaGRB.TabStop = true;
            this.zaGRB.Text = "Zgomot alb Gaussian";
            this.zaGRB.UseVisualStyleBackColor = true;
            this.zaGRB.CheckedChanged += new System.EventHandler(this.zaGRB_CheckedChanged);
            // 
            // fRB
            // 
            this.fRB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fRB.AutoSize = true;
            this.fRB.Location = new System.Drawing.Point(322, 74);
            this.fRB.Name = "fRB";
            this.fRB.Size = new System.Drawing.Size(74, 22);
            this.fRB.TabIndex = 29;
            this.fRB.TabStop = true;
            this.fRB.Text = "Filtrare";
            this.fRB.UseVisualStyleBackColor = true;
            this.fRB.CheckedChanged += new System.EventHandler(this.zaGRB_CheckedChanged);
            // 
            // cERB
            // 
            this.cERB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cERB.AutoSize = true;
            this.cERB.Location = new System.Drawing.Point(399, 74);
            this.cERB.Name = "cERB";
            this.cERB.Size = new System.Drawing.Size(111, 22);
            this.cERB.TabIndex = 30;
            this.cERB.TabStop = true;
            this.cERB.Text = "Creare ecou";
            this.cERB.UseVisualStyleBackColor = true;
            this.cERB.CheckedChanged += new System.EventHandler(this.zaGRB_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Selectati actiunea";
            // 
            // zaGGB
            // 
            this.zaGGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zaGGB.Controls.Add(this.label4);
            this.zaGGB.Controls.Add(this.adaugareZBtn);
            this.zaGGB.Controls.Add(this.SNRnUD);
            this.zaGGB.Controls.Add(this.label6);
            this.zaGGB.Location = new System.Drawing.Point(-2, 102);
            this.zaGGB.Name = "zaGGB";
            this.zaGGB.Size = new System.Drawing.Size(639, 53);
            this.zaGGB.TabIndex = 32;
            this.zaGGB.TabStop = false;
            this.zaGGB.Visible = false;
            // 
            // fGB
            // 
            this.fGB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fGB.Controls.Add(this.filtreCB);
            this.fGB.Controls.Add(this.aplicareFiltreBtn);
            this.fGB.Controls.Add(this.label1);
            this.fGB.Controls.Add(this.label2);
            this.fGB.Controls.Add(this.label3);
            this.fGB.Controls.Add(this.informatieLabel);
            this.fGB.Controls.Add(this.ordinFnUD);
            this.fGB.Controls.Add(this.frecventaTnUD);
            this.fGB.Controls.Add(this.frecventaT1nUD);
            this.fGB.Location = new System.Drawing.Point(-2, 102);
            this.fGB.Name = "fGB";
            this.fGB.Size = new System.Drawing.Size(639, 141);
            this.fGB.TabIndex = 33;
            this.fGB.TabStop = false;
            this.fGB.Visible = false;
            // 
            // creareEBtn
            // 
            this.creareEBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creareEBtn.AutoSize = true;
            this.creareEBtn.Location = new System.Drawing.Point(251, 112);
            this.creareEBtn.Name = "creareEBtn";
            this.creareEBtn.Size = new System.Drawing.Size(100, 28);
            this.creareEBtn.TabIndex = 0;
            this.creareEBtn.Text = "Creare ecou";
            this.creareEBtn.UseVisualStyleBackColor = true;
            this.creareEBtn.Visible = false;
            this.creareEBtn.Click += new System.EventHandler(this.creareEBtn_Click);
            // 
            // reducereEBtn
            // 
            this.reducereEBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reducereEBtn.AutoSize = true;
            this.reducereEBtn.Location = new System.Drawing.Point(242, 112);
            this.reducereEBtn.Name = "reducereEBtn";
            this.reducereEBtn.Size = new System.Drawing.Size(119, 28);
            this.reducereEBtn.TabIndex = 34;
            this.reducereEBtn.Text = "Reducere ecou";
            this.reducereEBtn.UseVisualStyleBackColor = true;
            this.reducereEBtn.Visible = false;
            this.reducereEBtn.Click += new System.EventHandler(this.reducereEBtn_Click);
            // 
            // reducereERB
            // 
            this.reducereERB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reducereERB.AutoSize = true;
            this.reducereERB.Location = new System.Drawing.Point(501, 74);
            this.reducereERB.Name = "reducereERB";
            this.reducereERB.Size = new System.Drawing.Size(130, 22);
            this.reducereERB.TabIndex = 35;
            this.reducereERB.TabStop = true;
            this.reducereERB.Text = "Reducere ecou";
            this.reducereERB.UseVisualStyleBackColor = true;
            this.reducereERB.CheckedChanged += new System.EventHandler(this.zaGRB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(981, 466);
            this.Controls.Add(this.reducereERB);
            this.Controls.Add(this.reducereEBtn);
            this.Controls.Add(this.creareEBtn);
            this.Controls.Add(this.fGB);
            this.Controls.Add(this.zaGGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cERB);
            this.Controls.Add(this.fRB);
            this.Controls.Add(this.zaGRB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopFilterBtn);
            this.Controls.Add(this.playFilterBtn);
            this.Controls.Add(this.rezultatFiltrareTB);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.pathTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesare semnale audio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinFnUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecventaTnUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecventaT1nUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNRnUD)).EndInit();
            this.zaGGB.ResumeLayout(false);
            this.zaGGB.PerformLayout();
            this.fGB.ResumeLayout(false);
            this.fGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Button aplicareFiltreBtn;
        private System.Windows.Forms.TextBox rezultatFiltrareTB;
        private System.Windows.Forms.Button playFilterBtn;
        private System.Windows.Forms.Button stopFilterBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox filtreCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ordinFnUD;
        private System.Windows.Forms.NumericUpDown frecventaTnUD;
        private System.Windows.Forms.NumericUpDown frecventaT1nUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adaugareZBtn;
        private System.Windows.Forms.NumericUpDown SNRnUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label informatieLabel;
        private System.Windows.Forms.RadioButton zaGRB;
        private System.Windows.Forms.RadioButton fRB;
        private System.Windows.Forms.RadioButton cERB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox zaGGB;
        private System.Windows.Forms.GroupBox fGB;
        private System.Windows.Forms.Button creareEBtn;
        private System.Windows.Forms.Button reducereEBtn;
        private System.Windows.Forms.RadioButton reducereERB;
    }
}

