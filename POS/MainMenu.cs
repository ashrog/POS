namespace POS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            AddCustomers Obj = new();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label2_Click_1(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            ViewProducts Obj = new();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewSuppliers Obj = new();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ViewCustomers Obj = new();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new();
            Obj.Show();
            this.Hide();
        }
    }
}
