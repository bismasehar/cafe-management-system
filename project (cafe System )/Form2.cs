using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace project__cafe_System__
{
    public partial class Form2 : Form
    { 
      DataTable table=new DataTable("table");
        int index;
        public Form2()
        {
           
            InitializeComponent();
        }
       
        
        private void Button3_Click(object sender, EventArgs e)
        {



        }

        private void Form2_Load(object sender, EventArgs e)
        {
         table.Columns.Add("ID", Type.GetType("System.Int32"));
         table.Columns.Add("Name", Type.GetType("System.String"));
         table.Columns.Add("Stock", Type.GetType("System.Int32"));
         table.Columns.Add("Price(RS)", Type.GetType("System.Int32"));
         dataGridView2.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
                index = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[index];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(index);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView2.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Name Like'%{textBox5.Text}%'";
        }

        private void red(object sender, MouseEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            Form6 obj=new Form6();
            obj.ShowDialog();
        }
    }
}
