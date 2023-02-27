using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFinal
{
    public partial class User_1 : Form
    {
        public User_1()
        {
            InitializeComponent();
        }

        private void User_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string y = textBox2.Text;


            if ((string.Compare(a, "Meligi") == 0 && string.Compare(y, "20109305") == 0) || (string.Compare(a, "Salah") == 0 && string.Compare(y, "12345") == 0) || (string.Compare(a, "Ahmed Amr") == 0 && string.Compare(y, "123456") == 0) || (string.Compare(a, "Ahmed Ezz") == 0 && string.Compare(y, "1234567") == 0))
            {
                this.Hide();
                User2 x = new User2();
                x.Show();
            }
            else
            {
                MessageBox.Show("Please Check Username or Password", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
