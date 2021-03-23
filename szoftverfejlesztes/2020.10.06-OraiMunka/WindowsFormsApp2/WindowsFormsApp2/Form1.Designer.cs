namespace WindowsFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxFelkover = new System.Windows.Forms.CheckBox();
            this.cbxAlahuzott = new System.Windows.Forms.CheckBox();
            this.cbxDolt = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCs = new System.Windows.Forms.RadioButton();
            this.rbTnr = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.cbxValaszt = new System.Windows.Forms.ComboBox();
            this.nudMeret = new System.Windows.Forms.NumericUpDown();
            this.txbSzoveg = new System.Windows.Forms.TextBox();
            this.btnAlkalmaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbSzoveg = new System.Windows.Forms.RichTextBox();
            this.rbPiros = new System.Windows.Forms.RadioButton();
            this.rbKek = new System.Windows.Forms.RadioButton();
            this.rbZold = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZold);
            this.groupBox1.Controls.Add(this.rbKek);
            this.groupBox1.Controls.Add(this.rbPiros);
            this.groupBox1.Location = new System.Drawing.Point(21, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szín";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxFelkover);
            this.groupBox2.Controls.Add(this.cbxAlahuzott);
            this.groupBox2.Controls.Add(this.cbxDolt);
            this.groupBox2.Location = new System.Drawing.Point(241, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 234);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stílus";
            // 
            // cbxFelkover
            // 
            this.cbxFelkover.AutoSize = true;
            this.cbxFelkover.Location = new System.Drawing.Point(53, 167);
            this.cbxFelkover.Name = "cbxFelkover";
            this.cbxFelkover.Size = new System.Drawing.Size(64, 17);
            this.cbxFelkover.TabIndex = 2;
            this.cbxFelkover.Text = "félkövér";
            this.cbxFelkover.UseVisualStyleBackColor = true;
            // 
            // cbxAlahuzott
            // 
            this.cbxAlahuzott.AutoSize = true;
            this.cbxAlahuzott.Location = new System.Drawing.Point(53, 110);
            this.cbxAlahuzott.Name = "cbxAlahuzott";
            this.cbxAlahuzott.Size = new System.Drawing.Size(69, 17);
            this.cbxAlahuzott.TabIndex = 1;
            this.cbxAlahuzott.Text = "alahuzott";
            this.cbxAlahuzott.UseVisualStyleBackColor = true;
            // 
            // cbxDolt
            // 
            this.cbxDolt.AutoSize = true;
            this.cbxDolt.Location = new System.Drawing.Point(53, 63);
            this.cbxDolt.Name = "cbxDolt";
            this.cbxDolt.Size = new System.Drawing.Size(43, 17);
            this.cbxDolt.TabIndex = 0;
            this.cbxDolt.Text = "dölt";
            this.cbxDolt.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCs);
            this.groupBox3.Controls.Add(this.rbTnr);
            this.groupBox3.Controls.Add(this.rbArial);
            this.groupBox3.Location = new System.Drawing.Point(441, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 234);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font";
            // 
            // rbCs
            // 
            this.rbCs.AutoSize = true;
            this.rbCs.Location = new System.Drawing.Point(53, 167);
            this.rbCs.Name = "rbCs";
            this.rbCs.Size = new System.Drawing.Size(81, 17);
            this.rbCs.TabIndex = 3;
            this.rbCs.TabStop = true;
            this.rbCs.Text = "Comic Sans";
            this.rbCs.UseVisualStyleBackColor = true;
            // 
            // rbTnr
            // 
            this.rbTnr.AutoSize = true;
            this.rbTnr.Location = new System.Drawing.Point(53, 103);
            this.rbTnr.Name = "rbTnr";
            this.rbTnr.Size = new System.Drawing.Size(115, 17);
            this.rbTnr.TabIndex = 3;
            this.rbTnr.TabStop = true;
            this.rbTnr.Text = "Times New Roman";
            this.rbTnr.UseVisualStyleBackColor = true;
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(53, 43);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(45, 17);
            this.rbArial.TabIndex = 3;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            // 
            // cbxValaszt
            // 
            this.cbxValaszt.FormattingEnabled = true;
            this.cbxValaszt.Location = new System.Drawing.Point(121, 30);
            this.cbxValaszt.Name = "cbxValaszt";
            this.cbxValaszt.Size = new System.Drawing.Size(121, 21);
            this.cbxValaszt.TabIndex = 1;
            this.cbxValaszt.SelectedValueChanged += new System.EventHandler(this.cbxValaszt_SelectedValueChanged);
            // 
            // nudMeret
            // 
            this.nudMeret.Location = new System.Drawing.Point(121, 71);
            this.nudMeret.Name = "nudMeret";
            this.nudMeret.Size = new System.Drawing.Size(120, 20);
            this.nudMeret.TabIndex = 2;
            // 
            // txbSzoveg
            // 
            this.txbSzoveg.Location = new System.Drawing.Point(643, 222);
            this.txbSzoveg.Name = "txbSzoveg";
            this.txbSzoveg.Size = new System.Drawing.Size(100, 20);
            this.txbSzoveg.TabIndex = 4;
            // 
            // btnAlkalmaz
            // 
            this.btnAlkalmaz.Location = new System.Drawing.Point(643, 282);
            this.btnAlkalmaz.Name = "btnAlkalmaz";
            this.btnAlkalmaz.Size = new System.Drawing.Size(75, 23);
            this.btnAlkalmaz.TabIndex = 5;
            this.btnAlkalmaz.Text = "Alkalmaz";
            this.btnAlkalmaz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mit választ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Új szöveg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font méret";
            // 
            // rtbSzoveg
            // 
            this.rtbSzoveg.Location = new System.Drawing.Point(294, 13);
            this.rtbSzoveg.Name = "rtbSzoveg";
            this.rtbSzoveg.Size = new System.Drawing.Size(474, 130);
            this.rtbSzoveg.TabIndex = 7;
            this.rtbSzoveg.Text = "";
            // 
            // rbPiros
            // 
            this.rbPiros.AutoSize = true;
            this.rbPiros.Location = new System.Drawing.Point(36, 63);
            this.rbPiros.Name = "rbPiros";
            this.rbPiros.Size = new System.Drawing.Size(47, 17);
            this.rbPiros.TabIndex = 3;
            this.rbPiros.TabStop = true;
            this.rbPiros.Text = "piros";
            this.rbPiros.UseVisualStyleBackColor = true;
            // 
            // rbKek
            // 
            this.rbKek.AutoSize = true;
            this.rbKek.Location = new System.Drawing.Point(36, 110);
            this.rbKek.Name = "rbKek";
            this.rbKek.Size = new System.Drawing.Size(43, 17);
            this.rbKek.TabIndex = 3;
            this.rbKek.TabStop = true;
            this.rbKek.Text = "kek";
            this.rbKek.UseVisualStyleBackColor = true;
            // 
            // rbZold
            // 
            this.rbZold.AutoSize = true;
            this.rbZold.Location = new System.Drawing.Point(36, 167);
            this.rbZold.Name = "rbZold";
            this.rbZold.Size = new System.Drawing.Size(44, 17);
            this.rbZold.TabIndex = 4;
            this.rbZold.TabStop = true;
            this.rbZold.Text = "zold";
            this.rbZold.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSzoveg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlkalmaz);
            this.Controls.Add(this.txbSzoveg);
            this.Controls.Add(this.nudMeret);
            this.Controls.Add(this.cbxValaszt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxFelkover;
        private System.Windows.Forms.CheckBox cbxAlahuzott;
        private System.Windows.Forms.CheckBox cbxDolt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCs;
        private System.Windows.Forms.RadioButton rbTnr;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.ComboBox cbxValaszt;
        private System.Windows.Forms.NumericUpDown nudMeret;
        private System.Windows.Forms.TextBox txbSzoveg;
        private System.Windows.Forms.Button btnAlkalmaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbSzoveg;
        private System.Windows.Forms.RadioButton rbZold;
        private System.Windows.Forms.RadioButton rbKek;
        private System.Windows.Forms.RadioButton rbPiros;
    }
}

