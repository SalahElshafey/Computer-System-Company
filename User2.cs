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
    public partial class User2 : Form
    {
        public User2()
        {
            InitializeComponent();
        }

        private void User2_Load(object sender, EventArgs e)
        {

        }

        private void kingstonbtn_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nvidiabtn_Click(object sender, EventArgs e)
        {

        }

        private void AMDbtn_Click(object sender, EventArgs e)
        {

        }

        private void intelbtn_Click(object sender, EventArgs e)
        {

        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_1 x = new User_1();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                int index = listBox1.FindString(textBox1.Text);

                if (index != -1)
                    listBox1.SetSelected(index, true);
                else
                    MessageBox.Show("The search string did not match any items in the ListBox");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
