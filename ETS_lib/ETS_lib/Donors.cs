using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETS_lib
{
    class Donors : CollectionBase
    {
        public void add(Donor donor)
        {
            List.Add(donor);
        }

        public Donor this[int index]
        {
            get { return (Donor)List[index]; }
            set { List[index] = value; }
        }

        public bool readDonors()
        {
            bool flag = false;
            using (StreamReader sr = new StreamReader(@"../../../../ETS_db/dbDonors.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;

                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    Donor donor = new Donor(strArray[0], strArray[1], strArray[2], strArray[3], strArray[4], Char.Parse(strArray[5]), strArray[6], strArray[7]);

                    this.add(donor);

                }
                flag = true;
            }
            return flag;
        }



        public bool writeDonors()
        {
            bool flag = false;


            using (StreamWriter sw = new StreamWriter(@"../../../../ETS_db/dbDonors.txt"))
            {
                
                for (int i = 0; i < this.Count; i++)
                {
                    
                    sw.WriteLine(this[i].toString());

                }


                flag = true;
            }
            return flag;
        }


        public bool delDoner(Donor donor)
        {
            bool flag = false;
            try
            {
                List.Remove(donor);
                flag = true;
            }
            catch (Exception ex)
            {

            }
            return flag;
            
        }

    }
}
