namespace POS
{
    partial class ViewProducts
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(components);
            bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(components);
            gunaBarDataset1 = new Guna.Charts.WinForms.GunaBarDataset();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            ProductsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            PCatTb = new ComboBox();
            label8 = new Label();
            QtyTb = new TextBox();
            label9 = new Label();
            PriceTb = new TextBox();
            label10 = new Label();
            PnameTb = new TextBox();
            label11 = new Label();
            EditProBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(579, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 55);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            label1.Click += label1_Click;
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
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 49);
            panel2.TabIndex = 3;
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
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            bunifuDragControl2.Fixed = true;
            bunifuDragControl2.Horizontal = true;
            bunifuDragControl2.TargetControl = null;
            bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            bunifuDragControl3.Fixed = true;
            bunifuDragControl3.Horizontal = true;
            bunifuDragControl3.TargetControl = null;
            bunifuDragControl3.Vertical = true;
            // 
            // gunaBarDataset1
            // 
            gunaBarDataset1.Label = "Bar1";
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // ProductsDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            ProductsDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            ProductsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProductsDGV.ColumnHeadersHeight = 30;
            ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ProductsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            ProductsDGV.GridColor = Color.Gray;
            ProductsDGV.Location = new Point(42, 146);
            ProductsDGV.Name = "ProductsDGV";
            ProductsDGV.ReadOnly = true;
            ProductsDGV.RowHeadersVisible = false;
            ProductsDGV.RowTemplate.Height = 26;
            ProductsDGV.Size = new Size(828, 612);
            ProductsDGV.TabIndex = 4;
            ProductsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProductsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProductsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProductsDGV.ThemeStyle.BackColor = Color.White;
            ProductsDGV.ThemeStyle.GridColor = Color.Gray;
            ProductsDGV.ThemeStyle.HeaderStyle.BackColor = Color.Green;
            ProductsDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            ProductsDGV.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductsDGV.ThemeStyle.HeaderStyle.Height = 30;
            ProductsDGV.ThemeStyle.ReadOnly = true;
            ProductsDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProductsDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            ProductsDGV.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(128, 255, 128);
            ProductsDGV.ThemeStyle.RowsStyle.Height = 26;
            ProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(128, 255, 128);
            ProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProductsDGV.CellContentClick += ProductsDGV_CellContentClick;
            // 
            // PCatTb
            // 
            PCatTb.Font = new Font("Segoe UI", 13F);
            PCatTb.FormattingEnabled = true;
            PCatTb.Items.AddRange(new object[] { "Food", "Beverage", "Clothes", "Electronics", "Appliance", "Furniture" });
            PCatTb.Location = new Point(1013, 275);
            PCatTb.Name = "PCatTb";
            PCatTb.Size = new Size(301, 31);
            PCatTb.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1013, 237);
            label8.Name = "label8";
            label8.Size = new Size(170, 24);
            label8.TabIndex = 33;
            label8.Text = "Product Category";
            // 
            // QtyTb
            // 
            QtyTb.Font = new Font("Segoe UI", 13F);
            QtyTb.Location = new Point(1009, 468);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(305, 31);
            QtyTb.TabIndex = 32;
            QtyTb.TextChanged += QtyTb_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1013, 431);
            label9.Name = "label9";
            label9.Size = new Size(165, 24);
            label9.TabIndex = 31;
            label9.Text = "Product Quantity";
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Segoe UI", 13F);
            PriceTb.Location = new Point(1013, 377);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(301, 31);
            PriceTb.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1012, 350);
            label10.Name = "label10";
            label10.Size = new Size(134, 24);
            label10.TabIndex = 29;
            label10.Text = "Product Price";
            // 
            // PnameTb
            // 
            PnameTb.Font = new Font("Segoe UI", 13F);
            PnameTb.Location = new Point(1012, 194);
            PnameTb.Name = "PnameTb";
            PnameTb.Size = new Size(305, 31);
            PnameTb.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1013, 157);
            label11.Name = "label11";
            label11.Size = new Size(140, 24);
            label11.TabIndex = 27;
            label11.Text = "Product Name";
            // 
            // EditProBtn
            // 
            EditProBtn.ActiveBorderThickness = 1;
            EditProBtn.ActiveCornerRadius = 20;
            EditProBtn.ActiveFillColor = Color.White;
            EditProBtn.ActiveForecolor = Color.Black;
            EditProBtn.ActiveLineColor = Color.SeaGreen;
            EditProBtn.BackColor = SystemColors.Control;
            EditProBtn.BackgroundImage = (Image)resources.GetObject("EditProBtn.BackgroundImage");
            EditProBtn.ButtonText = "Edit";
            EditProBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditProBtn.ForeColor = Color.SeaGreen;
            EditProBtn.IdleBorderThickness = 1;
            EditProBtn.IdleCornerRadius = 20;
            EditProBtn.IdleFillColor = Color.Green;
            EditProBtn.IdleForecolor = Color.White;
            EditProBtn.IdleLineColor = Color.Black;
            EditProBtn.Location = new Point(949, 577);
            EditProBtn.Margin = new Padding(7, 5, 7, 5);
            EditProBtn.Name = "EditProBtn";
            EditProBtn.Size = new Size(173, 65);
            EditProBtn.TabIndex = 36;
            EditProBtn.TextAlign = ContentAlignment.MiddleCenter;
            EditProBtn.Click += bunifuThinButton22_Click;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            bunifuThinButton21.BackColor = SystemColors.Control;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Remove";
            bunifuThinButton21.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.Black;
            bunifuThinButton21.IdleLineColor = Color.Black;
            bunifuThinButton21.Location = new Point(1224, 577);
            bunifuThinButton21.Margin = new Padding(7, 5, 7, 5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(164, 65);
            bunifuThinButton21.TabIndex = 35;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 192, 0);
            label12.Location = new Point(1153, 699);
            label12.Name = "label12";
            label12.Size = new Size(111, 31);
            label12.TabIndex = 37;
            label12.Text = "<- Back ";
            label12.Click += label12_Click;
            // 
            // ViewProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 877);
            Controls.Add(label12);
            Controls.Add(EditProBtn);
            Controls.Add(bunifuThinButton21);
            Controls.Add(PCatTb);
            Controls.Add(label8);
            Controls.Add(QtyTb);
            Controls.Add(label9);
            Controls.Add(PriceTb);
            Controls.Add(label10);
            Controls.Add(PnameTb);
            Controls.Add(label11);
            Controls.Add(ProductsDGV);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProducts";
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
            ((System.ComponentModel.ISupportInitialize)ProductsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Guna.Charts.WinForms.GunaBarDataset gunaBarDataset1;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsDGV;
        private ComboBox PCatTb;
        private Label label8;
        private TextBox QtyTb;
        private Label label9;
        private TextBox PriceTb;
        private Label label10;
        private TextBox PnameTb;
        private Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 EditProBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label label12;
    }
}