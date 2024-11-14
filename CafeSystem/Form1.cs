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
            global_variables.nextWindow(new signIn());
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

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(global_variables.Previous[global_variables.Previous.Length - 1]);
            Array.Resize(ref global_variables.Next, global_variables.Next.Length + 1);
            global_variables.Next.Append(global_variables.Previous[global_variables.Previous.Length - 1]);
            Array.Resize(ref global_variables.Next, global_variables.Previous.Length);
        }

        private void frontbutton_Click(object sender, EventArgs e)
        {

        }

        private void _process(object sender, EventArgs e)
        {
            frontbutton.Enabled = global_variables.Next.Length != 0;
            backbutton.Enabled = global_variables.Previous.Length != 0;

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new signIn());
        }

        private void cashierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new CashierForm());
        }
    }
}
