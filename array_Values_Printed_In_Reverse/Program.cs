using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_Values_Printed_In_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valuesArray = { 2, 5, 7 };

            Array.Reverse(valuesArray); // reverse the array

            for (int i = 0; i < valuesArray.Length; i++)
            {
                Console.Write(valuesArray[i] + " ");
            }





            Console.ReadLine();

        }
    }
}
