using Packt.CS7;
using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);

            //Compare the name lengths, doesn't sort by alpha
            int temp = x.Name.Length.CompareTo(y.Name.Length);

            //if equal
            if (temp == 0)
            {
                //sort the name
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                //otherwise sort by the lengths.
                return temp;
            }
        }
    }
}
