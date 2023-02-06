using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_lib
{
    class Donor : Person
    {
        string donorID;
        string address;
        string phone;
        char cardType;
        string cardNumber;
        string cardExpiry;

        public Donor(string fName, string lName, string donorID, string address, string phone, char cardType, string cardNumber, string cardExpiry) : base (fName, lName)
        {
            this.donorID = donorID;
            this.address = address;
            this.phone = phone;
            this.cardType = cardType;
            this.cardNumber = cardNumber;
            this.cardExpiry = cardExpiry;
        }

        public override string toString()
        {
            return base.toString() + "," + this.donorID + "," + this.address + "," + this.phone + "," + this.cardType + "," + this.cardNumber + "," + this.cardExpiry;
        }

        public string DonorID
        {
            get { return donorID; }
        }

    }
}
