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
        static void BeolvRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                Console.WriteLine(sor[0]);
                //sor[0] -> kód
                //sor[1] -> név
                //sor[2] -> Ár
                //sor[3] -> Db
                //Console.WriteLine(raktar.ReadLine());
            }
            raktar.Close();
        }

        static void Main(string[] args)
        {
            BeolvRaktar();

            Console.ReadKey();
        }
    }
}
