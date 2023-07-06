using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest3
{
    internal class Evenodd
    {
        static void Main(string[] args)
        {
            //WAP to put even and odd elements of array in two separate arrays.
            int[] even = new int[] { 1, 3, 5, 2, 6, 8 };
            Console.WriteLine("Even elements are:");
            int count = 0;

            foreach (int num1 in even)
            {
                if(num1%2==0)
                {
                    Console.WriteLine(num1);
                    count++;
                }

            }
            Console.WriteLine("Total even elements are:"+count);
            Console.WriteLine("======================================");
            int[] odd = new int[] { 1, 3, 4, 6, 7, 9 };
            Console.WriteLine("Odd elements are:");
            int count1 = 0;

            foreach (int num2 in odd)
            {
                if(num2%2!=0)
                {
                    Console.WriteLine(num2);
                    count1++;
                }
            }
            Console.WriteLine("Total odd elements are:" + count1);
        }
        
    }
}
