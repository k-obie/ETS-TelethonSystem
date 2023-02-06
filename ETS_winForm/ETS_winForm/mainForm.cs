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
    public partial class mainForm : Form
    {
        ETSManager managerETS = new ETSManager();
        public mainForm()
        {
            InitializeComponent();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddSponsor_Click(object sender, EventArgs e)
        {
            string firstName = textSponsorFirstName.Text;
            string lastName = textSponsorLastName.Text;
            string sponsorID = textSponsorID.Text;
            int TotalPrizeValue = 0;


            string message = managerETS.addSponsor(firstName, lastName, sponsorID, TotalPrizeValue);
            MessageBox.Show(message);
        }

        private void buttonAddPrize_Click(object sender, EventArgs e)
        {

            string prizeID = textPrizeID.Text;
            string description = textPrizeDescription.Text;
            string value = textPrizeValue.Text;
            string minDonationValue = textPrizeMinimumDonation.Text;
            string quantity = textPrizeQuantity.Text;
            string sponsorID = textSponsorID.Text;


            string message = managerETS.addPrize(prizeID, description, value, minDonationValue, quantity, sponsorID);
            MessageBox.Show(message);
        }


        private void buttonListSponsors_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            richTextBoxInfo.Text = managerETS.listSponsors();            
        }
 
        private void buttonListPrizes_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            richTextBoxInfo.Text = managerETS.listPrizes();
        }

        private void buttonQualifiedPrizes_Click(object sender, EventArgs e)
        {
            string message = "";


            if (managerETS.doubleVerifier(textDonationAmount.Text) == true)
            {
                message = managerETS.listQualifiedPrizes(Convert.ToDouble(textDonationAmount.Text));

            }
            else
            {
                message = "Error. Donation amount should be a number.";

            }

            richTextBoxInfo.Clear();
            richTextBoxInfo.Text = message;

        }

        private void buttonAddDonation_Click(object sender, EventArgs e)
        {

            string message = "";
            string donorId = textDonorID.Text;
            string donorFirstName = textDonorFirstName.Text;
            string donorLastName = textDonorLastName.Text;
            string address = textDonorAddress.Text;
            string phone = textDonorPhone.Text;
            string cardNumber = textDonorCardNumber.Text;
            string cardExpiry = textDonorCardExpiry.Text;
            string donationId = textDonationID.Text;
            string donationAmount = textDonationAmount.Text;
            string prizeId = textDonationPrizeId.Text;
            string prizeQuantity = textDonationNumberPrize.Text;
            char cardType = managerETS.cardTypeVerifer(radioDonorCardTypeVisa.Checked, radioDonorCardTypeMC.Checked, radioDonorCardTypeAMEX.Checked);


            if (managerETS.donorVerifier(donorId) == false)
            {
                message = managerETS.addDonor(donorFirstName, donorLastName, donorId, address, phone, cardType, cardNumber, cardExpiry);

            }

            if (managerETS.donorVerifier(donorId) == true)
            {
                message = (message == "" ? "" : message + "\n") + managerETS.addDonation(donationId, donorId, donationAmount, prizeId, prizeQuantity);
            }


            MessageBox.Show(message);
        }
        //list donations
        private void buttonListDonations_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            richTextBoxInfo.Text = managerETS.listDonations();
        }
        //list donors
        private void buttonListDonor_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            richTextBoxInfo.Text = managerETS.listDonors();
        }
        //save donor info
        private void buttonSaveDonorInfo_Click(object sender, EventArgs e)
        {
            if (managerETS.writeDonors())
            {
                MessageBox.Show("Saved Donors.");
            }
            else
            {
                MessageBox.Show("Failed to save Donors.");
            }
        }


        private void odonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (managerETS.getDonors())
            {
                MessageBox.Show("Load Donors.");
            }
            else
            {
                MessageBox.Show("Failed to load Donors.");
            }
        }


        private void odonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (managerETS.getDonations())
            {
                MessageBox.Show("Load Donations.");
            }
            else
            {
                MessageBox.Show("Failed to load Donations.");
            }
        }
        private void osponsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (managerETS.getSponsors())
            {
                MessageBox.Show("Load Sponsors.");
            }
            else
            {
                MessageBox.Show("Failed to load Sponsors.");
            }

        }

        private void oprizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (managerETS.getPrizes())
            {
                MessageBox.Show("Load Prizes.");
            }
            else
            {
                MessageBox.Show("Failed to load Prizes.");
            }

        }

        private void oallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (managerETS.getDonors() && managerETS.getDonations() && managerETS.getSponsors() && managerETS.getPrizes())
            {
                MessageBox.Show("Load all.");
            }
            else
            {
                MessageBox.Show("Failed to load all.");
            }
        }

        private void sdonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (managerETS.writeDonors())
            {
                MessageBox.Show("Saved Donors.");
            }
            else
            {
                MessageBox.Show("Failed to save Donors.");
            }
        }
        private void sdonationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (managerETS.writeDonations())
            {
                MessageBox.Show("Saved Donations.");
            }
            else
            {
                MessageBox.Show("Failed to save Donations.");
            }
        }



        private void ssponsorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (managerETS.writeSponsors())
            {
                MessageBox.Show("Saved Sponsors.");
            }
            else
            {
                MessageBox.Show("Failed to save Sponsors.");
            }
        }
        private void sprizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (managerETS.writePrizes())
            {
                MessageBox.Show("Saved Prizes.");
            }
            else
            {
                MessageBox.Show("Failed to save Prizes.");
            }
        }

        private void sallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (managerETS.writeDonors() && managerETS.writeDonations() && managerETS.writeSponsors() && managerETS.writePrizes())
            {
                MessageBox.Show("Saved all.");
            }
            else
            {
                MessageBox.Show("Failed to save all.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonSearchSponsorIDMain_Click(object sender, EventArgs e)
        {
            serachSponsorIDForm searchSponsor = new serachSponsorIDForm();
            searchSponsor.Visible = true;
            searchSponsor.Activate();

        }

        private void buttonSearchDonorIDMain_Click(object sender, EventArgs e)
        {
            searchDonorIDForm searchDonor = new searchDonorIDForm();
            searchDonor.Visible = true;
            searchDonor.Activate();

        }
 

    }
}
