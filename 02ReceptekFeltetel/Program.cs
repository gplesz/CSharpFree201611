using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ReceptekFeltetel
{
    class Program
    {
        static void Main(string[] args)
        {
            //A dupla perjel a megjegyzés jele a C#-ban, ez után a sor
            //végéig a fordító nem foglalkozik a beírtakkal
            //Feladat
            //Készítünk egy bevásárlólistát az inasunknak.

            //Péntekenként friss tengeri hal érkezik a piacra
            //ezért a feladat úgy módosul, hogy ha péntek van, akkor halas
            //egyébként pörkölt.

            // Ha (valamilyen feltétel igaz) akkor {csináld ezt} különben {csináld ezt}

            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday) //megnézzük, hogy a mai nap péntek-e?
            { //Ha igen, a két oldal egyenlő, akkor van ez
                Console.WriteLine("Valami halas ételhez összetevők");
            }
            else
            { //Ha nem, akkor nem péntek van, akkor van ez
                Console.WriteLine("Marhahús");
                Console.WriteLine("Vöröshagyma");
                Console.WriteLine("Olaj");
                Console.WriteLine("Pirospaprika");
            } //Amennyiben kódblokk {} van benne, nem kell a kódblokk után pontosvesszű

            Console.ReadLine();
        }
    }
}
