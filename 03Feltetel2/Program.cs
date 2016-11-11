using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Feltetel2
{
    class Program
    {
        static void Main(string[] args)
        {
            //A feladat a következő:
            //Kérdezzük meg a felhasználótól, hogy halat akar-e enni, vagy nem
            //ha igen-t mond, akkor jön a halas étel, 
            //ha nemet mond, akkor jön a pörkölt, és ha valami mást mond, akkor pedig
            //jön a sütemény

            //Kérdést mondunk
            Console.WriteLine("Szeretnél halas ételt enni?");

            //Értékadás működése
            //Három rész: egyenlőségjel baloldala, egyenlőségjel, egyenlőségjel jobboldala
            //a jobboldalon előállt értéket/adatot/információt a baloldalon lévő VÁLTOZÓBA teszi.
            var valasz = Console.ReadLine();

            if (valasz == "igen") //megnézzük, hogy igent mondott-e
            { //igent mondott, halas étel
                Console.WriteLine("Valami halas ételhez összetevők");
            }
            else
            {
                if (valasz == "nem") //megnézzük, nemet mondott-e?
                { //Ha nemet mondott, akkor pörkölt
                    Console.WriteLine("Marhahús");
                    Console.WriteLine("Vöröshagyma");
                    Console.WriteLine("Olaj");
                    Console.WriteLine("Pirospaprika");
                }
                else
                { //ha sem igen sem nem, akkor meg sütemény
                    Console.WriteLine("sütemény");
                }
            }
            Console.ReadLine();

            //A szintaktikára figyelni körülbelül azt jelenti, ment 
            //A királynőt megölni nem kell félnetek jó lesz
            //A királynőt megölni, nem kell félnetek, jó lesz
            //A királynőt megölni nem kell, félnetek jó lesz
            //A C#-ban a vesszők szerepét a kódblokkok veszik át.
        }
    }
}
