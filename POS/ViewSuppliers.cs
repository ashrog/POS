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
    public partial class ViewSuppliers : Form
    {
        public ViewSuppliers()
        {
            InitializeComponent();
            DisplaySup();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\abel yohannes\Documents\POSdb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplaySup()
        {
            Con.Open();
            string Query = "Select * from SupplierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SuppliersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            SNameTb.Text = "";
            SAddressTb.Text = "";
            SAddressTb.Text = "";
            SRemarksTb.Text = "";
            Key = 0;
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MsgBox.Show("Select at least one(1) Supplier's data.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from SupplierTbl where SupId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SKey", Key);


                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Supplier deleted from store");
                    Con.Close();
                    DisplaySup();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditSupBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || SAddressTb.Text == "" || SAddressTb.Text == "" || SRemarksTb.Text == "")
            {
                MsgBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update SupplierTbl set SupName=@SN, SupAddress=@SA, SupPhone=@SP, SupRem=@SR where SupId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SN", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SA", SAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SAddressTb.Text);
                    cmd.Parameters.AddWithValue("@SR", SRemarksTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);

                    cmd.ExecuteNonQuery();
                    MsgBox.Show("Supplier data Updated!");
                    Con.Close();
                    DisplaySup();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void SuppliersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = SuppliersDGV.SelectedRows[0].Cells[1].Value.ToString();
            SAddressTb.Text = SuppliersDGV.SelectedRows[0].Cells[2].Value.ToString();
            SPhoneTb.Text = SuppliersDGV.SelectedRows[0].Cells[3].Value.ToString();
            SRemarksTb.Text = SuppliersDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SuppliersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
