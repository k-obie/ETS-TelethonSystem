using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS_winForm
{
    public partial class login : Form
    {
        public static int counter = 0;
        public login()
        {
            InitializeComponent();
        }
        //cancel
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textUsername.Text == "ETS" && textPassword.Text == "admin")
            {
                mainForm mainForm = new mainForm();
                mainForm.Visible = true;
                mainForm.Activate();            
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Username or Password is invalid.");
                counter++;
                if (counter == 3)
                {
                    Application.Exit();
                }
            }
                        

        }
    }
}
