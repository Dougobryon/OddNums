using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out odd numbers from 1 to 99 inclusive
            //start at 1, make condition less than or equal to 99, add two after each loop
            int counter;
            for (counter = 1; counter <= 99; counter += 2)
            {

                System.Console.WriteLine(counter);

            }

        }
    }
}
