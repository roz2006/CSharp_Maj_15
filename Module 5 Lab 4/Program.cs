using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1;
            t1 = new Terning();
            Console.WriteLine(t1.værdi);

            Terning t2;
            t2 = new Terning(42);
            Console.WriteLine(t2.værdi);
            t2 = t1;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);

            t1.værdi = 13;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);

            t2.værdi = 11;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);
        }

    }

    class Terning
    {
        public int værdi;

        public Terning()
        {
            this.værdi = 1;    
        }

        public Terning(int a)
        {
            this.værdi = a;
        }
        
    }
    
    
}
