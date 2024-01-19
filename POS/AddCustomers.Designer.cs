namespace POS
{
    partial class AddCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomers));
            panel1 = new Panel();
            label11 = new Label();
            AddCustBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            CAddressTb = new TextBox();
            label4 = new Label();
            CPhoneTb = new TextBox();
            label2 = new Label();
            CNameTb = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 62);
            panel1.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 17);
            label11.Name = "label11";
            label11.Size = new Size(185, 31);
            label11.TabIndex = 3;
            label11.Text = "Add Customer";
            // 
            // AddCustBtn
            // 
            AddCustBtn.ActiveBorderThickness = 1;
            AddCustBtn.ActiveCornerRadius = 20;
            AddCustBtn.ActiveFillColor = Color.White;
            AddCustBtn.ActiveForecolor = Color.Black;
            AddCustBtn.ActiveLineColor = Color.SeaGreen;
            AddCustBtn.BackColor = Color.Gainsboro;
            AddCustBtn.BackgroundImage = (Image)resources.GetObject("AddCustBtn.BackgroundImage");
            AddCustBtn.ButtonText = "Add";
            AddCustBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCustBtn.ForeColor = Color.SeaGreen;
            AddCustBtn.IdleBorderThickness = 1;
            AddCustBtn.IdleCornerRadius = 20;
            AddCustBtn.IdleFillColor = Color.Green;
            AddCustBtn.IdleForecolor = Color.White;
            AddCustBtn.IdleLineColor = Color.Black;
            AddCustBtn.Location = new Point(51, 569);
            AddCustBtn.Margin = new Padding(7, 5, 7, 5);
            AddCustBtn.Name = "AddCustBtn";
            AddCustBtn.Size = new Size(206, 65);
            AddCustBtn.TabIndex = 23;
            AddCustBtn.TextAlign = ContentAlignment.MiddleCenter;
            AddCustBtn.Click += bunifuThinButton22_Click;
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
            ResetBtn.Location = new Point(367, 569);
            ResetBtn.Margin = new Padding(7, 5, 7, 5);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(206, 65);
            ResetBtn.TabIndex = 22;
            ResetBtn.TextAlign = ContentAlignment.MiddleCenter;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // CAddressTb
            // 
            CAddressTb.Location = new Point(196, 261);
            CAddressTb.Multiline = true;
            CAddressTb.Name = "CAddressTb";
            CAddressTb.Size = new Size(289, 111);
            CAddressTb.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 222);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 20;
            label4.Text = "Address";
            // 
            // CPhoneTb
            // 
            CPhoneTb.Font = new Font("Segoe UI", 13F);
            CPhoneTb.Location = new Point(193, 447);
            CPhoneTb.Name = "CPhoneTb";
            CPhoneTb.Size = new Size(289, 31);
            CPhoneTb.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(202, 411);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 18;
            label2.Text = "Phone";
            // 
            // CNameTb
            // 
            CNameTb.Font = new Font("Segoe UI", 13F);
            CNameTb.Location = new Point(196, 163);
            CNameTb.Name = "CNameTb";
            CNameTb.Size = new Size(289, 31);
            CNameTb.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 125);
            label1.Name = "label1";
            label1.Size = new Size(155, 24);
            label1.TabIndex = 16;
            label1.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(646, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 36);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(691, 790);
            Controls.Add(panel1);
            Controls.Add(AddCustBtn);
            Controls.Add(ResetBtn);
            Controls.Add(CAddressTb);
            Controls.Add(label4);
            Controls.Add(CPhoneTb);
            Controls.Add(label2);
            Controls.Add(CNameTb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 AddCustBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private TextBox CAddressTb;
        private Label label4;
        private TextBox CPhoneTb;
        private Label label2;
        private TextBox CNameTb;
        private Label label1;
        private PictureBox pictureBox1;
    }
}