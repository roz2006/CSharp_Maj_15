using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class Program
    {
        public static int LæggeSammen(int a, int b)
        {
            return a + b;
        }

        public static double BeregnAreal(int radius)
        {
            return System.Math.PI * radius * radius;
        }

        public static void Udskrive(string text)
        {
            Console.WriteLine(text);
        }
        public static void Udskrive()
        {
            Console.WriteLine();
        }
        public static double BeregnMoms(double beløb, double momsPct = 0.25)
        {
            return beløb * momsPct;
        }

        public static double Gennemsnit(params int[] månesløn)
        {
            double sum = 0;
            for (int i = 0; i < månesløn.Length; i++)
            {
                sum += månesløn[i];
            }
            return sum / månesløn.Length;
        }
        static void Main(string[] args)
        {
            int res = LæggeSammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskrive();
            Udskrive("Dette er en test");
            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);
            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res4);
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);
        }

    }
}
