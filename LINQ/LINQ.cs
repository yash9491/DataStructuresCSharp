using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LINQ
{
    public class LINQ
    {
        public void LINQDemo()
        {
            List<string> lst = new List<string>();
            lst.Add("Jan");
            lst.Add("Feb");
            lst.Add("Mar");
            lst.Add("Apr");
            lst.Add("May");
            lst.Add("Jun");

            var mylist = from s in lst
                         orderby s descending
                         select s;
        }
    }
}
