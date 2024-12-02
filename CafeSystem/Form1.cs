using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            CashierForm cashierF = new CashierForm();
            this.Hide();
            cashierF.ShowDialog();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            foreach(Form blabla in global_variables.windows)
            {
                blabla.MdiParent = this;
            }
            global_variables.nextWindow(global_variables.homepage);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backPage(object sender, EventArgs e)
        {

        }

        private void cashierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new InventoryForm());
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form[] formus = new Form[global_variables.Previous.Length - 1];
            global_variables.nextWindow(global_variables.Previous[global_variables.Previous.Length - 1]);
            
            for(int i = 0; i < formus.Length; i++)
            {
                formus[i] = global_variables.Previous[i];
            }
            global_variables.Previous = new Form[formus.Length];
            global_variables.Previous = formus;
        }


        private void _process(object sender, EventArgs e)
        {
            backbutton.Enabled = global_variables.Previous.Length != 0;
            switch (global_variables.employee_position)
            {
                case "Cashier":
                    cashierTab.Enabled = true;
                    break;
                case "Inventory Manager":
                    inventoryTab.Enabled = true;
                    break;
                case "Admin":
                    inventoryTab.Enabled = true;
                    cashierTab.Enabled = true;
                    //adminTab.Enabled = true;
                    break;
            }

            cashier_name.Text = queryDB.select("name", "id", global_variables.current_user_id, "employee_accounts");
            cashier_position.Text = queryDB.select("position", "id", global_variables.current_user_id, "employee_accounts");
            lbl_checkedIn.Text = global_variables.str_checkedIn;

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(global_variables.homepage);
        }

        private void cashierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new CashierForm());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _physics_process(object sender, EventArgs e)
        {
            txt_dtime.Text = DateTime.Now.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminTab_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new Admin());
        }

        private void date_time_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
