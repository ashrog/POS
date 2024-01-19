namespace POS
{
    partial class AddSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSuppliers));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            label1 = new Label();
            SNameTb = new TextBox();
            SPhoneTb = new TextBox();
            label2 = new Label();
            SRemarksTb = new TextBox();
            label3 = new Label();
            SAddressTb = new TextBox();
            label4 = new Label();
            ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            Add_SupBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(653, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 36);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 62);
            panel1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 17);
            label11.Name = "label11";
            label11.Size = new Size(181, 31);
            label11.TabIndex = 3;
            label11.Text = "Add Suppliers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 84);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 4;
            label1.Text = "Supplier Name";
            // 
            // SNameTb
            // 
            SNameTb.Font = new Font("Segoe UI", 13F);
            SNameTb.Location = new Point(224, 122);
            SNameTb.Name = "SNameTb";
            SNameTb.Size = new Size(305, 31);
            SNameTb.TabIndex = 5;
            // 
            // SPhoneTb
            // 
            SPhoneTb.Font = new Font("Segoe UI", 13F);
            SPhoneTb.Location = new Point(218, 380);
            SPhoneTb.Name = "SPhoneTb";
            SPhoneTb.Size = new Size(305, 31);
            SPhoneTb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 344);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 6;
            label2.Text = "Supplier Phone";
            // 
            // SRemarksTb
            // 
            SRemarksTb.Location = new Point(215, 462);
            SRemarksTb.Multiline = true;
            SRemarksTb.Name = "SRemarksTb";
            SRemarksTb.Size = new Size(305, 142);
            SRemarksTb.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 423);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 8;
            label3.Text = "Remarks";
            // 
            // SAddressTb
            // 
            SAddressTb.Location = new Point(221, 201);
            SAddressTb.Multiline = true;
            SAddressTb.Name = "SAddressTb";
            SAddressTb.Size = new Size(305, 111);
            SAddressTb.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(227, 162);
            label4.Name = "label4";
            label4.Size = new Size(158, 24);
            label4.TabIndex = 10;
            label4.Text = "Supplier Address";
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
            ResetBtn.Location = new Point(426, 642);
            ResetBtn.Margin = new Padding(7, 5, 7, 5);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(232, 65);
            ResetBtn.TabIndex = 12;
            ResetBtn.TextAlign = ContentAlignment.MiddleCenter;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Add_SupBtn
            // 
            Add_SupBtn.ActiveBorderThickness = 1;
            Add_SupBtn.ActiveCornerRadius = 20;
            Add_SupBtn.ActiveFillColor = Color.White;
            Add_SupBtn.ActiveForecolor = Color.Black;
            Add_SupBtn.ActiveLineColor = Color.SeaGreen;
            Add_SupBtn.BackColor = Color.Gainsboro;
            Add_SupBtn.BackgroundImage = (Image)resources.GetObject("Add_SupBtn.BackgroundImage");
            Add_SupBtn.ButtonText = "Add";
            Add_SupBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_SupBtn.ForeColor = Color.SeaGreen;
            Add_SupBtn.IdleBorderThickness = 1;
            Add_SupBtn.IdleCornerRadius = 20;
            Add_SupBtn.IdleFillColor = Color.Green;
            Add_SupBtn.IdleForecolor = Color.White;
            Add_SupBtn.IdleLineColor = Color.Black;
            Add_SupBtn.Location = new Point(60, 642);
            Add_SupBtn.Margin = new Padding(7, 5, 7, 5);
            Add_SupBtn.Name = "Add_SupBtn";
            Add_SupBtn.Size = new Size(214, 65);
            Add_SupBtn.TabIndex = 13;
            Add_SupBtn.TextAlign = ContentAlignment.MiddleCenter;
            Add_SupBtn.Click += bunifuThinButton22_Click_1;
            // 
            // AddSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(697, 792);
            Controls.Add(Add_SupBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SAddressTb);
            Controls.Add(label4);
            Controls.Add(SRemarksTb);
            Controls.Add(label3);
            Controls.Add(SPhoneTb);
            Controls.Add(label2);
            Controls.Add(SNameTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSuppliers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSuppliers";
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
        private Label label1;
        private TextBox SNameTb;
        private TextBox SPhoneTb;
        private Label label2;
        private TextBox SRemarksTb;
        private Label label3;
        private TextBox SAddressTb;
        private Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 Add_SupBtn;
    }
}