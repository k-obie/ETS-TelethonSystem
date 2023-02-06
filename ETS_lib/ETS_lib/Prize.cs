using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_lib
{
    class Prize
    {
        string prizeID;
        string description;
        double value;
        double donationMinLimit;
        int originalAvailable;
        int currentAvailable;
        string sponsorID;

        public Prize(string prizeID, string description, double value, double donationMinLimit, int originalAvailable, string sponsorID)
        {
            this.prizeID = prizeID;
            this.description = description;
            this.value = value;
            this.donationMinLimit = donationMinLimit;
            this.originalAvailable = originalAvailable;
            this.currentAvailable = originalAvailable;
            this.sponsorID = sponsorID;
        }

        public string toString()
        {
            return this.prizeID + "," + this.description + "," + this.value + "," + this.donationMinLimit + "," + this.originalAvailable + "," + this.currentAvailable + "," + this.currentAvailable + "," + this.sponsorID;
        }

        public string PrizeID
        {
            get { return prizeID; }
        }

        public double DonationMinLimit
        {
            get { return donationMinLimit; }
        }

        public int CurrentAvailable
        {
            get { return currentAvailable; }
        }

        public void decrease(int quantity)
        {
            if (quantity > currentAvailable)
            {
                this.currentAvailable = 0;
            }
            else
            {
                this.currentAvailable = this.currentAvailable - quantity;
            }
            
        }


    }
}
