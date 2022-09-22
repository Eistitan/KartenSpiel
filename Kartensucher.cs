using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    internal class Kartensucher
    {
        //Zugriff auf die Liste Karten und die gesuchte Zahl
        public static void Suchen()
        {
            List<int> zahlen = Kartenmischer.Mischer(); //Liste zahlen wird mit der Methode Mischer erstellt.
            int GesZahl = Kartenmischer.GeschuchteZahl(zahlen); //Parameter zahlen wird an die Methode GesuchteZahl() weitergegeben.
            //Console.WriteLine("AAA Die Gesuchte Zahl sei " + GesZahl);

            int Listenlaenge= zahlen.Count();
            Console.WriteLine("AAADie Länge der Liste sei "+ Listenlaenge);
            
            //einDrittel = Listenlaenge / 3;
            int ZahlWert;
            bool rotator = true;
            
            //Console.WriteLine("Ein Drittel sei " + IndexeinDrittel);
            int IndexeinDrittel;
            int Laenge = Listenlaenge;
            int NeueLaenge;
            IndexeinDrittel = Laenge / 3;      //Position bei 1/3
            int I = 1;


            while (rotator==true)
            {                
                ZahlWert = zahlen[IndexeinDrittel];       //Kartenwert
                if (ZahlWert==GesZahl)
                {
                    Console.WriteLine("Die Gesuchte Zahl war "+ ZahlWert);
                    Console.WriteLine("Der Index war 1+ "+ IndexeinDrittel);
                    Console.WriteLine("Anzahl der Schritte  "+ I);
                    rotator = false;
                }
                else if(ZahlWert<GesZahl)   
                {
                    NeueLaenge = Laenge - IndexeinDrittel;
                    Console.WriteLine("Neue Listenlänge ist "+NeueLaenge);
                    Console.WriteLine("");
                    IndexeinDrittel =(IndexeinDrittel + NeueLaenge / 3);
                    I++;
                    rotator = true;
                }
                else //derWert>GesZahl
                {   NeueLaenge = IndexeinDrittel;
                    Console.WriteLine("Neue Listenlänge ist " + NeueLaenge);
                    Console.WriteLine("");
                    IndexeinDrittel= ( NeueLaenge / 3);

                    I++;
                    rotator = true;
                };
            }
        }
    }
}
