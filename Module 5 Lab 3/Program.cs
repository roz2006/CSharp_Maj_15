using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Lab_3
{
    class Program
    {
        struct ArrayResultat
        {
           public double sum;
           public double gennemsnit;
        }
        static ArrayResultat BeregnOgSorterArray(int[] a)
        {
            ArrayResultat r;
            Array.Sort(a);
            r.sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                r.sum += a[i];
            }
            r.gennemsnit = r.sum / a.Length;
            return r;
        }
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);
        }

    }
}

