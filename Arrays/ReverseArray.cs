using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ReverseArray
    {
        public void ReverseTheArray(int []arr)
        {
            for(int i= arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ,");
            }
            Console.ReadLine();
        }
    }
}
