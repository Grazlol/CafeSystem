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
        string selectQuery = "select * from inventory;";
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            
            foreach (String i in queryDB.selectMultiple("item_name", "inventory"))
            {
                comboBox1.Items.Add(i);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int tempamount = int.Parse( queryDB.select("item_amount", "item_name", comboBox1.Text, "inventory"));
            tempamount = tempamount + int.Parse(numericUpDown1.Value.ToString());

            queryDB.update(tempamount.ToString(), "item_amount", "item_name",comboBox1.Text, "inventory");
            selectQuery = "select * from inventory;";
        }

        private void _process(object sender, EventArgs e)
        {
            dataGridView1.DataSource = queryDB.selectTable(selectQuery);
        }
    }
}
