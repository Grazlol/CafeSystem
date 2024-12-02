using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class CashierForm : Form
    {
        String itemcategory = "";
        String itemtype = "";
        String itemvariant = "";
        int totalpriz = 0;
        String[] typerange = new String[0];
        double amountPaying = 0, changePay, changeTotal;
        public CashierForm()
        {
            InitializeComponent();
        }


        private void CashierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void icedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void milktea_panel_Paint(object sender, PaintEventArgs e)
        {

        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e) //PLACE ORDERSSsss
        {
            if (txt_customerName == null)
            {
                MessageBox.Show("Put the Customer Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (double.Parse(txt_change.Text) < 0 || txt_amountPay == null || txt_totalPrice.Text == null)
            {
                MessageBox.Show("Insufficient Amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int index = 0;
                foreach (String element in queryDB.selectMultiple("item_description", "temp_items"))
                {
                    int temp_amount = int.Parse(queryDB.select("item_amount", "item_name", queryDB.select("category", "item_description", element, "temp_items"), "item_library"));
                    temp_amount = temp_amount - int.Parse(queryDB.select("qty", "item_description", element, "temp_items"));

                    queryDB.update(temp_amount.ToString(), "item_amount", "item_name", queryDB.select("category", "item_description", element, "temp_items"), "item_library");
                }

                queryDB.query("delete from temp_items");
                queryDB.cmd.ExecuteNonQuery();
                dataGridView1.DataSource = queryDB.selectTable("select * from temp_items");
                MessageBox.Show("Order Performed!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void _process(object sender, EventArgs e)
        {
            if (queryDB.select("item_amount", "item_name", itemCat.Text, "item_library") != "null")
            {
                txt_qty.Maximum = int.Parse(queryDB.select("item_amount", "item_name", itemCat.Text, "item_library"));
            }
            Button[] buttonsname =
            {
                item_btn1,
                item_btn2,
                item_btn3,
                item_btn4,
                item_btn5,
                item_btn6,
                item_btn7,
                item_btn8,
                item_btn9,
                item_btn10,
                item_btn11,
                item_btn12,
                item_btn13,
                item_btn14,
                item_btn15,
                item_btn16

            };


            int index = 0;
            foreach (Button button in buttonsname)
            {
                if(index < queryDB.select("item_subtype", "item_name", itemCat.Text, "item_library").Split(',').Length)
                {
                    button.Text = queryDB.select("item_subtype", "item_name", itemCat.Text, "item_library").Split(',')[index];
                    button.Visible = true;
                } else
                {
                    button.Visible = false;
                }
                index++;
            }
            itemvariant = itemVar.Text;
            desc_bar.Text = itemCat.Text + " - " + itemtype + " - " + itemvariant;



            if(itemtype != "" && itemvariant != "")
            {
                int tempind = Array.IndexOf(queryDB.select("item_subtype", "item_name", itemCat.Text, "item_library").Split(','), itemtype);
                totalpriz = int.Parse(txt_qty.Value.ToString()) * int.Parse(queryDB.select("item_subprices","item_name",itemCat.Text, "item_library").Split(',')[tempind]);
            }
            else { totalpriz = 0; };
            
            txt_price.Text = totalpriz.ToString();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {

            Array catrange = queryDB.selectMultiple("item_name", "item_library");
            foreach (String i in catrange)
            {
                itemCat.Items.Add(i);
            }
            queryDB.query("delete from temp_items");
            queryDB.cmd.ExecuteNonQuery();
            dataGridView1.DataSource = queryDB.selectTable("select * from temp_items");
        }

        private void adorderbut_Click(object sender, EventArgs e)
        {
            queryDB.query("delete temp_items where item_description ='" + desc_bar.Text+"'");
            queryDB.cmd.ExecuteNonQuery();
            queryDB.query("insert into temp_items values ('" + desc_bar.Text + "','" + txt_qty.Value + "','" + totalpriz + "','" + itemCat.Text+"')");
            queryDB.cmd.ExecuteNonQuery();
            
            dataGridView1.DataSource = queryDB.selectTable("select * from temp_items");
        }

        private void itemCat_TextChanged(object sender, EventArgs e)
        {
            typerange = queryDB.select("item_variants", "item_name", itemCat.Text, "item_library").Split(',');
            itemVar.Text = "";
            itemtype = "";
            itemVar.Items.Clear();
            foreach (String i in typerange)
            {
                itemVar.Items.Add(i);
            }

            

        }

        private void item_btn1_Click(object sender, EventArgs e)
        {
            itemtype = item_btn1.Text; // Get the text of item_btn1
        }

        private void item_btn2_Click(object sender, EventArgs e)
        {
            itemtype = item_btn2.Text; // Get the text of item_btn2
        }

        private void item_btn3_Click(object sender, EventArgs e)
        {
            itemtype = item_btn3.Text; // Get the text of item_btn3
        }

        private void item_btn4_Click(object sender, EventArgs e)
        {
            itemtype = item_btn4.Text; // Get the text of item_btn4
        }

        private void item_btn5_Click(object sender, EventArgs e)
        {
            itemtype = item_btn5.Text; // Get the text of item_btn5
        }

        private void item_btn6_Click(object sender, EventArgs e)
        {
            itemtype = item_btn6.Text; // Get the text of item_btn6
        }

        private void item_btn7_Click(object sender, EventArgs e)
        {
            itemtype = item_btn7.Text; // Get the text of item_btn7
        }

        private void item_btn8_Click(object sender, EventArgs e)
        {
            itemtype = item_btn8.Text; // Get the text of item_btn8
        }

        private void item_btn9_Click(object sender, EventArgs e)
        {
            itemtype = item_btn9.Text; // Get the text of item_btn9
        }

        private void item_btn10_Click(object sender, EventArgs e)
        {
            itemtype = item_btn10.Text; // Get the text of item_btn10
        }

        private void item_btn11_Click(object sender, EventArgs e)
        {
            itemtype = item_btn11.Text; // Get the text of item_btn11
        }

        private void item_btn12_Click(object sender, EventArgs e)
        {
            itemtype = item_btn12.Text; // Get the text of item_btn12
        }

        private void item_btn13_Click(object sender, EventArgs e)
        {
            itemtype = item_btn13.Text; // Get the text of item_btn13
        }

        private void item_btn14_Click(object sender, EventArgs e)
        {
            itemtype = item_btn14.Text; // Get the text of item_btn14
        }

        private void item_btn15_Click(object sender, EventArgs e)
        {
            itemtype = item_btn15.Text; // Get the text of item_btn15
        }

        private void item_btn16_Click(object sender, EventArgs e)
        {
            itemtype = item_btn16.Text; // Get the text of item_btn16
        }

        private void button34_Click(object sender, EventArgs e)
        {
            queryDB.query("delete from temp_items");
            queryDB.cmd.ExecuteNonQuery();
            dataGridView1.DataSource = queryDB.selectTable("select * from temp_items");

        }

        private void reorderbut_Click(object sender, EventArgs e)
        {
            queryDB.query("delete from temp_items where item_description = '" + desc_bar.Text + "'");
            queryDB.cmd.ExecuteNonQuery();
            dataGridView1.DataSource = queryDB.selectTable("select * from temp_items");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            amountPaying = 20;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            amountPaying = 50;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            amountPaying = 100;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            amountPaying = 200;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            amountPaying = 500;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            amountPaying = 1000;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void btn_clearAmount_Click(object sender, EventArgs e)
        {
            amountPaying = 0;
            txt_amountPay.Text = amountPaying.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_change_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_amountPay_TextChanged(object sender, EventArgs e)
        {
            changeTotal = double.Parse(txt_amountPay.Text) - double.Parse(txt_totalPrice.Text);
            txt_change.Text = changeTotal.ToString();
        }
    }
}
