using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BujocskaCiklus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bujócska: a hunyónak el kell számolnia 1-től tízig

            //Ez egy (rossz) megoldás
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            //szamlalo++ rövidítés: azt jelenti hogy
            //szamlalo = szamlalo + 1;
            //vagyis a számlálo értékét megnöveli eggyel

            for (var szamlalo = 1; szamlalo < 101; szamlalo++)
            {
                //keressük azt az első számot, ami 19-cel megszorozva75-nél nagyobb
                if (szamlalo * 19 > 75)
                { //megvan a szám
                    //kiírjuk
                    Console.WriteLine(szamlalo);
                    //nem kell tovább számolni, kilépünk a ciklusból
                    break;
                }
                //A bujócskát "kifejlesztettük", kiveszem a programból
                //Console.WriteLine(szamlalo);
            }

            Console.ReadLine();
        }
    }
}
