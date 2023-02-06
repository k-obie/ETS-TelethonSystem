using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_lib
{
    abstract class Person
    {
        string fName;
        string lName;
        public Person(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public virtual string toString() 
        {
            return this.fName + "," +  this.lName;
        }
    }
}
