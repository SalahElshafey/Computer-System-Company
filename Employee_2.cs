using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectFinal
{
    public partial class Employee_2 : Form
    {
        public Employee_2()
        {
            InitializeComponent();
            Person e = new Employee();
            string s = e.Display();
            label1.Text = "user:" + s;
        }

        private void Employee_2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pricebtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Itemname.Text) && !string.IsNullOrEmpty(itemprice.Text))
            {
                string x = "";
                x += Itemname.Text + " " + itemprice.Text;
                listBox1.Items.Add(x);
                Itemname.Clear();
                itemprice.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter All Required Data", "Warning", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_1 x = new Employee_1();
            x.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please Select Book", "Warning", MessageBoxButtons.OK);
            }
        }

        private void searchbt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {

                int index = listBox1.FindString(textBox3.Text);

                if (index != -1)
                    listBox1.SetSelected(index, true);
                else
                    MessageBox.Show("The search string did not match any items in the ListBox");
            }
        }

        private void itemprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
