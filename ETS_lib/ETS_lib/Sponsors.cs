using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETS_lib
{
    class Sponsors : CollectionBase
    {
        
        public void add(Sponsor sponsor)
        {
            List.Add(sponsor);
        }

        public Sponsor this[int index]
        {
            get { return (Sponsor)List[index]; }
            set { List[index] = value; }
        }

        public bool readSponsors()
        {
            bool flag = false;

            using (StreamReader sr = new StreamReader(@"../../../../ETS_db/dbSponsors.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;

                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    Sponsor sponsor = new Sponsor(strArray[0], strArray[1], strArray[2], Int32.Parse(strArray[3]));

                    this.add(sponsor);                  

                }
                flag = true;
            }
            return flag;
        }

        public bool writeSponsors()
        {
            bool flag = false;


            using (StreamWriter sw = new StreamWriter(@"../../../../ETS_db/dbSponsors.txt"))
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
