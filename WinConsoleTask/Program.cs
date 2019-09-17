using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, s;
            try
            {
                Console.Write("x= ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y= ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("z= ");
                z = Convert.ToDouble(Console.ReadLine());
                double y1 = Math.Pow(y, 2 - z);
                s = (2 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(y1)) + z * z / (7 - z / 3.0);
                Console.WriteLine(Math.Round(s, 2, MidpointRounding.AwayFromZero));
            }
            catch
            {
                Console.WriteLine("Помилка");
            }
            Console.ReadKey();
        }
    }
}
