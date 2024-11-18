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
    public partial class prepage : Form
    {
        public prepage()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new signIn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global_variables.nextWindow(new signup());
        }
    }
}
