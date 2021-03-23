namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lbMatrix2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMatrix2
            // 
            this.lbMatrix2.FormattingEnabled = true;
            this.lbMatrix2.Location = new System.Drawing.Point(25, 31);
            this.lbMatrix2.Name = "lbMatrix2";
            this.lbMatrix2.Size = new System.Drawing.Size(206, 173);
            this.lbMatrix2.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 239);
            this.Controls.Add(this.lbMatrix2);
            this.Name = "Form3";
            this.Text = "Matrix 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMatrix2;
    }
}