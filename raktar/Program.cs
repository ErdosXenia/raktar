using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktar
{
    class Program
    {
        static List<termek> termekek = new List<termek>();
        static List<megrendeles> megrendelesek = new List<megrendeles>();
        static void BeolvRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                //Console.WriteLine(sor[0]);
                //sor[0] -> kód
                //sor[1] -> név
                //sor[2] -> Ár
                //sor[3] -> Db

                termekek.Add(new termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
            }
            raktar.Close();
        }

        static void BeolvMegrendeles()
        {
            StreamReader megr = new StreamReader("rendeles.csv");

            while (!megr.EndOfStream)
            {
                string[] sor = megr.ReadLine().Split(';');

                if (sor[0] == "M")
                {
                    megrendelesek.Add(new megrendeles(sor[1], sor[2], sor[3]));
                }   
            }
            megr.Close();
        }

        static void Main(string[] args)
        {
            BeolvRaktar();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }

            Console.WriteLine();

            BeolvMegrendeles();

            foreach (var m in megrendelesek)
            {
                Console.WriteLine($"{m.Datum} - {m.Rszama} - {m.Email}");
            }

            Console.ReadKey();
        }
    }
}
