using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_lib
{
    class Donation
    {
        string donationID;
        string donationDate;
        string donorID;
        double donationAmount;
        string prizeID;

        public Donation(string donationID, string donationDate, string donorID, double donationAmount, string prizeID)
        {
            this.donationID = donationID;
            this.donationDate = donationDate;
            this.donorID = donorID;
            this.donationAmount = donationAmount;
            this.prizeID = prizeID;
        }

        public string toString()
        {
            return this.donationID + "," + this.donationDate + "," + this.donorID + "," + this.donationAmount + "," + this.prizeID;
        }

        public string DonationID
        {
            get { return donationID; }
        }

    }
}
