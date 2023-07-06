using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest3
{
    //WAP to find and count total number of duplicate elements in an array.
    internal class Duplicate
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 2, 5, 1, 2, 5, 6, 2, 4, 6 };
            int[] array2 = new int[12];

            foreach (int num1 in array)
            {
                array2[num1]++;   //for index value

            }
            Console.WriteLine("-----------Duplicate Elements are-----------------");
            foreach (int num2 in array2)
            {
                int count = array2[num2];
                if(num2>0)
                {
                    Console.WriteLine($" {num2} :Element occurs = {count}\n");
                }
            }
        }

    }
}
