using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x, x1, x2;
            Console.WriteLine("Tell me factor a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tell me factor b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tell me factor c");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta > 0) { x1 = (-b - delta) / (2 * a); x2 = (-b + delta) / (2 * a); Console.WriteLine("Delta is equal to {0}, its roots are {1} and {2}", delta, x1, x2); }
            else if (delta == 0) { x = (-b) / (2 * a); Console.WriteLine("Delta is equal to 0, {0} is its root", x); }
            else Console.WriteLine("Delta is equal to {0}, this functions does not have roots", delta);
            Console.ReadKey();
        }
    }
}
