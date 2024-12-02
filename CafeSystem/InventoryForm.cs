using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class InventoryForm : Form
    {
        string selectQuery = "select id,item_name,item_amount,item_subtype from item_library;";
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            
            foreach (String i in queryDB.selectMultiple("item_name", "item_library"))
            {
                comboBox1.Items.Add(i);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int tempamount = int.Parse( queryDB.select("item_amount", "item_name", comboBox1.Text, "item_library"));
            tempamount = tempamount + int.Parse(numericUpDown1.Value.ToString());

            queryDB.update(tempamount.ToString(), "item_amount", "item_name",comboBox1.Text, "item_library");
            selectQuery = "select id,item_name,item_amount,item_subtype from item_library;";
        }

        private void _process(object sender, EventArgs e)
        {
            dataGridView1.DataSource = queryDB.selectTable(selectQuery);
        }
    }
}
