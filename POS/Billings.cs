using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.Charts.WinForms;

namespace POS
{
    public partial class Billings : Form
    {
        public Billings()
        {
            InitializeComponent();
            DisplayProducts();
            GetCustomer();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddProducts Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            /*ViewProducts Obj = new();
            Obj.Show();
            Obj.TopMost = true;*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /*AddSuppliers Obj = new();
            Obj.Show();
            Obj.TopMost = true;*/
        }

        private void label5_Click(object sender, EventArgs e)
        {
            /*ViewSuppliers Obj = new();
            Obj.Show();
            Obj.TopMost = true;*/
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AddCustomers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ViewBills Obj = new();
            Obj.Show();
            //Obj.TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\abel yohannes\Documents\POSdb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayProducts()
        {
            Con.Open();
            string Query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void GetCustName()
        {
            Con.Open();
            string Query = "select * from CustomerTbl where CustId =" + CustIdCb.SelectedValue.ToString() + " ";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CNameTb.Text = dr["CustName"].ToString();
                Con.Close();
            }
        }

        private void SearchProducts()
        {
            Con.Open();
            string Query = "Select * from ProductTbl where PName='" + SearchTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            SearchProducts();
            SearchTb.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            SearchTb.Text = "";
        }

        private void GetCustomer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(rdr);
            CustIdCb.ValueMember = "CustId";
            CustIdCb.DataSource = dt;
            Con.Close();
        }

        private void Reset()
        {
            Pname = "";
            QtyTb.Text = "";
            Key = 0;
        }

        private void UpdateQty()
        {
            int newQty = PStock - Convert.ToInt32(QtyTb.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set PQty=@PQ where PId=@Pkey", Con);

                cmd.Parameters.AddWithValue("@PQ", newQty);
                cmd.Parameters.AddWithValue("@PKey", Key);

                cmd.ExecuteNonQuery();
                
                Con.Close();
                DisplayProducts();
                
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int Key = 0;
        string Pname;
        int Pprice, PStock;
        int n = 1, total = 0;
        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pname = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();

            Pprice = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[3].Value.ToString());
            PStock = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[4].Value.ToString());

            if (Pname == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        private void AddBill_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MsgBox.Show("Select A Product");
            }
            else if (QtyTb.Text == "")
            {
                MsgBox.Show("Choose Quantity first");
            }
            else if (Convert.ToInt32(QtyTb.Text) > PStock)
            {
                MsgBox.Show("Out of Stock, Sorry.");
            }
            else
            {
                int Qty = Convert.ToInt32(QtyTb.Text);
                int Subtotal = Qty * Pprice;
                total = total + Subtotal;
                //Console.WriteLine(Qty);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = Pname;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = Pprice;
                newRow.Cells[4].Value = Subtotal;
                BillDGV.Rows.Add(newRow);
                n++;
                SubtotalTb.Text = "" + total;
                UpdateQty();
                Reset();
            }



        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billings_Load(object sender, EventArgs e)
        {

        }

        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustName();
        }

        private void VATTb_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void VATTb_KeyUp(object sender, KeyEventArgs e)
        {

            if (VATTb.Text == "")
            {
            }
            else if (SubtotalTb.Text == "")
            {
                MsgBox.Show("Add Products First");
                VATTb.Text = "";
            }
            else
            {
                try
                {
                    double VAT = (Convert.ToDouble(VATTb.Text) / 100) * Convert.ToInt32(SubtotalTb.Text);
                    TotTaxTb.Text = "" + (Math.Round(VAT, 2));
                    GrdTotalTb.Text = "" + (Convert.ToInt32(SubtotalTb.Text) + Convert.ToDouble(TotTaxTb.Text));
                }
                catch (Exception Ex)
                {
                    MsgBox.Show(Ex.Message);
                }
            }
        }

        private void DisTb_KeyUp(object sender, KeyEventArgs e)
        {

            if (DisTb.Text == "")
            {
            }
            else if (SubtotalTb.Text == "")
            {
                MsgBox.Show("Add Products First");
                DisTb.Text = "";
            }
            else
            {
                try
                {
                    double Discount = (Convert.ToDouble(DisTb.Text) / 100) * Convert.ToInt32(SubtotalTb.Text);
                    DisValTb.Text = "" + (Math.Round(Discount, 2));
                    GrdTotalTb.Text = "" + (Convert.ToInt32(SubtotalTb.Text) + Convert.ToDouble(TotTaxTb.Text) - Convert.ToDouble(DisValTb.Text));
                }
                catch (Exception Ex)
                {
                    MsgBox.Show(Ex.Message);
                }
            }
        }

        public void InsertBill()
        {
            if (CustIdCb.SelectedIndex == -1 || PytMtdCb.SelectedIndex == -1 || GrdTotalTb.Text == "")
            {
                MsgBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTbl(BDate, CustId, CustName, PMethod, Amt) values(@BD, @CI, @CN, @PM, @Am)", Con);
                    cmd.Parameters.AddWithValue("@BD", BDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CI", CustIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@PM", PytMtdCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Am", Convert.ToDouble(GrdTotalTb.Text));

                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Bill Saved Successfully");
                    Con.Close();
                    //Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            if (CustIdCb.SelectedIndex == -1 || PytMtdCb.SelectedIndex == -1 || GrdTotalTb.Text == "")
            {
            }
            else
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            InsertBill();
        }

        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Point of Sale System", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Green, new Point(80));
            e.Graphics.DrawString("-------------------------------", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26, 28));
            e.Graphics.DrawString("ID-PRODUCT-QTY-----PRICE---TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("|", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(34, pos));

                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("|", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(95, pos));

                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("|", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(156, pos));

                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("|", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(206, pos));

                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                e.Graphics.DrawString("|", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(271, pos));

                pos = pos + 20;

            }
            e.Graphics.DrawString("Grand Total : Etb " + GrdTotalTb.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("--------------POS---------------", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotalTb.Text = "";
            n = 0;
        }

        private void GrdTotalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            SearchTb.Text = "";
        }

        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Billings Obj = new();
            Obj.Show();
            //this.Hide();
            
            DisplayProducts();
            SearchTb.Text = "";
        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
