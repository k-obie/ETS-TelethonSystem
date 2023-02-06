using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. IO;

namespace ETS_lib
{
    public class ETSManager
    {
        
        Donors myDonors = new Donors();
        Sponsors mySponsors = new Sponsors();
        Donations myDonations = new Donations();
        Prizes myPrizes = new Prizes();

        public ETSManager()
        {
            getDonors();
            getDonations();
            getPrizes();
            getSponsors();

        }


        //Read
        public bool getSponsors()
        {
            mySponsors.Clear();
            return mySponsors.readSponsors();
        }//getSponsors

        public bool getPrizes()
        {
            myPrizes.Clear();
            return myPrizes.readPrizes();

        }//getPrizes

        public bool getDonors()
        {
            myDonors.Clear();
            return myDonors.readDonors();
            
        }//getDonors

        public bool getDonations()
        {
            myDonations.Clear();
            return myDonations.readDonations();

        }//getDonation



        //Write
        public bool writeSponsors()
        {
            return mySponsors.writeSponsors();
        }//writeSponsors

        public bool writePrizes()
        {
            return myPrizes.writePrizes();
        }//writePrizes

        public bool writeDonors()
        {
            return myDonors.writeDonors();
        }//writeDonors

        public bool writeDonations()
        {
            return myDonations.writeDonations();
        }//writeDonations



        //add Methods
        public string addSponsor(string fName, string lName, string sponsorID, double totalPrizeValue)
        {
            string message = "";


            if (sponsorID.Length != 4 || alphaNumericVerifier(sponsorID) == false)
            {
                message = "Error. The SponsorID should be 4 alphanumeric characters.";
            }
            else
            {
                if (sponsorVerifier(sponsorID) == true)
                {
                    message = "Error. This ID already exist for another Sponsor.";
                }
                else
                {
                    if ( fName.Length > 15 ||  fName.Length < 1  || alphaNumericSpaceHyphenVerifier(fName) == false)
                    {
                        message = "Error. First name should be between 1 and 15 alphanumeric, space, or hyphen characters.";
                    }
                    else
                    {
                        if (lName.Length > 15 || lName.Length < 1 || alphaNumericSpaceHyphenVerifier(lName) == false)
                        {
                            message = "Error. Last name should be between 1 and 15 alphanumeric, space, or hyphen characters.";
                        }
                        else
                        {
                            Sponsor sponsor = new Sponsor(fName, lName, sponsorID, 0.0);
                            mySponsors.add(sponsor);
                            message = "Done, a sponsor is added.\n" + "Info:\n" + "SponsorID: " + sponsorID + "\n" + "First name: " + fName + "\n" + "Last name: " + lName + "\n" + "Total Prize Value: " + 0.0 ;
                        }
                    }

                }
            }
            return message;
        }//addSponsor

        public string addPrize(string prizeID, string description, string valueStr, string donationMinLimitStr, string originalAvailableStr, string sponsorID)
        {
            string message = "";

            if (prizeID.Length != 4  || alphaNumericVerifier(prizeID) == false) 
            {
                message = "Error. Prize ID shoud be 4 alphanumeric characters.";
            }
            else
            {
                if (prizeVerifier(prizeID) == true)
                {
                    message = "Error, Prize ID alredy exist";
                }
                else
                {

                    if (sponsorVerifier(sponsorID) == false)
                    {
                        message = "Error. Sponsor ID does not exist.";
                    }
                    else
                    {

                        if (description.Length > 15 || description.Length < 1 || alphaNumericSpaceHyphenVerifier(description) == false)
                        {
                            message = "Error. Prize description should be between 1 and 15  alphanumeric , Space, or Hyphen characters";
                        }
                        else
                        {

                            if (doubleVerifier(valueStr) == false)
                            {
                                message = "Error. Value must be a number.\n";
                            }
                            else
                            {
                                double value = Convert.ToDouble(valueStr);

                                if (value < 1 || value > 299.99 )
                                {
                                    message = "Error. Value must be a number between 1 and 299.99 .\n";
                                }
                                else
                                {

                                    if (doubleVerifier(donationMinLimitStr) == false)
                                    {
                                        message = "Error. Minimum donation limit must be a number.\n";
                                    }
                                    else
                                    {
                                        double donationMinLimit = Convert.ToDouble(donationMinLimitStr);
                                        if (donationMinLimit < 0)
                                        {
                                            message = "Error. Minimum donation limit must be 0 or greater.";
                                        }
                                        else
                                        {
                                           
                                            if (intVerifier(originalAvailableStr) == false)
                                            {
                                                message = "Error. Quantity must be a number.\n";
                                            }
                                            else
                                            {
                                                int originalAvailable = Convert.ToInt32(originalAvailableStr);
                                                if (originalAvailable < 0 || originalAvailable > 999)
                                                {
                                                    message = "Incorrect input. Quantity must be a number between 0 and 999\n";
                                                }
                                                else
                                                {

                                                    Prize prize = new Prize(prizeID, description, value, donationMinLimit, originalAvailable, sponsorID);
                                                    myPrizes.add(prize);
                                                    message = "Done. Added prize to the list.\n" + "Info:\n" +
                                                        "PrizeID: " + prizeID + "\nDescription: " + description + "\nValue: " + value + "\nMinimum Donation limit: " + donationMinLimit + "\nQuantity: " + originalAvailable + "\nSponsorID: " + sponsorID;

                                                    //Adding Total value to the sponsor
                                                    foreach (Sponsor sponsor in mySponsors)
                                                    {
                                                        if (sponsorID == sponsor.SponsorID)
                                                        {
                                                            double newTotalPrizeValue = sponsor.addValue(value * originalAvailable);
                                                            message = message + "\nThe new totalPrizeValue for the Sponsor " + sponsorID + " is " + newTotalPrizeValue + ".";
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return message;
        }//addPrize


        public string addDonor(string fName, string lName, string donorID, string address, string phone, char cardType, string cardNumber, string cardExpiry)
        {
            string message = "";
            if (donorID.Length != 4 || alphaNumericVerifier(donorID) == false)
            {
                message = "Error. The DonorID should be 4 alphanumeric characters.";
            }
            else
            {
                if (donorVerifier(donorID) == true)
                {
                    message = "Error! This DonorID already exist for another Donor.";
                }
                else
                {
                    if (fName.Length > 15 || fName.Length < 1 || alphaNumericSpaceHyphenVerifier(fName) == false)
                    {
                        message = "Error. First name should be between 1 and 15 alphanumeric, space, or hyphen characters.";
                    }
                    else
                    {
                        if (lName.Length > 15 || lName.Length < 1 || alphaNumericSpaceHyphenVerifier(lName) == false)
                        {
                            message = "Error. Last name should be between 1 and 15 alphanumeric, space, or hyphen characters.";
                        }
                        else
                        {

                            if (address.Length > 40 || address.Length < 1 || alphaNumericSpaceHyphenVerifier(address) == false)
                            {
                                message = "Error. Address should be between 1 and 40 alphanumeric, space, or hyphen characters.";
                            }
                            else
                            {
                                                                
                                if (phoneVerifier(phone) == false)
                                {
                                    message = "Error. Phone should be follow this pather \"999 999-9999\".";
                                }
                                else
                                {

                                    if (cardType != 'V' && cardType != 'M' && cardType != 'A')
                                    {
                                        message = "Error. Card type must be must be \"VISA\" , \"MC\" or \"AMEX\" .";
                                    }
                                    else
                                    {
                                                                                
                                        if (cardNumVerifier(cardNumber) == false)
                                        {
                                            message = "Error. Credit card number should be 16 numbers.";
                                        }
                                        else
                                        {
                                            if (cardExiryVerifier(cardExpiry) == false)
                                            {
                                                message = "Error. Expiry should be a valid month and year in numeric form that follow this pattern \"mm/yyyy\".";
                                            }
                                            else
                                            {

                                                Donor donor = new Donor(fName, lName, donorID, address, phone, cardType, cardNumber, cardExpiry);
                                                myDonors.add(donor);
                                                message = "Done, doner is added.\n" + "Info:\n" +
                                                    "\nDonorID: " + donorID + "\nFirst Name: " + fName + "\nLast Name: " + lName + "\nAddress: " + address + "\nPhone: " + phone + "\nCard Type: " + cardType + "\nCard Number: " + cardNumber + "\nCard Expiry: " + cardExpiry;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }                   
                }
            }
            return message;
        }//addDonor


        public string addDonation(string donationID, string donorID, string donationAmountStr, string prizeID, string prizeQuantityStr)
        {
            string message = "";
            if (donationID.Length != 4 || alphaNumericVerifier(donationID) == false)
            {
                message = "Error. The Donation ID should be 4 alphanumeric characters.";
            }
            else
            {
                if (donationVerifier(donationID) == true)
                {
                    message = "Error! This Donation ID exist for another Donation.";
                }
                else
                {

                    if (donorVerifier(donorID) == false)
                    {
                        message = "Error. The Donor ID does not exist.";
                    }
                    else
                    {

                        if (doubleVerifier(donationAmountStr) == false)
                        {
                            message = "Error. The Donation Amount should be a number.";
                        }
                        else
                        {
                            double donationAmount = Convert.ToDouble(donationAmountStr);

                            if (donationAmount < 5 || donationAmount > 999999.99)
                            {
                                message = "Error. The Donation Amount must be a number between 5 and 999999.99\n";
                            }
                            else
                            {
                                if (prizeVerifier(prizeID) == false)
                                {
                                    message = "Error. The Prize ID does not exist.";
                                }
                                else
                                {

                                    foreach (Prize prize in myPrizes)
                                    {
                                        if (prizeID == prize.PrizeID)
                                        {

                                            if (donationAmount < prize.DonationMinLimit)
                                            {
                                                message = "Error. The selected prize is greater then donation amount.";
                                            }
                                            else
                                            {

                                                if (intVerifier(prizeQuantityStr) == false)
                                                {
                                                    message = "Error. Quantity should to be a number.";
                                                }
                                                else
                                                {
                                                    if (prize.CurrentAvailable < 1)
                                                    {
                                                        message = "Error. Prize inventory is zero.";
                                                    }
                                                    else
                                                    {
                                                        int prizeQuantity = Convert.ToInt32(prizeQuantityStr);
                                                        int maxQuantityToGet = (int)(donationAmount / prize.DonationMinLimit);

                                                        if (prizeQuantity > prize.CurrentAvailable || prizeQuantity > maxQuantityToGet || prizeQuantity < 1)
                                                        {
                                                            message = "Error. Prize quantity must be a number between 1 and " + (maxQuantityToGet < prize.CurrentAvailable ? maxQuantityToGet : prize.CurrentAvailable) + "\n";
                                                        }
                                                        else
                                                        {
                                                            prize.decrease(prizeQuantity);

                                                            string date = DateTime.UtcNow.ToString("d");
                                                            Donation donation = new Donation(donationID, date, donorID, donationAmount, prizeID);
                                                            myDonations.add(donation);
                                                            message = "Done, donation is added.\n" + "Info: \n" + "\nDonation ID: " + donationID + "\nDate: " + date + "\nDonor ID: " + donorID + "\nDonation Amount: " + donationAmount + "\nPrize ID: " + prizeID + "\n";
                                                            break;
                                                        }
                                                    }                                                

                                                }                                                
                                            }
                                        }
                                    }//prize for each loop
                                }
                            }
                        }                        
                    }
                }
            }
            return message;

        }//addDonation



        //list Methods
        public string listDonors()
        {
            string message = "Info of Donors:\n";
            foreach (Donor donor in myDonors)
            {
                
                string[] strArray;
                strArray = donor.toString().Split(',');
                message = message + "\nName: " + strArray[0] + " " + strArray[1] + "\nDonor ID: " + strArray[2] + "\nAddress: " + strArray[3] + "\nPhone: " + strArray[4] + "\nCard Type: " + strArray[5] + "\nCredit Card Number: " + strArray[6] + "\nExpiry: " + strArray[7] + "\n";
            }


            return message;
        }//listDonors

        public string listSponsors()
        {
            string message = "Info of Sponsors:\n";

            foreach (Sponsor sponsor in mySponsors)
            {
                string[] strArray;
                strArray = sponsor.toString().Split(',');

                message = message + "\nName: " + strArray[0] + " " + strArray[1] + "\nSponsor ID: " + strArray[2] + "\nTotal Prize Value: " + strArray[3] + "\n";
            }

            return message;
        }//listSponsors

        public string listPrizes()
        {

            string message = "Info of Prizes:\n";
            foreach (Prize prize in myPrizes)
            {
                string[] strArray;
                strArray = prize.toString().Split(',');
                message = message + "\nPrize ID: " + strArray[0] + "\nDescription: " + strArray[1] + "\nValue: " + strArray[2] + "\nMin Donation Limit: " + strArray[3] + "\nOriginal Quantity: " + strArray[4] + "\nCurrent Quantity: " + strArray[6] + "\nSponsor ID: " + strArray[7] + "\n";                
            }

            return message;
        }//listPrizes

        public string listDonations()
        {

            string message = "Info of Donations:\n";
            foreach (Donation donation in myDonations)
            {
                string[] strArray;
                strArray = donation.toString().Split(',');
                message = message + "\nDonation ID: " + strArray[0] + "\nDate: " + strArray[1] + "\nDonor ID: " + strArray[2] + "\nDonation Amount: " + strArray[3] + "\nPrize ID: " + strArray[4] + "\n";

            }

            return message;
        }//listDonations

        public string listQualifiedPrizes(double donationAmount)
        {
            string message = "Qualified Prizes\n";
            foreach (Prize prize in myPrizes)
            {
                if (donationAmount > prize.DonationMinLimit && prize.CurrentAvailable > 0)
                {
                    string[] strArray;
                    strArray = prize.toString().Split(',');

                     int maxNumberOfPrizesCanGet = (int)(donationAmount / prize.DonationMinLimit);
                    
                    //setting the correct maximum
                    maxNumberOfPrizesCanGet = maxNumberOfPrizesCanGet > prize.CurrentAvailable ? prize.CurrentAvailable : maxNumberOfPrizesCanGet;

                    message = message + "\nPrize ID: " + strArray[0] + "\nDescription: " + strArray[1] + "\nValue: " + strArray[2] + "\nMin Donation Limit: " + strArray[3] + "\nOriginal Quantity: " + strArray[4] + "\nCurrent Quantity: " + strArray[6] + "\nSponsor ID: " + strArray[7] + "\nMax Quantity for Donation: " + maxNumberOfPrizesCanGet + "\n";

                }
            }

            return message;
        }//listQualifiedPrizes



        //Verifiers Methods

        public bool sponsorVerifier(string sID)
        {
            bool flag = false;
            foreach (Sponsor spon in mySponsors)
            {
                if (spon.SponsorID == sID)
                {

                    flag = true;
                }
            }
            return flag;
        }//sponsorVerifier

        public bool prizeVerifier(string pID)
        {
            bool flag = false;
            foreach (Prize prize in myPrizes)
            {
                if (prize.PrizeID == pID)
                {

                    flag = true;
                }
            }
            return flag;
        }//prizeVerifier

        public bool donorVerifier(string donorID)
        {
            bool flag = false;
            foreach (Donor donor in myDonors)
            {
                if (donor.DonorID == donorID)
                {

                    flag = true;
                }
            }
            return flag;
        }//donorVerifier

        public bool donationVerifier(string donationID)
        {
            bool flag = false;
            foreach (Donation donation in myDonations)
            {
                if (donation.DonationID == donationID)
                {

                    flag = true;
                }
            }
            return flag;
        }//donationVerifier

        public bool doubleVerifier(string strNumber)
        {
            bool flag = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(strNumber, "^([0-9]*\\.[0-9]*|[0-9]*)$") == true)
            {
                if (strNumber.Length > 0)
                {
                    flag = true;
                    
                }
            }

            return flag;
        }//doubleVerifier

        public bool intVerifier(string strNumber)
        {
            bool flag = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(strNumber, "^[0-9]*$"))
            {
                if (strNumber.Length > 0)
                {
                    flag = true;

                }
            }

            return flag;
        }//intVerifier

        public char cardTypeVerifer(bool visaCheck, bool masterCardCheck, bool americanExpressCheck)
        {
            char cardType = 'Z';

            if (visaCheck == true)
            {
                cardType = 'V';
            }
            else if (masterCardCheck == true)
            {
                cardType = 'M';
            }
            else if (americanExpressCheck == true)
            {
                cardType = 'A';
            }
          
            return cardType;
        }//cardTypeVerifer

        public bool phoneVerifier(string strPhone)
        {
            bool flag = false;

            if (System.Text.RegularExpressions.Regex.IsMatch(strPhone, "^[0-9]{3} [0-9]{3}-[0-9]{4}$"))
            {
                if (strPhone.Length == 12)
                {
                    flag = true;

                }
            }
            return flag;
        }//phoneVerifier

        public bool cardNumVerifier(string strNumber)
        {
            bool flag = false;

            if (strNumber.Length == 16 && System.Text.RegularExpressions.Regex.IsMatch(strNumber, "^[0-9]*$"))
            {
                flag = true;
            }
            return flag;
        }//cardNumVerifier

        public bool alphaNumericVerifier(string str)
        {
            bool flag = false;

            if (str.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(str, "^[a-zA-Z0-9]*$"))
            {
                flag = true;
            }
            return flag;
        }//alphaNumericVerifier

        public bool alphaNumericSpaceHyphenVerifier(string str)
        {
            bool flag = false;

            if (str.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(str, "^[a-zA-Z0-9\\- ]*$"))
            {
                flag = true;
            }
            return flag;
        }//alphaNumericSpaceHyphenVerifier

        public bool cardExiryVerifier(string strCardExiry)
        {
            bool flag = false;
            string[] curentDate = DateTime.Now.ToString("MM/dd/yyyy").Split('-');
            int currentYear = Convert.ToInt32(curentDate[2]);
            int currentMonth = Convert.ToInt32(curentDate[0]);

            if (System.Text.RegularExpressions.Regex.IsMatch(strCardExiry, "^(0[1-9]|1[0-2])/([0-9]{4})$") == true && strCardExiry.Length == 7)
            {
                string[] expiry = strCardExiry.Split('/');
                int cardExpirationMonth = Convert.ToInt32(expiry[0]);
                int cardExpirationYear = Convert.ToInt32(expiry[1]);
                
                if (cardExpirationYear > currentYear)
                {
                    flag = true;
                }
                else if (cardExpirationYear == currentYear && cardExpirationMonth >= currentMonth && cardExpirationMonth <= 12)
                {
                    flag = true;
                }
                
            }

            return flag;
        }//cardExiryVerifier



        //search Methods

        public string searchSponsorID(string sponsorID)
        {
            string message = "";

            if (sponsorID.Length != 4 || alphaNumericVerifier(sponsorID) == false)
            {
                message = "Error. The SponsorID should be 4 alphanumeric characters.";
            }
            else
            {
                if (sponsorVerifier(sponsorID) == false)
                {
                    message = "Error. This ID does not exist for a Sponsor.";
                }
                else
                {

                    foreach (Sponsor sponsor in mySponsors)
                    {
                        if (sponsor.SponsorID == sponsorID)
                        {
                            string[] strArray;
                            strArray = sponsor.toString().Split(',');

                            message = "Info of Sponsor:\n" + "\nName: " + strArray[0] + " " + strArray[1] + "\nSponsor ID: " + strArray[2] + "\nTotal Prize Value: " + strArray[3] + "\n";

                            break;
                        }
                    }
                }
            }

            return message;

        }//searchSponsorID

        public string searchDonorID(string donorID)
        {
            string message = "";

            if (donorID.Length != 4 || alphaNumericVerifier(donorID) == false)
            {
                message = "Error. The DonorID should be 4 alphanumeric characters.";
            }
            else
            {
                if (donorVerifier(donorID) == false)
                {
                    message = "Error. This ID does not exist for a Donor.";
                }
                else
                {

                    foreach (Donor donor in myDonors)
                    {
                        if (donor.DonorID == donorID)
                        {
                            string[] strArray;
                            strArray = donor.toString().Split(',');
                            message = "Info of Donor:\n" + "\nName: " + strArray[0] + " " + strArray[1] + "\nDonor ID: " + strArray[2] + "\nAddress: " + strArray[3] + "\nPhone: " + strArray[4] + "\nCard Type: " + strArray[5] + "\nCredit Card Number: " + strArray[6] + "\nExpiry: " + strArray[7] + "\n";

                            break;

                        }
                    }
                }
            }

            return message;

        }//searchDonorID


    }
}
