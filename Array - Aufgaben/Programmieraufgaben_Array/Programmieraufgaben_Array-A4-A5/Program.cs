using System.ComponentModel;

namespace Programmieraufgaben_Array_A4_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Array04
            Erstellen Sie ein Programm „Hang-Man“: Ein Wort wird in einem Array gespeichert, 
            welches der Computer zufällig generiert. Hier können sie ein Array aus Beispielwörtern 
            erstellen, woraus der Computer eine zufällige Wahl trifft. Der Nutzer gibt nun einen 
            Buchstaben ein. Nach jeder Eingabe wird der Rateerfolg angezeigt. 
            Beispiel: 
            Eingabe: a -a-- 
            Eingabe: u -au- 
            Eingabe: s -aus 
            Eingabe: m maus 
            */
            //Aufgabe04_Mein_HangMan();
            DozentAufgabe04();

        }
        static void Aufgabe04_Mein_HangMan()
        {


            // Schritt 1: Wortauswahl und Vorbereitung

            string[] worte = { "mensch", "computer", "auto", "hand", "kollege", "rot", "tag" };

            int zufall = new Random().Next(0, worte.Length);
            string wort = worte[zufall];

            Console.WriteLine($"Das gesuchte Wort besteht aus {wort.Length} Buchstaben.");

            char[] chars = wort.ToCharArray();
            char[] rat = new char[chars.Length];

            Arrayausgabe(rat);

            // Schritt 2: Anzahl der Versuche

            int versuche = wort.Length * 2;
            Console.WriteLine($"Sie haben {versuche} Versuche.");

            // Schritt 3: Buchstabeneingabe vorbereiten

            bool gewonnen = false;

            // Schritt 6 und 7: Wiederholung und Abbruchbedingung

            do
            {
                Console.Write("Gib einen Buchstaben zum Erraten ein: ");
                char buchstabe = Convert.ToChar(Console.ReadLine().ToLower()[0]);

                // Schritt 4: Buchstaben überprüfen

                for (int j = 0; j < chars.Length; j++)
                {
                    if (buchstabe == chars[j])
                    {
                        rat[j] = buchstabe;
                    }
                        
                    for(int k = 0; k < rat.Length; k++)
                    {
                        if (rat[k] == '_')
                        {
                            stop = false;
                            break;
                        }
                    }
                    if (stop)// muss noch Weiter schreiben.
                    {
                            
                    }


                }

                // Schritt 5: Ergebnis anzeigen

                Arrayausgabe(rat);

            }
            while (!gewonnen && versuche > 0);
        }        

        static void Arrayausgabe(char[] a)
        {
            foreach (var z in a)
            {
                Console.Write(z + " ");
            }
            Console.WriteLine();
        }

        
        static void DozentAufgabe04(char [] a)
        {
            foreach (var z in a)
            {
                Console.Write(z + " ");
            }
                
        
        }
    }
}
