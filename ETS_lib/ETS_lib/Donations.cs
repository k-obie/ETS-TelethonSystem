using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETS_lib
{
    class Donations : CollectionBase
    {
        public void add(Donation donation)
        {
            List.Add(donation);
        }

        public Donation this[int index]
        {
            get { return (Donation) List[index]; }
            set { List[index] = value; }
        }

        public bool readDonations()
        {
            bool flag = false;
            using (StreamReader sr = new StreamReader(@"../../../../ETS_db/dbDonations.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;

                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    Donation donation = new Donation(strArray[0], strArray[1], strArray[2], Double.Parse(strArray[3]), strArray[4]);

                    this.add(donation);

                }
                flag = true;
            }
            return flag;
        }


        public bool writeDonations()
        {
            bool flag = false;


            using (StreamWriter sw = new StreamWriter(@"../../../../ETS_db/dbDonations.txt"))
            {
                
                for (int i = 0; i < this.Count; i++)
                {
                    
                    sw.WriteLine(this[i].toString());

                }


                flag = true;
            }
            return flag;
        }

    }
}
