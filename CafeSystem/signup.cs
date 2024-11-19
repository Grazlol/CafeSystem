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
}
