using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest3
{
    //WAP to print all unique elements in the array.
    internal class Unique
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2,3,2,4,5,6,6,8,9,7,9};

            var unique = array.Distinct();// Distinct word used to separate unique elements

            Console.WriteLine("Unique elements are:");

            foreach (int i in unique)
            {
                Console.WriteLine(i);
            }
        }
    }
}
