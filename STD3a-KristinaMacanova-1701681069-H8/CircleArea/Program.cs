using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    public class CircleArea
    { 
        static int min = 33;
    static int max = 187;

    public static double GetArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    
        public static void Main()
        {
            Random random = new Random();
            double r = random.NextDouble() * (max - min) + min;
            Console.WriteLine("The random radius is = " + r);
            double area = GetArea(r);
            string formattedArea = area.ToString("F2");
            Console.WriteLine("The circle area is = " + formattedArea);
        }
    }
}
