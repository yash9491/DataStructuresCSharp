using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RemoveDuplicates
    {
        public void RemoveDuplicatesFromArray(int[] arr)
        {
            var slist = new ArrayList();
            for( int i = 0; i< arr.Length; i++)
            {
                if (slist.Contains(arr[i]) == false)
                    slist.Add(arr[i]);
            }
        }
    }
}
