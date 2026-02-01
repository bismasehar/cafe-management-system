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

namespace project__cafe_System__
{
    public partial class Form6 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Form6()
        {
            InitializeComponent();
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            table.Columns.Add("User_id", Type.GetType("System.Int32"));
            table.Columns.Add("User Name", Type.GetType("System.String"));
            table.Columns.Add("Pasword", Type.GetType("System.String"));
            table.Columns.Add("User_Type", Type.GetType("System.String"));
            dataGridView2.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex=-1;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(index);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView2.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = comboBox1.Text;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex=-1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"User Name Like'%{textBox5.Text}%'";
        }
    }
}
