using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Numbers
{
    public class Palindrome
    {
        int pal, r ,n = 0;
        public void CheckPalindrome(int number)
        {
            n = number;
            if (n <= 0)
                Console.WriteLine("Please Enter Valid Number to Check");
            else
            {
                while (n > 0)
                {
                    r = n % 10;
                    pal = pal * 10 + r;
                    n = n / 10;
                }
            }

            if (pal == number)
                Console.WriteLine("The Given Number is Palindrome"+pal);
            else
                Console.WriteLine("The Given Number is not a Palindrome"+pal);
        }
    }
}
