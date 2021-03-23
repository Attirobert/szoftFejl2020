namespace WindowsFormsApp1
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
            this.txbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUtoklsoFeladat = new System.Windows.Forms.Label();
            this.lbSkalarisSzorzat = new System.Windows.Forms.Label();
            this.lbForditottSkalarisSzorzat = new System.Windows.Forms.Label();
            this.lbAtloOsszeg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(151, 12);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(46, 20);
            this.txbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "természetes szám [5,15]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generald a matrixot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skaláris szorzat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "fordított skaláris szorzat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(m1 átlóösszeg- m2 atlóösszeg)";
            // 
            // lbUtoklsoFeladat
            // 
            this.lbUtoklsoFeladat.AutoSize = true;
            this.lbUtoklsoFeladat.Location = new System.Drawing.Point(196, 283);
            this.lbUtoklsoFeladat.Name = "lbUtoklsoFeladat";
            this.lbUtoklsoFeladat.Size = new System.Drawing.Size(0, 13);
            this.lbUtoklsoFeladat.TabIndex = 6;
            // 
            // lbSkalarisSzorzat
            // 
            this.lbSkalarisSzorzat.AutoSize = true;
            this.lbSkalarisSzorzat.Location = new System.Drawing.Point(144, 149);
            this.lbSkalarisSzorzat.Name = "lbSkalarisSzorzat";
            this.lbSkalarisSzorzat.Size = new System.Drawing.Size(0, 13);
            this.lbSkalarisSzorzat.TabIndex = 7;
            // 
            // lbForditottSkalarisSzorzat
            // 
            this.lbForditottSkalarisSzorzat.AutoSize = true;
            this.lbForditottSkalarisSzorzat.Location = new System.Drawing.Point(148, 188);
            this.lbForditottSkalarisSzorzat.Name = "lbForditottSkalarisSzorzat";
            this.lbForditottSkalarisSzorzat.Size = new System.Drawing.Size(0, 13);
            this.lbForditottSkalarisSzorzat.TabIndex = 8;
            // 
            // lbAtloOsszeg
            // 
            this.lbAtloOsszeg.AutoSize = true;
            this.lbAtloOsszeg.Location = new System.Drawing.Point(186, 237);
            this.lbAtloOsszeg.Name = "lbAtloOsszeg";
            this.lbAtloOsszeg.Size = new System.Drawing.Size(0, 13);
            this.lbAtloOsszeg.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "m1 átlója feletti terület számainak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 378);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbAtloOsszeg);
            this.Controls.Add(this.lbForditottSkalarisSzorzat);
            this.Controls.Add(this.lbSkalarisSzorzat);
            this.Controls.Add(this.lbUtoklsoFeladat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUtoklsoFeladat;
        private System.Windows.Forms.Label lbSkalarisSzorzat;
        private System.Windows.Forms.Label lbForditottSkalarisSzorzat;
        private System.Windows.Forms.Label lbAtloOsszeg;
        private System.Windows.Forms.Label label9;
    }
}

