using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
            MessageLbl.Text = Message;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string Message;
        public static void Show(String msg)
        {
            Message = msg;
            MsgBox Obj = new MsgBox();
            Obj.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessegeLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
