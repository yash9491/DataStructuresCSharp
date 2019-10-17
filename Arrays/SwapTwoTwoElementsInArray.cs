using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SwapTwoTwoElementsInArray
    {
        public void swaptwoelements(int[] arr)
        {
            for(int i=0; i < arr.Length; i += 2)
            {
                if (i == arr.Length - 1)
                {
                    Console.WriteLine(arr[arr.Length-1]);
                }
                else
                {
                    arr[i] = arr[i] + arr[i + 1];
                    arr[i + 1] = arr[i] - arr[i + 1];
                    arr[i] = arr[i] - arr[i + 1];
                    Console.Write(arr[i] + "," + arr[i + 1] + ",");
                }
            }
        }
    }
}
