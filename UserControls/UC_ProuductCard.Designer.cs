using System.Drawing;
using System.Windows.Forms;

namespace DataGridView_CS.UserControls
{
    partial class UC_ProuductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureItem = new PictureBox();
            labelNameItem = new Label();
            labelPriceItem = new Label();
            label3 = new Label();
            labelbarcodeItem = new Label();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            btn_forBuy = new ReaLTaiizor.Controls.CyberButton();
            labelStock = new Label();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            label_g = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureItem
            // 
            pictureItem.Location = new Point(4, 2);
            pictureItem.Name = "pictureItem";
            pictureItem.Size = new Size(143, 104);
            pictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureItem.TabIndex = 0;
            pictureItem.TabStop = false;
            // 
            // labelNameItem
            // 
            labelNameItem.AutoSize = true;
            labelNameItem.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameItem.Location = new Point(5, 110);
            labelNameItem.MaximumSize = new Size(120, 30);
            labelNameItem.MinimumSize = new Size(140, 30);
            labelNameItem.Name = "labelNameItem";
            labelNameItem.Size = new Size(140, 30);
            labelNameItem.TabIndex = 1;
            labelNameItem.Text = "NECAFE NECAFE";
            // 
            // labelPriceItem
            // 
            labelPriceItem.AutoSize = true;
            labelPriceItem.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPriceItem.ForeColor = Color.FromArgb(16, 107, 67);
            labelPriceItem.Location = new Point(5, 156);
            labelPriceItem.Name = "labelPriceItem";
            labelPriceItem.Size = new Size(34, 15);
            labelPriceItem.TabIndex = 1;
            labelPriceItem.Text = "$4.25";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(70, 84, 69);
            label3.Location = new Point(4, 188);
            label3.Name = "label3";
            label3.Size = new Size(42, 12);
            label3.TabIndex = 1;
            label3.Text = "Barcode:";
            // 
            // labelbarcodeItem
            // 
            labelbarcodeItem.AutoSize = true;
            labelbarcodeItem.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelbarcodeItem.ForeColor = Color.FromArgb(70, 84, 69);
            labelbarcodeItem.Location = new Point(41, 188);
            labelbarcodeItem.Name = "labelbarcodeItem";
            labelbarcodeItem.Size = new Size(70, 12);
            labelbarcodeItem.TabIndex = 1;
            labelbarcodeItem.Text = "8850127004397";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btn_forBuy);
            materialCard1.Controls.Add(labelStock);
            materialCard1.Controls.Add(cyberButton1);
            materialCard1.Controls.Add(labelbarcodeItem);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(label_g);
            materialCard1.Controls.Add(label3);
            materialCard1.Controls.Add(labelPriceItem);
            materialCard1.Controls.Add(labelNameItem);
            materialCard1.Controls.Add(pictureItem);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(5, 6);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(150, 212);
            materialCard1.TabIndex = 0;
            // 
            // btn_forBuy
            // 
            btn_forBuy.Alpha = 20;
            btn_forBuy.BackColor = Color.Transparent;
            btn_forBuy.Background = true;
            btn_forBuy.Background_WidthPen = 2F;
            btn_forBuy.BackgroundPen = true;
            btn_forBuy.ColorBackground = Color.White;
            btn_forBuy.ColorBackground_1 = Color.FromArgb(41, 63, 86);
            btn_forBuy.ColorBackground_2 = Color.Blue;
            btn_forBuy.ColorBackground_Pen = Color.SeaGreen;
            btn_forBuy.ColorLighting = Color.Blue;
            btn_forBuy.ColorPen_1 = Color.Blue;
            btn_forBuy.ColorPen_2 = Color.FromArgb(255, 128, 0);
            btn_forBuy.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn_forBuy.Effect_1 = true;
            btn_forBuy.Effect_1_ColorBackground = Color.Blue;
            btn_forBuy.Effect_1_Transparency = 20;
            btn_forBuy.Effect_2 = true;
            btn_forBuy.Effect_2_ColorBackground = Color.FromArgb(56, 56, 56);
            btn_forBuy.Effect_2_Transparency = 20;
            btn_forBuy.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_forBuy.ForeColor = Color.FromArgb(16, 107, 67);
            btn_forBuy.Lighting = false;
            btn_forBuy.LinearGradient_Background = false;
            btn_forBuy.LinearGradientPen = false;
            btn_forBuy.Location = new Point(114, 184);
            btn_forBuy.Name = "btn_forBuy";
            btn_forBuy.PenWidth = 15;
            btn_forBuy.Rounding = true;
            btn_forBuy.RoundingInt = 70;
            btn_forBuy.Size = new Size(30, 20);
            btn_forBuy.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_forBuy.TabIndex = 20;
            btn_forBuy.Tag = "Cyber";
            btn_forBuy.TextButton = "Buy";
            btn_forBuy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn_forBuy.Timer_Effect_1 = 1;
            btn_forBuy.Timer_RGB = 1;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.BackColor = Color.FromArgb(16, 107, 67);
            labelStock.FlatStyle = FlatStyle.Flat;
            labelStock.Font = new Font("Times New Roman", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(99, 157);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(37, 12);
            labelStock.TabIndex = 18;
            labelStock.Text = "In Stock";
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 1F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(16, 107, 67);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.SeaGreen;
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 20;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cyberButton1.ForeColor = Color.Black;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(89, 155);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 20;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(55, 17);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 17;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 1;
            cyberButton1.Timer_RGB = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(16, 107, 67);
            label1.Location = new Point(41, 158);
            label1.Name = "label1";
            label1.Size = new Size(22, 12);
            label1.TabIndex = 1;
            label1.Text = "each";
            // 
            // label_g
            // 
            label_g.AutoSize = true;
            label_g.Font = new Font("Times New Roman", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_g.ForeColor = Color.FromArgb(70, 84, 69);
            label_g.Location = new Point(5, 134);
            label_g.Name = "label_g";
            label_g.Size = new Size(25, 12);
            label_g.TabIndex = 1;
            label_g.Text = "200g";
            // 
            // UC_ProuductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "UC_ProuductCard";
            Size = new Size(162, 224);
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private PictureBox pictureItem;
        private Label labelNameItem;
        private Label labelPriceItem;
        private Label label3;
        private Label labelbarcodeItem;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label label_g;
        private Label label1;
        private Label labelStock;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton btn_forBuy;
    }
}
