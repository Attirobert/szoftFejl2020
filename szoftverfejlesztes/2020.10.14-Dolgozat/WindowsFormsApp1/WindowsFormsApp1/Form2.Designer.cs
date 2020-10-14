namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lbMatrix1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMatrix1
            // 
            this.lbMatrix1.FormattingEnabled = true;
            this.lbMatrix1.Location = new System.Drawing.Point(57, 40);
            this.lbMatrix1.Name = "lbMatrix1";
            this.lbMatrix1.Size = new System.Drawing.Size(207, 186);
            this.lbMatrix1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 269);
            this.Controls.Add(this.lbMatrix1);
            this.Name = "Form2";
            this.Text = "Matrix 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMatrix1;
    }
}