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
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday) //megnézzük, hogy a mai nap péntek-e?
            { //Ha igen, a két oldal egyenlő, akkor van ez
                Console.WriteLine("Valami halas ételhez összetevők");
            }
            else
            { //Ha nem, akkor nem péntek van, akkor van ez

                IrdKiAPorkoltReceptet();

            } //Amennyiben kódblokk {} van benne, nem kell a kódblokk után pontosvesszű

            Console.ReadLine();
        }

        private static void IrdKiAPorkoltReceptet()
        {
            Console.WriteLine("Marhahús");
            Console.WriteLine("Vöröshagyma");
            Console.WriteLine("Olaj");
            Console.WriteLine("Pirospaprika");
        }
    }
}
