using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Több paraméter átadása
            //IrdKiANapnakMegfeleloReceptet(DateTime.Now.DayOfWeek, "egy átadott szoveg", 13);
            IrdKiANapnakMegfeleloReceptet(DateTime.Now.DayOfWeek);
            Console.WriteLine();
            IrdKiANapnakMegfeleloReceptet(DayOfWeek.Monday);
            Console.WriteLine();
            IrdKiANapnakMegfeleloReceptet(DayOfWeek.Tuesday);
            Console.WriteLine();
            //nem kell átvenni a paramétereket, csak, ha felhasználjuk 
            var ezJottVissza = IrdKiANapnakMegfeleloReceptet(DayOfWeek.Wednesday);
            Console.WriteLine();
            Console.WriteLine(ezJottVissza);
            Console.WriteLine();

            //Vagy akár  köztes változó nélkül is használható a dolog, ami kijön
            //az egyik függvényből, az egyből bemegy a másikba.
            Console.WriteLine(IrdKiANapnakMegfeleloReceptet(DayOfWeek.Wednesday));

            Console.ReadLine();
        }

        //több paraméter átvétele, nem ad vissza értéket
        //private static void IrdKiANapnakMegfeleloReceptet(DayOfWeek melyikNapAHetbol, string szoveg, int szam)

        //Ha pedig ad vissza értéket, akkor kell a típus, jelen esetben a string a függvény 
        //neve elé
        private static string IrdKiANapnakMegfeleloReceptet(DayOfWeek melyikNapAHetbol)
        {
            if (melyikNapAHetbol == DayOfWeek.Friday) //megnézzük, hogy a mai nap péntek-e?
            { //Ha igen, a két oldal egyenlő, akkor van ez
                Console.WriteLine("Valami halas ételhez összetevők");
            }
            else
            { //Ha nem, akkor nem péntek van, akkor van ez

                Console.WriteLine("Marhahús");
                Console.WriteLine("Vöröshagyma");
                Console.WriteLine("Olaj");
                Console.WriteLine("Pirospaprika");

            }

            var eredmeny = "Ezt adom vissza";

            //Így tudunk értéket visszaadni
            return eredmeny;
        }
    }
}
