using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    public class AverageNumber
    {
        static int min = 1;
        static int max = 255;
        public static void Main()
        {
            double sum = 0;
            int numbers = 0;
            double input = -1;
            do
            {
                Console.WriteLine("Enter number:");
                if (double.TryParse(Console.ReadLine(), out input))
                {
                    if (input >= min && input <= max && input % 2 == 0)
                    {
                        sum += input;
                        numbers += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                    input = -1;
                }
            }
            while (input != 0);

            if (numbers > 0)
            {
                double avg = sum / numbers;
                Console.WriteLine("Finished !!!\n****************\n");
                Console.WriteLine("Average " + avg);
            }
            else
                Console.WriteLine("There aren't even numbers in this diapason [" + min + ", " + max + "] !!!");
        }
    }
}
