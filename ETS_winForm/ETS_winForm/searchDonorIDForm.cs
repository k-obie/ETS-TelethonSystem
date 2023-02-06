using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETS_lib;

namespace ETS_winForm
{
    public partial class searchDonorIDForm : Form
    {
        ETSManager managerETS = new ETSManager();
        public searchDonorIDForm()
        {
            InitializeComponent();
        }
        public searchDonorIDForm(ETSManager managerETS)
        {
            InitializeComponent();
            this.managerETS = managerETS;
        }


        private void buttonSearchDonorID_Click(object sender, EventArgs e)
        {
            string id = textSearcDonorID.Text;

            richTextBoxSearchDonorID.Text = managerETS.searchDonorID(id);
        }

        private void buttonCancelSearchDonorID_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
