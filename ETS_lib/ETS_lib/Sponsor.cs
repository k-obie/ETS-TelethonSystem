using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_lib
{
    class Sponsor : Person
    {
        string sponsorID;
        double totalPrizeValue;

        public Sponsor(string fName, string lName, string sponsorID, double totalPrizeValue) : base ( fName, lName)
        {
            this.sponsorID = sponsorID;
            this.totalPrizeValue = totalPrizeValue;
               
        }


        public override string toString()
        {
            return base.toString() + "," + this.sponsorID + "," + this.totalPrizeValue;
        }

        public string SponsorID
        {
            get { return sponsorID; }
        }




        public double addValue(double value)
        {
            totalPrizeValue = totalPrizeValue + value;
            return totalPrizeValue;
        }

   

    }
}
