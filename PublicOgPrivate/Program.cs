using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicOgPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skrive();
            t1.Ryst();
            t1.Skrive();

            Terning t2 = new Terning(true);
            t2.Skrive();
            t2.Ryst();
            t2.Skrive();

        }
    }

    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public void Skrive()
        {
            Console.WriteLine(this.værdi);
        }
        public void Ryst()
        {
            if (this.snyd == false)  this.værdi=rnd.Next(1,10);
            else
                this.værdi = 6;
        }

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;

        }


    }
}
