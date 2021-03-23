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
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbLNKO = new System.Windows.Forms.RadioButton();
            this.rbLKKO = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(121, 93);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 20);
            this.tbxA.TabIndex = 0;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(121, 131);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 20);
            this.tbxB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valasszon";
            // 
            // rbLNKO
            // 
            this.rbLNKO.AutoSize = true;
            this.rbLNKO.Location = new System.Drawing.Point(282, 93);
            this.rbLNKO.Name = "rbLNKO";
            this.rbLNKO.Size = new System.Drawing.Size(54, 17);
            this.rbLNKO.TabIndex = 3;
            this.rbLNKO.TabStop = true;
            this.rbLNKO.Text = "LNKO";
            this.rbLNKO.UseVisualStyleBackColor = true;
            // 
            // rbLKKO
            // 
            this.rbLKKO.AutoSize = true;
            this.rbLKKO.Location = new System.Drawing.Point(282, 134);
            this.rbLKKO.Name = "rbLKKO";
            this.rbLKKO.Size = new System.Drawing.Size(52, 17);
            this.rbLKKO.TabIndex = 4;
            this.rbLKKO.TabStop = true;
            this.rbLKKO.Text = "LKKT";
            this.rbLKKO.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Szamolj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbLKKO);
            this.Controls.Add(this.rbLNKO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLNKO;
        private System.Windows.Forms.RadioButton rbLKKO;
        private System.Windows.Forms.Button button1;
    }
}

