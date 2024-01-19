namespace POS
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            panel1 = new Panel();
            label11 = new Label();
            AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label4 = new Label();
            QtyTb = new TextBox();
            label3 = new Label();
            PriceTb = new TextBox();
            label2 = new Label();
            PnameTb = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PCatTb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 62);
            panel1.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 17);
            label11.Name = "label11";
            label11.Size = new Size(175, 31);
            label11.TabIndex = 3;
            label11.Text = "Add Products";
            // 
            // AddBtn
            // 
            AddBtn.ActiveBorderThickness = 1;
            AddBtn.ActiveCornerRadius = 20;
            AddBtn.ActiveFillColor = Color.White;
            AddBtn.ActiveForecolor = Color.Black;
            AddBtn.ActiveLineColor = Color.SeaGreen;
            AddBtn.BackColor = Color.Gainsboro;
            AddBtn.BackgroundImage = (Image)resources.GetObject("AddBtn.BackgroundImage");
            AddBtn.ButtonText = "Add";
            AddBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.SeaGreen;
            AddBtn.IdleBorderThickness = 1;
            AddBtn.IdleCornerRadius = 20;
            AddBtn.IdleFillColor = Color.Green;
            AddBtn.IdleForecolor = Color.White;
            AddBtn.IdleLineColor = Color.Black;
            AddBtn.Location = new Point(61, 560);
            AddBtn.Margin = new Padding(7, 5, 7, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(199, 65);
            AddBtn.TabIndex = 25;
            AddBtn.TextAlign = ContentAlignment.MiddleCenter;
            AddBtn.Click += AddBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.ActiveBorderThickness = 1;
            ResetBtn.ActiveCornerRadius = 20;
            ResetBtn.ActiveFillColor = Color.SeaGreen;
            ResetBtn.ActiveForecolor = Color.White;
            ResetBtn.ActiveLineColor = Color.SeaGreen;
            ResetBtn.BackColor = Color.Gainsboro;
            ResetBtn.BackgroundImage = (Image)resources.GetObject("ResetBtn.BackgroundImage");
            ResetBtn.ButtonText = "Reset";
            ResetBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.SeaGreen;
            ResetBtn.IdleBorderThickness = 1;
            ResetBtn.IdleCornerRadius = 20;
            ResetBtn.IdleFillColor = Color.White;
            ResetBtn.IdleForecolor = Color.Black;
            ResetBtn.IdleLineColor = Color.Black;
            ResetBtn.Location = new Point(408, 560);
            ResetBtn.Margin = new Padding(7, 5, 7, 5);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(215, 65);
            ResetBtn.TabIndex = 24;
            ResetBtn.TextAlign = ContentAlignment.MiddleCenter;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 207);
            label4.Name = "label4";
            label4.Size = new Size(170, 24);
            label4.TabIndex = 22;
            label4.Text = "Product Category";
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Segoe UI", 13F);
            QtyTb.Location = new Point(180, 438);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(305, 31);
            QtyTb.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 401);
            label3.Name = "label3";
            label3.Size = new Size(165, 24);
            label3.TabIndex = 20;
            label3.Text = "Product Quantity";
            label3.Click += label3_Click;
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Segoe UI", 13F);
            PriceTb.Location = new Point(184, 347);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(301, 31);
            PriceTb.TabIndex = 19;
            PriceTb.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 320);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 18;
            label2.Text = "Product Price";
            // 
            // PnameTb
            // 
            PnameTb.Font = new Font("Segoe UI", 13F);
            PnameTb.Location = new Point(183, 164);
            PnameTb.Name = "PnameTb";
            PnameTb.Size = new Size(305, 31);
            PnameTb.TabIndex = 17;
            PnameTb.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 127);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 16;
            label1.Text = "Product Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(648, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 36);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PCatTb
            // 
            PCatTb.Font = new Font("Segoe UI", 13F);
            PCatTb.FormattingEnabled = true;
            PCatTb.Items.AddRange(new object[] { "Food", "Beverage", "Clothes", "Electronics", "Appliance", "Furniture" });
            PCatTb.Location = new Point(184, 245);
            PCatTb.Name = "PCatTb";
            PCatTb.Size = new Size(301, 31);
            PCatTb.TabIndex = 26;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(690, 725);
            Controls.Add(PCatTb);
            Controls.Add(panel1);
            Controls.Add(AddBtn);
            Controls.Add(ResetBtn);
            Controls.Add(label4);
            Controls.Add(QtyTb);
            Controls.Add(label3);
            Controls.Add(PriceTb);
            Controls.Add(label2);
            Controls.Add(PnameTb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProducts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Label label4;
        private TextBox QtyTb;
        private Label label3;
        private TextBox PriceTb;
        private Label label2;
        private TextBox PnameTb;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox PCatTb;
    }
}