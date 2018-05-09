using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, pi;

            pi = 3.14;

            Console.Write("Enter a radius: ");
            r = double.Parse(Console.ReadLine());

            a = pi * r * r;

            Console.WriteLine("The area of a circle with radius " + r + " is: " + a);
            Console.ReadLine();
        }
    }
}
