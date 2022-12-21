using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16and17_Algorithms_Batch222
{
    class PrimeNumbers
    {
        public static void PrimeCheck()
        {
            int startNumber = 2;
            int endNumber = 20;
            Console.WriteLine($"The Prime Numbers between 0 and 1000 are : ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();
        }
    }
}


