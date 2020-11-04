namespace Matrix
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páratlanElemekÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.páratlanElemekÖsszegeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.főátlókÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oszlopokbanLévőElemekÖsszegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transzponáldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(134, 94);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.páratlanElemekÖsszegeToolStripMenuItem,
            this.transzponáldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "Generál";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // páratlanElemekÖsszegeToolStripMenuItem
            // 
            this.páratlanElemekÖsszegeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.páratlanElemekÖsszegeToolStripMenuItem1,
            this.főátlókÖsszegeToolStripMenuItem,
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem,
            this.oszlopokbanLévőElemekÖsszegeToolStripMenuItem});
            this.páratlanElemekÖsszegeToolStripMenuItem.Name = "páratlanElemekÖsszegeToolStripMenuItem";
            this.páratlanElemekÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.páratlanElemekÖsszegeToolStripMenuItem.Text = "Műveletek";
            // 
            // páratlanElemekÖsszegeToolStripMenuItem1
            // 
            this.páratlanElemekÖsszegeToolStripMenuItem1.Name = "páratlanElemekÖsszegeToolStripMenuItem1";
            this.páratlanElemekÖsszegeToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.páratlanElemekÖsszegeToolStripMenuItem1.Text = "Páratlan elemek összege";
            this.páratlanElemekÖsszegeToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // főátlókÖsszegeToolStripMenuItem
            // 
            this.főátlókÖsszegeToolStripMenuItem.Name = "főátlókÖsszegeToolStripMenuItem";
            this.főátlókÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.főátlókÖsszegeToolStripMenuItem.Text = "Főátlók összege";
            this.főátlókÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // sorokbanLévőElemekÖsszegeToolStripMenuItem
            // 
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Name = "sorokbanLévőElemekÖsszegeToolStripMenuItem";
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Text = "Sorokban lévő elemek összege";
            this.sorokbanLévőElemekÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // oszlopokbanLévőElemekÖsszegeToolStripMenuItem
            // 
            this.oszlopokbanLévőElemekÖsszegeToolStripMenuItem.Name = "oszlopokbanLévőElemekÖsszegeToolStripMenuItem";
            this.oszlopokbanLévőElemekÖsszegeToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.oszlopokbanLévőElemekÖsszegeToolStripMenuItem.Text = "Oszlopokban lévő elemek összege";
            this.oszlopokbanLévőElemekÖsszegeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // transzponáldToolStripMenuItem
            // 
            this.transzponáldToolStripMenuItem.Name = "transzponáldToolStripMenuItem";
            this.transzponáldToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.transzponáldToolStripMenuItem.Text = "Transzponáld";
            this.transzponáldToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páratlanElemekÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem páratlanElemekÖsszegeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem főátlókÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorokbanLévőElemekÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oszlopokbanLévőElemekÖsszegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transzponáldToolStripMenuItem;
    }
}

