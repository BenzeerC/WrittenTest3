using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest3
{
    internal class Program
    {
        //WAP to print all negative elements in an array and also count total number of negative elements in an array.
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, -3, 5, -8, 2, -5, 3 };
            Console.WriteLine("Negative Elements:");
            int count = 0;

            foreach (int num in numbers)
            {
                if (num < 0)
                { 
                Console.WriteLine(num);
                count++;
                }
            }
            Console.WriteLine("Count of all negative elements are:"+count);




        }
    }
}
