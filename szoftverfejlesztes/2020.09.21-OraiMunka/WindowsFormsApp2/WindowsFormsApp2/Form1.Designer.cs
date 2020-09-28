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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.BtnTotalBottom = new System.Windows.Forms.Button();
            this.BtnBottom = new System.Windows.Forms.Button();
            this.btnTotalRight = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnTotalLeft = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnMiddle = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.BtnTotalTop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.BtnTotalBottom);
            this.panel1.Controls.Add(this.BtnBottom);
            this.panel1.Controls.Add(this.btnTotalRight);
            this.panel1.Controls.Add(this.BtnRight);
            this.panel1.Controls.Add(this.BtnTotalLeft);
            this.panel1.Controls.Add(this.BtnLeft);
            this.panel1.Controls.Add(this.BtnMiddle);
            this.panel1.Controls.Add(this.BtnTop);
            this.panel1.Controls.Add(this.BtnTotalTop);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Location = new System.Drawing.Point(245, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Átlátszóság";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(156, 31);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "button12";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(20, 31);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // BtnTotalBottom
            // 
            this.BtnTotalBottom.Location = new System.Drawing.Point(339, 242);
            this.BtnTotalBottom.Name = "BtnTotalBottom";
            this.BtnTotalBottom.Size = new System.Drawing.Size(75, 30);
            this.BtnTotalBottom.TabIndex = 1;
            this.BtnTotalBottom.Text = "Aljára";
            this.BtnTotalBottom.UseVisualStyleBackColor = true;
            this.BtnTotalBottom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTotalBottom_MouseClick);
            // 
            // BtnBottom
            // 
            this.BtnBottom.Location = new System.Drawing.Point(339, 199);
            this.BtnBottom.Name = "BtnBottom";
            this.BtnBottom.Size = new System.Drawing.Size(75, 30);
            this.BtnBottom.TabIndex = 1;
            this.BtnBottom.Text = "Le";
            this.BtnBottom.UseVisualStyleBackColor = true;
            this.BtnBottom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnBottom_MouseClick);
            // 
            // btnTotalRight
            // 
            this.btnTotalRight.Location = new System.Drawing.Point(531, 158);
            this.btnTotalRight.Name = "btnTotalRight";
            this.btnTotalRight.Size = new System.Drawing.Size(75, 30);
            this.btnTotalRight.TabIndex = 1;
            this.btnTotalRight.Text = "Jobbszélre";
            this.btnTotalRight.UseVisualStyleBackColor = true;
            this.btnTotalRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTotalRight_MouseClick);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(430, 158);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(75, 30);
            this.BtnRight.TabIndex = 1;
            this.BtnRight.Text = "Jobbra";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRight_MouseClick);
            // 
            // BtnTotalLeft
            // 
            this.BtnTotalLeft.Location = new System.Drawing.Point(154, 158);
            this.BtnTotalLeft.Name = "BtnTotalLeft";
            this.BtnTotalLeft.Size = new System.Drawing.Size(75, 30);
            this.BtnTotalLeft.TabIndex = 1;
            this.BtnTotalLeft.Text = "Balszélre";
            this.BtnTotalLeft.UseVisualStyleBackColor = true;
            this.BtnTotalLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTotalLeft_MouseClick);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(246, 158);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(75, 30);
            this.BtnLeft.TabIndex = 1;
            this.BtnLeft.Text = "Balra";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnLeft_MouseClick);
            // 
            // BtnMiddle
            // 
            this.BtnMiddle.Location = new System.Drawing.Point(339, 158);
            this.BtnMiddle.Name = "BtnMiddle";
            this.BtnMiddle.Size = new System.Drawing.Size(75, 30);
            this.BtnMiddle.TabIndex = 1;
            this.BtnMiddle.Text = "Középre";
            this.BtnMiddle.UseVisualStyleBackColor = true;
            this.BtnMiddle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMiddle_MouseClick);
            // 
            // BtnTop
            // 
            this.BtnTop.Location = new System.Drawing.Point(339, 116);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(75, 30);
            this.BtnTop.TabIndex = 1;
            this.BtnTop.Text = "Fel";
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTop_MouseClick);
            // 
            // BtnTotalTop
            // 
            this.BtnTotalTop.Location = new System.Drawing.Point(339, 78);
            this.BtnTotalTop.Name = "BtnTotalTop";
            this.BtnTotalTop.Size = new System.Drawing.Size(75, 30);
            this.BtnTotalTop.TabIndex = 1;
            this.BtnTotalTop.Text = "Tetejére";
            this.BtnTotalTop.UseVisualStyleBackColor = true;
            this.BtnTotalTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTotalTop_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(232, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Méret";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Növekszik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Csökken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button BtnTotalBottom;
        private System.Windows.Forms.Button BtnBottom;
        private System.Windows.Forms.Button btnTotalRight;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnTotalLeft;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnMiddle;
        private System.Windows.Forms.Button BtnTop;
        private System.Windows.Forms.Button BtnTotalTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

