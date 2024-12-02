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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^\w+@[a-zA-Z_]+?.[a-zA-Z]{2,3}$";
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            string numPattern = @"^((^(\+)(\d){12}$)|(^\d{11}$))";
            //string studNoPattern = @"^((^\d{1}$))";

            bool isEmailValid = Regex.IsMatch(email_box.Text, emailPattern);
            bool isFirstNValid = Regex.IsMatch(fnbox.Text, namePattern);
            bool isLastNValid = Regex.IsMatch(lnbox.Text, namePattern);
            bool isPhoneNValid = Regex.IsMatch(conobox.Text, numPattern);

            if (!isEmailValid)
            {
                MessageBox.Show("Invalid Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!isFirstNValid)
            {
                MessageBox.Show("Invalid First Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!isLastNValid)
            {
                MessageBox.Show("Invalid Last Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!isPhoneNValid)
            {
                MessageBox.Show("Invalid Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (addbox.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Your Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (genbox.Text.Length == 0)
            {
                MessageBox.Show("Please Specify Your Gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (pwbox.Text != cpwbox.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (queryDB.select("email","email",email_box.Text,"employee_accounts") != "null")
            {
                MessageBox.Show("Email Already Used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Account Registered!");
                queryDB.insert("id", "employee_accounts");
                queryDB.update((lnbox.Text + "," + fnbox.Text + "," + mibox.Text), "name", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((email_box.Text), "email", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((pwbox.Text), "password", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((conobox.Text), "mobilenumber", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((addbox.Text), "address", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((emposbox.Text), "position", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((datebox.Text), "bday", "id", queryDB.Last_Created_ID, "employee_accounts");
                queryDB.update((genbox.Text), "gender", "id", queryDB.Last_Created_ID, "employee_accounts");
            }
                    


        }

        private void fnbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_showpass_Click(object sender, EventArgs e)
        {
            if (pwbox.PasswordChar != '\0') { pwbox.PasswordChar = '\0'; }

            else { pwbox.PasswordChar = '*'; }
        }
    }
}
