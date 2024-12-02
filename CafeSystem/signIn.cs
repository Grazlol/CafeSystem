﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeSystem
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            bool logged_in = false;

            if(queryDB.select("password","email",emBox.Text,"employee_accounts") == pwBox.Text)
            {
                logged_in = true;
                global_variables.str_checkedIn = DateTime.Now.ToString();
                
            }

            else { MessageBox.Show("Incorrect Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                if (logged_in) {
                global_variables.employee_position = queryDB.select("position", "email", emBox.Text, "employee_accounts");
                global_variables.current_user_id = queryDB.select("id", "email", emBox.Text, "employee_accounts");
                global_variables.homepage = new home();
                global_variables.nextWindow(global_variables.homepage);
                global_variables.Previous = new Form[0];
                
            }

 
        }

        private void btn_showpass_Click(object sender, EventArgs e)
        {
            if (pwBox.PasswordChar != '\0') { pwBox.PasswordChar = '\0';}

            else { pwBox.PasswordChar = '*'; }
        }
    }
}
