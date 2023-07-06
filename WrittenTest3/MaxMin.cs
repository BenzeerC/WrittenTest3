using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest3
{//WAP to find the maximum and minimum value in an array.
    internal class MaxMin
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 22,11,66,99,44};
           int max = values[0];
           int min = values[0];

            for(int i=0; i<values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
                if (values[i] < min)
                    min = values[i];
            }
            Console.WriteLine("Max value is:"+max);
            Console.WriteLine("=======================");
            Console.WriteLine("Min value is:" + min);

        }
    }
}
