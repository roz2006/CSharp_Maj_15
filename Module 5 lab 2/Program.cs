using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_lab_2
{
    class Program
    {
        static int Beregn(int a, int b) { return MyAdd(a, b); }

        static int Beregn(int a, int b, int c) { return MyAdd(a, b); }

        static int Beregn(int a, int b, int c, int d) { return MyAdd(a,b,c,d); }

        static int MyAdd(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 3, 4));
        }
    }
}
