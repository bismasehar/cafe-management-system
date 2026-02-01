using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project__cafe_System__
{
    public partial class Form5 : Form
    {
        DataTable table = new DataTable("table");
        int index;

        public Form5()
        {
            InitializeComponent();
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            table.Columns.Add(" Inventory_ID", Type.GetType("System.Int32"));
            table.Columns.Add("Item_Name", Type.GetType("System.String"));
            table.Columns.Add("Item_Stock", Type.GetType("System.Int32"));
            table.Columns.Add("Item_Price(RS)", Type.GetType("System.Int32"));
            dataGridView2.DataSource = table;
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
