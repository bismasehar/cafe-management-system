using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project__cafe_System__
{
    public partial class Form1 : Form
    {
        string user;
        string pass;



        public Form1()
        {
            InitializeComponent();
           

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            pass = textBox2.Text;
            string role = comboBox1.Text;
            if (user == "admin" && pass == "a" && role == "admin")
            {

                MessageBox.Show("Admin Login successful!");
                Form2 obj = new Form2();
                obj.ShowDialog();

            }
            else if (user == "employee" && pass == "e" && role == "employee")
            {
                MessageBox.Show("Empolyee Login successful!");
                Form4 obj1 = new Form4();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username, Password Or Role", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
