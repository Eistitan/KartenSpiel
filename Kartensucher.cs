using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    internal class Kartensucher
    {
        public static void Suchen()
        {
            List<int> zahlen = Kartenmischer.Mischer(); //Liste zahlen wird mit der Methode Mischer erstellt.
            int GesZahl = Kartenmischer.GeschuchteZahl(zahlen); //Parameter zahlen wird an die Methode GesuchteZahl() weitergegeben.
            //Console.WriteLine("AAA Die Gesuchte Zahl sei " + GesZahl);

            int Listenlaenge = zahlen.Count();
            int MinZahlWert;
            int MaxZahlWert;
            int MidZahlWert;
            bool rotator = true;

            int min=0;  //Minimaler IndexWert
            int max = (Listenlaenge-1); //Maximaler IndexWert
            int mid; //Mitte zw min und max
            int I = 1;


            while (rotator == true)
            {
                mid = (min + max) / 2;
                MinZahlWert = zahlen[min];     //Kartenwert bei Min
                MaxZahlWert = zahlen[max];     //Kartenwert bei Max
                MidZahlWert = zahlen[mid];     //Kartenwert bei Mid
                if (MinZahlWert == GesZahl ||MaxZahlWert == GesZahl || MidZahlWert == GesZahl)
                {
                    I++;
                    Vergleiche.Match(GesZahl,MinZahlWert,MaxZahlWert,MidZahlWert, I, mid, max, min); //Position fehlt, die Liste muss weitergegeben werden
                    rotator = false;
                }
                else if (MidZahlWert < GesZahl)
                {
                    I++;
                    min = (1 + mid);
                    max = (max - 1);
                    rotator = true;
                }
                else //derWert>GesZahl
                {
                    I++;
                    min = (1 + min);
                    max = (mid - 1);
                    rotator = true;
                };
            }
        }
       
    }
}
