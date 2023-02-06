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
    public partial class serachSponsorIDForm : Form
    {

        ETSManager managerETS = new ETSManager();
        public serachSponsorIDForm()
        {
            InitializeComponent();
        }

        public serachSponsorIDForm(ETSManager managerETS)
        {
            InitializeComponent();
            this.managerETS = managerETS;
        }

        private void buttonSearchSponsorID_Click(object sender, EventArgs e)
        {
            string id = textSearchSponsorID.Text;

            richTextBoxSearchSponsorID.Text = managerETS.searchSponsorID(id);
        }

        private void buttonCancelSearchSponsorID_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
