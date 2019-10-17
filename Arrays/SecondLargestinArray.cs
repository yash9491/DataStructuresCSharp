using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SecondLargestinArray
    {
        public void SecondLargestInArray(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = arr[i] + arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                    }
                }
            }

            Console.WriteLine("Second Largest of the array is" + arr[arr.Length - 2]);
        }
    }
}
