using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_1_Konstruktori
{
    internal class Program
    {
        // Deklaracija strukture
        struct Racionalan
        {
            public int brojilac;
            public int imenilac;

            // Konstruktor sa parametrima

            public Racionalan(int brojilac, int imenilac)
            {
                this.brojilac = brojilac;
                this.imenilac = imenilac;
            }
            // Metoda unutar strukture

            public void Ispisi()
            {
                Console.WriteLine($"{brojilac}/{imenilac}");
            }



        }

        static void Main(string[] args)
        {
            // 1.Podrazumevani konstruktor

            Racionalan r1 = new Racionalan();
            r1.brojilac = 1;
            r1.imenilac = 3;

            //2.Korisnicki konstruktor sa parametrima

            Racionalan r2 = new Racionalan(1, 2);

            //3.Inicijalizator objekta

            Racionalan r3 = new Racionalan
            {
                brojilac = 2,
                imenilac = 5
            };

            //4.Rucna inicijalizacija bez 'new'

            Racionalan r4;
            r4.brojilac = 3;
            r4.imenilac = 4;

            Console.WriteLine("Prikaz razlomaka: ");
            Console.Write("r1 = "); 
            r1.Ispisi();
            Console.Write("r2 = ");
            r2.Ispisi();
            Console.Write("r3 = ");
            r3.Ispisi();
            Console.Write("r4 = ");
            r4.Ispisi();

        }
    }
}
