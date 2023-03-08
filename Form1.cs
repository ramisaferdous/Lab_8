using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        List<user> users = new List<user>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox13.Text);
            string name = textBox14.Text;
            string Addres = textBox15.Text;
            user p1 = new user(id, name, Addres);
            users.Add(p1);
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            MessageBox.Show("USER CREATED SUCCESSFULLY");
        }
    }
}
