namespace POS
{
    partial class ViewSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSuppliers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            EditSupBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            RmvBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            panel2 = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            SAddressTb = new TextBox();
            label8 = new Label();
            SRemarksTb = new TextBox();
            label9 = new Label();
            SPhoneTb = new TextBox();
            label10 = new Label();
            SNameTb = new TextBox();
            label11 = new Label();
            SuppliersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuppliersDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(580, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 55);
            panel1.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 12);
            label1.Name = "label1";
            label1.Size = new Size(193, 24);
            label1.TabIndex = 1;
            label1.Text = "Point of Sale System";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(847, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 36);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 192, 0);
            label12.Location = new Point(1143, 792);
            label12.Name = "label12";
            label12.Size = new Size(111, 31);
            label12.TabIndex = 43;
            label12.Text = "<- Back ";
            label12.Click += label12_Click;
            // 
            // EditSupBtn
            // 
            EditSupBtn.ActiveBorderThickness = 1;
            EditSupBtn.ActiveCornerRadius = 20;
            EditSupBtn.ActiveFillColor = Color.White;
            EditSupBtn.ActiveForecolor = Color.Black;
            EditSupBtn.ActiveLineColor = Color.SeaGreen;
            EditSupBtn.BackColor = Color.Gainsboro;
            EditSupBtn.BackgroundImage = (Image)resources.GetObject("EditSupBtn.BackgroundImage");
            EditSupBtn.ButtonText = "Edit";
            EditSupBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditSupBtn.ForeColor = Color.SeaGreen;
            EditSupBtn.IdleBorderThickness = 1;
            EditSupBtn.IdleCornerRadius = 20;
            EditSupBtn.IdleFillColor = Color.Green;
            EditSupBtn.IdleForecolor = Color.White;
            EditSupBtn.IdleLineColor = Color.Black;
            EditSupBtn.Location = new Point(950, 712);
            EditSupBtn.Margin = new Padding(7, 5, 7, 5);
            EditSupBtn.Name = "EditSupBtn";
            EditSupBtn.Size = new Size(173, 65);
            EditSupBtn.TabIndex = 42;
            EditSupBtn.TextAlign = ContentAlignment.MiddleCenter;
            EditSupBtn.Click += EditSupBtn_Click;
            // 
            // RmvBtn
            // 
            RmvBtn.ActiveBorderThickness = 1;
            RmvBtn.ActiveCornerRadius = 20;
            RmvBtn.ActiveFillColor = Color.SeaGreen;
            RmvBtn.ActiveForecolor = Color.White;
            RmvBtn.ActiveLineColor = Color.SeaGreen;
            RmvBtn.BackColor = Color.Gainsboro;
            RmvBtn.BackgroundImage = (Image)resources.GetObject("RmvBtn.BackgroundImage");
            RmvBtn.ButtonText = "Remove";
            RmvBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RmvBtn.ForeColor = Color.SeaGreen;
            RmvBtn.IdleBorderThickness = 1;
            RmvBtn.IdleCornerRadius = 20;
            RmvBtn.IdleFillColor = Color.White;
            RmvBtn.IdleForecolor = Color.Black;
            RmvBtn.IdleLineColor = Color.Black;
            RmvBtn.Location = new Point(1272, 721);
            RmvBtn.Margin = new Padding(7, 5, 7, 5);
            RmvBtn.Name = "RmvBtn";
            RmvBtn.Size = new Size(164, 65);
            RmvBtn.TabIndex = 41;
            RmvBtn.TextAlign = ContentAlignment.MiddleCenter;
            RmvBtn.Click += bunifuThinButton21_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(1, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 49);
            panel2.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1285, 15);
            label7.Name = "label7";
            label7.Size = new Size(126, 24);
            label7.TabIndex = 12;
            label7.Text = "View-History";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(1236, 10);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 36);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1056, 15);
            label6.Name = "label6";
            label6.Size = new Size(97, 24);
            label6.TabIndex = 10;
            label6.Text = "Customer";
            label6.Click += label6_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(1007, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 36);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(783, 15);
            label5.Name = "label5";
            label5.Size = new Size(134, 24);
            label5.TabIndex = 8;
            label5.Text = "View-Supplier";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(734, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 36);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(289, 15);
            label4.Name = "label4";
            label4.Size = new Size(141, 24);
            label4.TabIndex = 6;
            label4.Text = "View-Products";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(240, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 36);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(533, 15);
            label3.Name = "label3";
            label3.Size = new Size(125, 24);
            label3.TabIndex = 4;
            label3.Text = "Add Supplier";
            label3.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(484, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 36);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 15);
            label2.Name = "label2";
            label2.Size = new Size(132, 24);
            label2.TabIndex = 2;
            label2.Text = "Add Products";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(3, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 36);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // SAddressTb
            // 
            SAddressTb.Location = new Point(1066, 261);
            SAddressTb.Multiline = true;
            SAddressTb.Name = "SAddressTb";
            SAddressTb.Size = new Size(305, 111);
            SAddressTb.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1072, 222);
            label8.Name = "label8";
            label8.Size = new Size(158, 24);
            label8.TabIndex = 50;
            label8.Text = "Supplier Address";
            // 
            // SRemarksTb
            // 
            SRemarksTb.Location = new Point(1060, 522);
            SRemarksTb.Multiline = true;
            SRemarksTb.Name = "SRemarksTb";
            SRemarksTb.Size = new Size(305, 142);
            SRemarksTb.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1069, 483);
            label9.Name = "label9";
            label9.Size = new Size(90, 24);
            label9.TabIndex = 48;
            label9.Text = "Remarks";
            // 
            // SPhoneTb
            // 
            SPhoneTb.Font = new Font("Segoe UI", 13F);
            SPhoneTb.Location = new Point(1063, 440);
            SPhoneTb.Name = "SPhoneTb";
            SPhoneTb.Size = new Size(305, 31);
            SPhoneTb.TabIndex = 47;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1072, 404);
            label10.Name = "label10";
            label10.Size = new Size(145, 24);
            label10.TabIndex = 46;
            label10.Text = "Supplier Phone";
            // 
            // SNameTb
            // 
            SNameTb.Font = new Font("Segoe UI", 13F);
            SNameTb.Location = new Point(1069, 182);
            SNameTb.Name = "SNameTb";
            SNameTb.Size = new Size(305, 31);
            SNameTb.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1072, 144);
            label11.Name = "label11";
            label11.Size = new Size(141, 24);
            label11.TabIndex = 44;
            label11.Text = "Supplier Name";
            // 
            // SuppliersDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SuppliersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SuppliersDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            SuppliersDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SuppliersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SuppliersDGV.ColumnHeadersHeight = 30;
            SuppliersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SuppliersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            SuppliersDGV.GridColor = Color.Gray;
            SuppliersDGV.Location = new Point(32, 165);
            SuppliersDGV.Name = "SuppliersDGV";
            SuppliersDGV.ReadOnly = true;
            SuppliersDGV.RowHeadersVisible = false;
            SuppliersDGV.RowTemplate.Height = 26;
            SuppliersDGV.Size = new Size(828, 644);
            SuppliersDGV.TabIndex = 52;
            SuppliersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SuppliersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            SuppliersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SuppliersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SuppliersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SuppliersDGV.ThemeStyle.BackColor = Color.White;
            SuppliersDGV.ThemeStyle.GridColor = Color.Gray;
            SuppliersDGV.ThemeStyle.HeaderStyle.BackColor = Color.Green;
            SuppliersDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            SuppliersDGV.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuppliersDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SuppliersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SuppliersDGV.ThemeStyle.HeaderStyle.Height = 30;
            SuppliersDGV.ThemeStyle.ReadOnly = true;
            SuppliersDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            SuppliersDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            SuppliersDGV.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuppliersDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(128, 255, 128);
            SuppliersDGV.ThemeStyle.RowsStyle.Height = 26;
            SuppliersDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(128, 255, 128);
            SuppliersDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SuppliersDGV.CellContentClick += SuppliersDGV_CellContentClick;
            // 
            // ViewSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1470, 874);
            Controls.Add(SuppliersDGV);
            Controls.Add(SAddressTb);
            Controls.Add(label8);
            Controls.Add(SRemarksTb);
            Controls.Add(label9);
            Controls.Add(SPhoneTb);
            Controls.Add(label10);
            Controls.Add(SNameTb);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(EditSupBtn);
            Controls.Add(RmvBtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewSuppliers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewSuppliers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuppliersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 EditSupBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 RmvBtn;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox7;
        private Label label6;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox SAddressTb;
        private Label label8;
        private TextBox SRemarksTb;
        private Label label9;
        private TextBox SPhoneTb;
        private Label label10;
        private TextBox SNameTb;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView SuppliersDGV;
    }
}