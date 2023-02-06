using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ETS_lib
{
    class Prizes : CollectionBase
    {
        
        public void add(Prize prize)
        {
            List.Add(prize);
        }

        public Prize this[int index]
        {
            get { return (Prize)List[index]; }
            set { List[index] = value; }
        }

        public bool readPrizes()
        {
            bool flag = false;
            using (StreamReader sr = new StreamReader(@"../../../../ETS_db/dbPrizes.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;

                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    Prize prize = new Prize(strArray[0], strArray[1], Double.Parse(strArray[2]), Double.Parse(strArray[3]), Int32.Parse(strArray[4]), strArray[5]);

                    this.add(prize);

                }
                flag = true;
            }
            return flag;
        }

        public bool writePrizes()
        {
            bool flag = false;


            using (StreamWriter sw = new StreamWriter(@"../../../../ETS_db/dbPrizes.txt"))
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
