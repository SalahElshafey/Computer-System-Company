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
    public partial class Employee_1 : Form
    {
        public Employee_1()
        {
            InitializeComponent();
        }

        private void Employee_1_Load(object sender, EventArgs e)
        {

        }

        private void passwordbtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void namebtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 x = new Form1();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            string a = TextId.Text;
            string b = TextPassword.Text;





            if (string.Compare(a, "Boss") == 0 && string.Compare(b, "123") == 0)
            {
                this.Hide();
                Employee_2 x = new Employee_2();
                x.Show();
            }
            else
            {
                MessageBox.Show("Please Check Username or Password", "Warning", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
