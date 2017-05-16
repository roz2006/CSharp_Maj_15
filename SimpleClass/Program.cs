using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "MinFørstVare";
            v1.Pris= 49.95;
            Console.WriteLine("{0} som bruger default consstructor har pris som {1}", v1.Navn, v1.Pris);

            Vare v2 = new Vare("MinAndenVare", 99.95);
            Console.WriteLine("{0} som bruger customer constructor har pris som {1}", v2.Navn,v2.Pris);

            Console.WriteLine("{0} pris med moms er {1}",v1.Navn, v1.PrisMedMoms(v1.Pris));
            Console.WriteLine("{0} pris med moms er {1}", v2.Navn, v2.PrisMedMoms(v2.Pris));
        }
    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get { Console.WriteLine(navn); return navn; }
            set { navn = value; Console.WriteLine(navn); }
        }

        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            Navn = navn;
            Pris = pris;
        }
        public double PrisMedMoms(double pris)
        {
            return pris * (1 + 0.25);
        }

    }
}
