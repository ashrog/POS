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

namespace POS
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
            DisplayProducts();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewProducts Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddProducts Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddSuppliers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AddCustomers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        // for the remove button, after clicking the product to be deleted.
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MsgBox.Show("Select at least one(1) Product");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where PId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);


                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Product deleted from store");
                    Con.Close();
                    DisplayProducts();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PnameTb.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PCatTb.SelectedItem = ProductsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = ProductsDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (PnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            PnameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            PCatTb.SelectedIndex = -1;
            Key = 0;
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (PnameTb.Text == "" || PCatTb.SelectedIndex == -1 || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MsgBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ProductTbl set PName=@PN, PCat=@PC, PPrice=@PP, PQty=@PQ where PId=@Pkey", Con);
                    cmd.Parameters.AddWithValue("@PN", PnameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PCatTb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QtyTb.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Product has been Updated Successfully!");
                    Con.Close();
                    DisplayProducts();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
