namespace DataGridView_CS
{
    partial class Test
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
            this.panelListPrudctSell = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPager = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelListPrudctSell
            // 
            this.panelListPrudctSell.Location = new System.Drawing.Point(12, 109);
            this.panelListPrudctSell.Name = "panelListPrudctSell";
            this.panelListPrudctSell.Size = new System.Drawing.Size(913, 444);
            this.panelListPrudctSell.TabIndex = 0;
            // 
            // pnlPager
            // 
            this.pnlPager.Location = new System.Drawing.Point(537, 12);
            this.pnlPager.Name = "pnlPager";
            this.pnlPager.Size = new System.Drawing.Size(343, 26);
            this.pnlPager.TabIndex = 2;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 610);
            this.Controls.Add(this.pnlPager);
            this.Controls.Add(this.panelListPrudctSell);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelListPrudctSell;
        private System.Windows.Forms.Panel pnlPager;
    }
}