using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    internal class Vergleiche
    {
        public static void Match(int GZahl, int MnZahl, int MxZahl, int MdZahl, int Zaehler, int InMd, int InMx, int InMn)
        {
            //switch (switch_on)      //???
            //{
            //    default:
            //}
            if (MnZahl == GZahl)
            {
                Console.WriteLine("");
                Console.WriteLine("Die Gesuchte Zahl war " + MnZahl);
                Console.WriteLine($"Der Index der Zahl war {(InMn+1)}. Gefunden am Minimum-Wert.");
                Console.WriteLine("Anzahl der Schritte  " + Zaehler);
                //return false;
            }
            else if (MxZahl == GZahl)
            {
                Console.WriteLine("");
                Console.WriteLine("Die Gesuchte Zahl war " + MxZahl);
                Console.WriteLine($"Der Index der Zahl war {(InMx+1)}. Gefunden am Maximum-Wert.");
                Console.WriteLine("Anzahl der Schritte  " + Zaehler);
                //return false;
            }
            else if (MdZahl == GZahl)
            {
                Console.WriteLine("");
                Console.WriteLine("Die Gesuchte Zahl war " + MdZahl);
                Console.WriteLine($"Der Index der Zahl war {(InMd + 1)}. Gefunden am Mitte-Wert.");
                Console.WriteLine("Anzahl der Schritte  " + Zaehler);
                //return false;
            }
            
        }
        public static bool Kleiner(int min, int max, int mid) //Problem - mehrere Werte zurückgeben
        {
            min = (1 + mid);
            max = (max - 1);
            
            return true;
        }
        public static bool Groesser()                   //Problem identisch
        {

            return true;
        }
    }
}
