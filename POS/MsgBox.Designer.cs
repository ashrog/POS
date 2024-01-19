namespace POS
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            MessageLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(567, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 45);
            panel1.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(259, 31);
            label11.TabIndex = 3;
            label11.Text = "Point Of Sale System";
            // 
            // bunifuThinButton22
            // 
            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = Color.White;
            bunifuThinButton22.ActiveForecolor = Color.Black;
            bunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            bunifuThinButton22.BackColor = SystemColors.Control;
            bunifuThinButton22.BackgroundImage = (Image)resources.GetObject("bunifuThinButton22.BackgroundImage");
            bunifuThinButton22.ButtonText = "OK";
            bunifuThinButton22.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton22.ForeColor = Color.SeaGreen;
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = Color.Green;
            bunifuThinButton22.IdleForecolor = Color.White;
            bunifuThinButton22.IdleLineColor = Color.Black;
            bunifuThinButton22.Location = new Point(222, 253);
            bunifuThinButton22.Margin = new Padding(7, 5, 7, 5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new Size(145, 57);
            bunifuThinButton22.TabIndex = 21;
            bunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton22.Click += bunifuThinButton22_Click;
            // 
            // MessageLbl
            // 
            MessageLbl.AutoSize = true;
            MessageLbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessageLbl.Location = new Point(152, 150);
            MessageLbl.Name = "MessageLbl";
            MessageLbl.Size = new Size(165, 24);
            MessageLbl.TabIndex = 22;
            MessageLbl.Text = "Product Quantity";
            MessageLbl.Click += MessegeLbl_Click;
            // 
            // MsgBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 341);
            Controls.Add(MessageLbl);
            Controls.Add(bunifuThinButton22);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MsgBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MsgBox";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Label MessageLbl;
    }
}