using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Deklaráljuk a változókat
            //string szoveg;
            //string szoveg2;
            //int szamlalo;
            //DateTime most;

            ////Értéket adunk neki
            //szoveg = "szoveg";
            //szoveg2 = Console.ReadLine();
            //szamlalo = 1;
            //most = DateTime.Now;

            //Egyszerre csináljuk a kettőt
            //string szoveg = "szoveg";
            //string szoveg2 = Console.ReadLine();
            //int szamlalo = 1;
            //DateTime most = DateTime.Now;

            //szigorúan típusos nyelv
            //vagyis, amikor értékadás történik, akkor előtte a fordító ellenőrzi
            //a két oldal típusát, és ha nem azonosík, akkor FORDÍTÁSI hibát ad.
            //Ezért ilyet nem lehet leírni, mert a fordító elkapja:
            //szoveg = 1;
            //szoveg = DateTime.Now;

            //Továbbfejlesztett speciális C#
            //A szigorú típusosság megmarad, de
            //a fordítás során a fordító megállapítja minden 
            //értékadásnál, hogy jobb oldalon milyen típusú érték képződik
            //majd olyan típusú változót deklarál
            var szoveg = "szoveg";
            var szoveg2 = Console.ReadLine();
            var szamlalo = 1;
            var most = DateTime.Now;
            //innentől kezdve a változó típusa fixálódott!!

            //Ezért ezeket a fordító ugyanúgy kiszűri
            //nem lehet ilyet írni a programba
            //szoveg = 1;
            //szoveg = DateTime.Now;

            //milyen típusok léteznek: 
            //https://msdn.microsoft.com/en-us/library/ms173104.aspx
            //Szám típusok
            var egeszSzam = 1;
            //nem egész szám például
            var tizedesTort = 1.0;

            //szöveg típus
            var szovegTipus = "Mindenféle szöveget bele lehet írni";

            //logikai: igaz: true hamis: false
            var ezVajonIgaz = 28 > 3;


        }

    }
}
