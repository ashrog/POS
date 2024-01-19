namespace POS
{
    partial class ViewBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBills));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            SellsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellsDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 51);
            panel1.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 17);
            label11.Name = "label11";
            label11.Size = new Size(215, 31);
            label11.TabIndex = 3;
            label11.Text = "View Bill History";
            label11.Click += label11_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(1062, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 36);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SellsDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SellsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SellsDGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            SellsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SellsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SellsDGV.ColumnHeadersHeight = 30;
            SellsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SellsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            SellsDGV.GridColor = Color.Gray;
            SellsDGV.Location = new Point(51, 83);
            SellsDGV.Name = "SellsDGV";
            SellsDGV.ReadOnly = true;
            SellsDGV.RowHeadersVisible = false;
            SellsDGV.RowTemplate.Height = 26;
            SellsDGV.Size = new Size(828, 612);
            SellsDGV.TabIndex = 29;
            SellsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SellsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            SellsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SellsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SellsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SellsDGV.ThemeStyle.BackColor = Color.White;
            SellsDGV.ThemeStyle.GridColor = Color.Gray;
            SellsDGV.ThemeStyle.HeaderStyle.BackColor = Color.Green;
            SellsDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            SellsDGV.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellsDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SellsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SellsDGV.ThemeStyle.HeaderStyle.Height = 30;
            SellsDGV.ThemeStyle.ReadOnly = true;
            SellsDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            SellsDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            SellsDGV.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellsDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(128, 255, 128);
            SellsDGV.ThemeStyle.RowsStyle.Height = 26;
            SellsDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(128, 255, 128);
            SellsDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ViewBills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 741);
            Controls.Add(SellsDGV);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBills";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellsDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView SellsDGV;
    }
}