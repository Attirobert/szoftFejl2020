namespace WindowsFormsApp1
{
    partial class Hello
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
            this.btnBalraFel = new System.Windows.Forms.Button();
            this.btnJobbraFel = new System.Windows.Forms.Button();
            this.btnBalLe = new System.Windows.Forms.Button();
            this.btnJobbraLe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJobbraLe);
            this.panel1.Controls.Add(this.btnJobbraFel);
            this.panel1.Controls.Add(this.btnBalLe);
            this.panel1.Controls.Add(this.btnBalraFel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnBalraFel
            // 
            this.btnBalraFel.Location = new System.Drawing.Point(120, 97);
            this.btnBalraFel.Name = "btnBalraFel";
            this.btnBalraFel.Size = new System.Drawing.Size(75, 23);
            this.btnBalraFel.TabIndex = 0;
            this.btnBalraFel.Text = "balra fel";
            this.btnBalraFel.UseVisualStyleBackColor = true;
            this.btnBalraFel.Click += new System.EventHandler(this.btnBalraFel_Click);
            // 
            // btnJobbraFel
            // 
            this.btnJobbraFel.Location = new System.Drawing.Point(557, 97);
            this.btnJobbraFel.Name = "btnJobbraFel";
            this.btnJobbraFel.Size = new System.Drawing.Size(75, 23);
            this.btnJobbraFel.TabIndex = 0;
            this.btnJobbraFel.Text = "jobbra fel";
            this.btnJobbraFel.UseVisualStyleBackColor = true;
            this.btnJobbraFel.Click += new System.EventHandler(this.btnJobbraFel_Click);
            // 
            // btnBalLe
            // 
            this.btnBalLe.Location = new System.Drawing.Point(120, 254);
            this.btnBalLe.Name = "btnBalLe";
            this.btnBalLe.Size = new System.Drawing.Size(75, 23);
            this.btnBalLe.TabIndex = 0;
            this.btnBalLe.Text = "Bal le";
            this.btnBalLe.UseVisualStyleBackColor = true;
            this.btnBalLe.Click += new System.EventHandler(this.btnBalLe_Click);
            // 
            // btnJobbraLe
            // 
            this.btnJobbraLe.Location = new System.Drawing.Point(557, 254);
            this.btnJobbraLe.Name = "btnJobbraLe";
            this.btnJobbraLe.Size = new System.Drawing.Size(75, 23);
            this.btnJobbraLe.TabIndex = 0;
            this.btnJobbraLe.Text = "jobbra le";
            this.btnJobbraLe.UseVisualStyleBackColor = true;
            this.btnJobbraLe.Click += new System.EventHandler(this.btnJobbraLe_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBalraFel;
        private System.Windows.Forms.Button btnJobbraLe;
        private System.Windows.Forms.Button btnJobbraFel;
        private System.Windows.Forms.Button btnBalLe;
    }
}

