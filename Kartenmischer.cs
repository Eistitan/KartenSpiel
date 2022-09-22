using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    internal class Kartenmischer
    {
        public static List<int> Mischer()
        {
            //Console.WriteLine(abcdef);
            List<int> Karten = new List<int>();
            Console.WriteLine("Wie viele Karten sollen untersucht werden?");
            int AnzahlderKarten= int.Parse(Console.ReadLine());

            //Console.WriteLine(AnzahlderKarten);

            Console.WriteLine("Die Streueng als eine Zahl angeben. Der Wert gilt für die positive und die negative Streung.");
            int StrWert = int.Parse(Console.ReadLine());
            int StrWert2 = StrWert * -1;

            Console.WriteLine($"Die Streung der Werte liegt zwischen {StrWert} und {StrWert2}");
            Random random = new Random();
           
            //Die Streung muss größer als die Kartenanzahl sein.
            //Random sollte keine Zahl doppelt ausspucken. Wie?
            
            //int TestZahl = random.Next(StrWert2,StrWert);  //Min und Max beachten

            //Console.WriteLine(TestZahl);
            for (int i = 0; i < AnzahlderKarten; i++)
            {
                Karten.Add (random.Next(StrWert2, StrWert));
            }
            Karten.Sort();
            

            foreach (var item in Karten)
            {
                Console.WriteLine($"Die Karte {item}. ");
                
            }
                      
            return Karten;
            
           
        }
        public static int GeschuchteZahl(List<int> Karten) //Methode nimmt eine Liste als Variable an.
        {
           
            Random random = new Random();
            int Listenlaenge = Karten.Count;
            int IndexRotator = random.Next(0, Listenlaenge);
            Console.WriteLine("Index der GesZahl sei 1+ " + IndexRotator); //Index um 1 verschoben, da die Liste fängt bei 0 an.
            int GesZahl = Karten[IndexRotator];
            Console.WriteLine("Die Gesuchte Zahl sei " + GesZahl);

            return GesZahl;
        }


    }
}
