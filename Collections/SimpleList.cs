using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections
{
    public class SimpleList
    {
        public void myListItems()
        {
            List<int> mylist = new List<int>();
            mylist.Add(10);
            mylist.Add(20);
            mylist.Add(30);
            mylist.Add(40);
            mylist.Add(20);

            foreach (int n in mylist)
            {
                Console.WriteLine(n);
            }

            mylist.Remove(20);
            foreach (int n in mylist)
            {
                Console.WriteLine(n);
            }

            mylist.RemoveAt(2);
            foreach (int n in mylist)
            {
                Console.WriteLine(n);
            }

            List<EmployeeModel> models = new List<EmployeeModel>(){
                new EmployeeModel()
                {
                    Eid = 2,
                    Ename = "Hii"
                },
                new EmployeeModel()
                {
                    Eid = 3,
                    Ename = "Yaswanth"
                }
            };

            models.Add(new EmployeeModel()
            {
                Eid = 4,
                Ename = "Acc"
            });

            foreach(EmployeeModel n in models)
            {
                Console.WriteLine(n.Eid + " ," + n.Ename);
            }
        }

    }
}