using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Ha két névtér ütközik, akkor meg lehet
//rövidítéssel oldani.
using Task1 = System.Threading.Tasks;
using Task2 = System.Threading.Tasks.Parallel;

//Így hivatkozunk: Task1.Akarmi
//Task2.MasikAkarmi

//névterek

//System ------- Linq
//        |
//         ----- Text
//        |
//         ----- Threading
//        |    |
//        |     - Tasks
//        |
//         ----- Collections
//            |
//             - Generic


namespace _07Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            //kérdés
            //bujocska();
            bujocska2();

            //nem elegáns
            //hanyEvesAKapitanyElolTesztelo();

            //elegánssabb (egy kicsit talán)
            //hanyEvesAKapitanyHatulTesztelo();

            Console.ReadLine();
            //A Convert.ToInt32 és intTryPars között mi a különbség ?
            //pl:
            //var szam0 = Convert.ToInt32(valasz);
            //ehhez hasonlóan
            //int.Parse()

            //nem foglalkozik azzal, hogy a konverzió elvégezhető-e, hanem konvertál,
            //és ha nem megy, akkor a programunk futásidejű hibával megáll.

            //Így azért javítható, de ez sok kérdést felvet:
            //try
            //{
            //    var szam0 = Convert.ToInt32(valasz);
            //}
            //catch (Exception)
            //{ }

        }

        private static void hanyEvesAKapitanyHatulTesztelo()
        {
            Console.WriteLine("Hány éves a kapitány?");

            //nullázható integer
            int szam;

            //Ez egy összetett megoldás, visszaadja, hogy sikeres volt-e a
            //számmá alakítás, majd ha igen, akkor kimeneti változóval 
            //visszaadja az értéket
            bool sikeres;
            string valasz;
            //hátul tesztelő ciklus
            do
            { //ezt a kódblokkot ismételjük
                valasz = Console.ReadLine();
                sikeres = int.TryParse(valasz, out szam);
                if (!sikeres) { Console.WriteLine("Nem sikerült az átalakítás"); }
            } while (!sikeres); //Addig ismételjük, amíg nem sikerült az átalakítás

            Console.WriteLine("Sikerült számmá alakítani: {0}", szam);
        }

        private static void hanyEvesAKapitanyElolTesztelo()
        {
            Console.WriteLine("Hány éves a kapitány?");

            int szam;

            //Ez egy összetett megoldás, visszaadja, hogy sikeres volt-e a
            //számmá alakítás, majd ha igen, akkor kimeneti változóval 
            //visszaadja az értéket

            //Rossz megoldás, elöl tesztelő ciklus
            var valasz = Console.ReadLine();
            while (!int.TryParse(valasz, out szam)) //Addig ismételjük, amíg nem sikerült az átalakítás
            { //ezt a kódblokkot ismételjük
                Console.WriteLine("Nem sikerült az átalakítás");
                valasz = Console.ReadLine();
            }
            Console.WriteLine("Sikerült számmá alakítani: {0}", szam);

        }

        private static void bujocska()
        {
            Console.WriteLine("Bújócska");
            Console.WriteLine("Meddig számoljak el?");
            var szamlalo = Console.ReadLine();
            int szam;
            if (int.TryParse(szamlalo, out szam))
            {
                for (var szamlalok = 0; szamlalok < szam + 1; szamlalok++)
                {
                    //Mi van, ha szeretnék számolás közben várni
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(szamlalok);
                }
            }
            else
            {
                Console.WriteLine("Nem számot adtál meg!");
            }
        }

        private static void bujocska2()
        {
            Console.WriteLine("Bújócska");
            Console.WriteLine("Meddig számoljak el?");
            int szam;
            bool sikeres;
            string valasz;
            //hátul tesztelő ciklus
            do
            { //ezt a kódblokkot ismételjük
                valasz = Console.ReadLine();
                sikeres = int.TryParse(valasz, out szam);
                if (!sikeres) { Console.WriteLine("Nem sikerült az átalakítás"); }
            } while (!sikeres); //Addig ismételjük, amíg nem sikerült az átalakítás

            Visszaszamlalas(szam);
        }

        private static void Visszaszamlalas(int szam)
        {
            for (var szamlalok = 1; szamlalok < szam + 1; szamlalok++)
            {
                System.Threading.Thread.Sleep(1000); Console.WriteLine(szamlalok);
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Aki bújt, aki nem, megyek! :)");
        }

    }
}
