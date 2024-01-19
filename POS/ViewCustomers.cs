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
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
            DisplayCust();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddProducts Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewProducts Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddSuppliers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewSuppliers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AddCustomers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ViewCustomers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\abel yohannes\Documents\POSdb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayCust()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void Reset()
        {
            CNameTb.Text = "";
            CAddressTb.Text = "";
            CPhoneTb.Text = "";
            Key = 0;
        }
        private void RmvBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MsgBox.Show("Select at least one(1) Customer's data.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);


                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Customer deleted from store");
                    Con.Close();
                    DisplayCust();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            CAddressTb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            CPhoneTb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();


            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAddressTb.Text == "" ||  CPhoneTb.Text == "" || Key == 0)
            {
                MsgBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomerTbl set CustName=@CN, CustAd=@CA, CustPhone=@CP where CustId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddressTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhoneTb.Text);
                    
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Customer data Updated!");
                    Con.Close();
                    DisplayCust();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
