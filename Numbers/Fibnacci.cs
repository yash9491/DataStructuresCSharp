using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Numbers
{
    public class Fibnacci
    {
        int n1 = 0, n2 = 1, n3;
        public void GenerateFibnacci(int n)
        {
            Console.Write(n1 + ",");
            Console.Write(n2 + ",");
            for (int i = 2; i < n; i++)
                {
                    n3 = n1 + n2;
                    n1 = n2;
                    n2 = n3;
                Console.Write(n3 + ",");
            }
           
        }
    }
}
