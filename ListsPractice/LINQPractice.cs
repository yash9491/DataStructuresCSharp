using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Models;

namespace DataStructures.ListsPractice
{
    public class LINQPractice
    {
        List<Students> stu = new List<Students>()
        {
            new Students
            {
                StudentId = 101,
                StudentName = "Acc",
                Country = "India"
            },
            new Students
            {
                StudentId = 102,
                StudentName = "Acc",
                Country = "SriLanka"
            },
             new Students
            {
                StudentId = 105,
                StudentName = "Acc",
                Country = "Spain"
            },
            new Students
            {
                StudentId = 103,
                StudentName = "Acc",
                Country = "Nepal"
            },
            new Students
            {
                StudentId = 104,
                StudentName = "Acc",
                Country = "Bangladesh"
            },
            new Students
            {
                StudentId = 106,
                StudentName = "Acc",
                Country = "Japan"
            }
        };

        public void getDetails()
        {
            var tst = from s in stu
                      where s.StudentId > 102
                      select s;

            List<Students> linq = tst.ToList();

            Console.WriteLine("Sample LINQ List Print");
            foreach(var st in linq)
            {
                Console.WriteLine(st.StudentId + " " + st.StudentName + "  " + st.Country);
            }

            var tst1 = from s in stu
                      where s.StudentId > 101
                      orderby s.StudentId descending
                      select s;

            var ts = stu.Where(s => s.StudentId == 10).OrderBy(s => s.StudentId).ThenBy(s => s.Country);

            List<Students> linq1 = tst1.ToList();

            Console.WriteLine("Order by LINQ");
            foreach (var st in linq1)
            {
                Console.WriteLine(st.StudentId + " " + st.StudentName + "  " + st.Country);
            }

            Console.ReadLine();
        }
         
    }
}
