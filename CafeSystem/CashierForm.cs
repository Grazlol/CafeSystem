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
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }
        private void hide_all()
        {
            frappe_panel.Visible = false;
            milktea_panel.Visible = false;
        }

        private void cold_only()
        {
            txt_type.Text = "Cold";
            btn_hot.Enabled = false;
            btn_cold.Enabled = false;
        }

        private void cold_hot()
        {
            btn_hot.Enabled = true;
            btn_cold.Enabled = true;
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

        private void menu_frappe_Click(object sender, EventArgs e)
        {
            hide_all();
            frappe_panel.Show();

        }

        private void menu_milktea_Click(object sender, EventArgs e)
        {
            hide_all();
            milktea_panel.Show();
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

        private void btn_wintermelon_Click(object sender, EventArgs e)
        {
            txt_desc.Text = "Wintermelon";
            cold_only();
        }

        private void btn_hot_Click(object sender, EventArgs e)
        {
            txt_type.Text = "Hot";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_cold_Click(object sender, EventArgs e)
        {
            txt_type.Text = "Cold";
        }

        private void btn_cheesecake_Click(object sender, EventArgs e)
        {
            txt_desc.Text = "Cheesecake";
            cold_hot();
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
    }
}
