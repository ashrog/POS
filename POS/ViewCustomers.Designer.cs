namespace POS
{
    partial class ViewCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
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
            CAddressTb = new TextBox();
            label8 = new Label();
            CPhoneTb = new TextBox();
            label9 = new Label();
            CNameTb = new TextBox();
            label10 = new Label();
            CustomersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(570, 2);
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
            pictureBox1.Location = new Point(838, 0);
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
            label12.Location = new Point(1143, 736);
            label12.Name = "label12";
            label12.Size = new Size(111, 31);
            label12.TabIndex = 43;
            label12.Text = "<- Back ";
            label12.Click += label12_Click;
            // 
            // EditBtn
            // 
            EditBtn.ActiveBorderThickness = 1;
            EditBtn.ActiveCornerRadius = 20;
            EditBtn.ActiveFillColor = Color.White;
            EditBtn.ActiveForecolor = Color.Black;
            EditBtn.ActiveLineColor = Color.SeaGreen;
            EditBtn.BackColor = SystemColors.Control;
            EditBtn.BackgroundImage = (Image)resources.GetObject("EditBtn.BackgroundImage");
            EditBtn.ButtonText = "Edit";
            EditBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.SeaGreen;
            EditBtn.IdleBorderThickness = 1;
            EditBtn.IdleCornerRadius = 20;
            EditBtn.IdleFillColor = Color.Green;
            EditBtn.IdleForecolor = Color.White;
            EditBtn.IdleLineColor = Color.Black;
            EditBtn.Location = new Point(963, 637);
            EditBtn.Margin = new Padding(7, 5, 7, 5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(173, 65);
            EditBtn.TabIndex = 42;
            EditBtn.TextAlign = ContentAlignment.MiddleCenter;
            EditBtn.Click += EditBtn_Click;
            // 
            // RmvBtn
            // 
            RmvBtn.ActiveBorderThickness = 1;
            RmvBtn.ActiveCornerRadius = 20;
            RmvBtn.ActiveFillColor = Color.SeaGreen;
            RmvBtn.ActiveForecolor = Color.White;
            RmvBtn.ActiveLineColor = Color.SeaGreen;
            RmvBtn.BackColor = SystemColors.Control;
            RmvBtn.BackgroundImage = (Image)resources.GetObject("RmvBtn.BackgroundImage");
            RmvBtn.ButtonText = "Remove";
            RmvBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RmvBtn.ForeColor = Color.SeaGreen;
            RmvBtn.IdleBorderThickness = 1;
            RmvBtn.IdleCornerRadius = 20;
            RmvBtn.IdleFillColor = Color.White;
            RmvBtn.IdleForecolor = Color.Black;
            RmvBtn.IdleLineColor = Color.Black;
            RmvBtn.Location = new Point(1238, 637);
            RmvBtn.Margin = new Padding(7, 5, 7, 5);
            RmvBtn.Name = "RmvBtn";
            RmvBtn.Size = new Size(164, 65);
            RmvBtn.TabIndex = 41;
            RmvBtn.TextAlign = ContentAlignment.MiddleCenter;
            RmvBtn.Click += RmvBtn_Click;
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
            panel2.Location = new Point(-9, 63);
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
            label7.Click += label7_Click;
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
            // CAddressTb
            // 
            CAddressTb.Location = new Point(1044, 303);
            CAddressTb.Multiline = true;
            CAddressTb.Name = "CAddressTb";
            CAddressTb.Size = new Size(289, 111);
            CAddressTb.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1050, 264);
            label8.Name = "label8";
            label8.Size = new Size(81, 24);
            label8.TabIndex = 48;
            label8.Text = "Address";
            // 
            // CPhoneTb
            // 
            CPhoneTb.Font = new Font("Segoe UI", 13F);
            CPhoneTb.Location = new Point(1041, 489);
            CPhoneTb.Name = "CPhoneTb";
            CPhoneTb.Size = new Size(289, 31);
            CPhoneTb.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1050, 453);
            label9.Name = "label9";
            label9.Size = new Size(67, 24);
            label9.TabIndex = 46;
            label9.Text = "Phone";
            // 
            // CNameTb
            // 
            CNameTb.Font = new Font("Segoe UI", 13F);
            CNameTb.Location = new Point(1044, 205);
            CNameTb.Name = "CNameTb";
            CNameTb.Size = new Size(289, 31);
            CNameTb.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1047, 167);
            label10.Name = "label10";
            label10.Size = new Size(155, 24);
            label10.TabIndex = 44;
            label10.Text = "Customer Name";
            // 
            // CustomersDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            CustomersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomersDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            CustomersDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersDGV.ColumnHeadersHeight = 30;
            CustomersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomersDGV.GridColor = Color.Gray;
            CustomersDGV.Location = new Point(32, 149);
            CustomersDGV.Name = "CustomersDGV";
            CustomersDGV.ReadOnly = true;
            CustomersDGV.RowHeadersVisible = false;
            CustomersDGV.RowTemplate.Height = 26;
            CustomersDGV.Size = new Size(828, 644);
            CustomersDGV.TabIndex = 53;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomersDGV.ThemeStyle.BackColor = Color.White;
            CustomersDGV.ThemeStyle.GridColor = Color.Gray;
            CustomersDGV.ThemeStyle.HeaderStyle.BackColor = Color.Green;
            CustomersDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            CustomersDGV.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomersDGV.ThemeStyle.HeaderStyle.Height = 30;
            CustomersDGV.ThemeStyle.ReadOnly = true;
            CustomersDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomersDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            CustomersDGV.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(128, 255, 128);
            CustomersDGV.ThemeStyle.RowsStyle.Height = 26;
            CustomersDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(128, 255, 128);
            CustomersDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CustomersDGV.CellContentClick += CustomersDGV_CellContentClick;
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 840);
            Controls.Add(CustomersDGV);
            Controls.Add(CAddressTb);
            Controls.Add(label8);
            Controls.Add(CPhoneTb);
            Controls.Add(label9);
            Controls.Add(CNameTb);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(EditBtn);
            Controls.Add(RmvBtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewCustomers";
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
            ((System.ComponentModel.ISupportInitialize)CustomersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
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
        private TextBox CAddressTb;
        private Label label8;
        private TextBox CPhoneTb;
        private Label label9;
        private TextBox CNameTb;
        private Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersDGV;
    }
}