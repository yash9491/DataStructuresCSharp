using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class EnumerableEnumerator
    {
        public void demo() {
            List<string> month = new List<string>();
            month.Add("Jan");
            month.Add("Feb");
            month.Add("Mar");

            IEnumerable<string> ienum = (IEnumerable<string>)month;
            foreach(string n in ienum)
            {
                Console.WriteLine(n);
            }

            IEnumerator<string> ient = month.GetEnumerator();
            while (ient.MoveNext())
            {
                Console.WriteLine(ient.Current);
            }

            //IEnumerable is implemeted from IEnumerator
            //The diff b/while them is The state in IEnumerator is maintained.
            //In the above code, If we pass ient to another method after Jan, then Feb will be printed in next method.
        }
    }
}
