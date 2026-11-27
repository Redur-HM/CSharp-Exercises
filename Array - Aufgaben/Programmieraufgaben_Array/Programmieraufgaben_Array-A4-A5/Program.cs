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
                            //stop = false;
                            break;
                        }
                    }
                    //if (stop)// muss noch Weiter schreiben.
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

        
        static void DozentAufgabe04()
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "ä", "ö", "ü" };
            string gesucht = "Bahnhof";
            char[] gefunden = new char[gesucht.Length];
            for (int i = 0; i < gefunden.Length; i++)
            {
                gefunden[i] = '_';
            }
            bool isEnde = false;
            int versuche = 11;
            while (!isEnde)
            {
                versuche--;
                Console.Clear();
                Console.WriteLine(gefunden);
                Console.WriteLine($"Verbleibende Versuche: {versuche}");
                Console.WriteLine($"Gib einen Buchstaben ein: ");
                char buchstabe = Console.ReadLine()[0];
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == buchstabe.ToString().ToLower())
                    {
                        alphabet[i] = "";
                    }
                }
                for (int i = 0; i < gesucht.Length; i++)
                {
                    if (gesucht[i] == buchstabe)
                    {
                        gefunden[i] = gesucht[i];
                        versuche++;
                    }
                }

                if (isEqual(new string(gefunden), gesucht))
                {
                    isEnde = true;
                }
                else if (versuche < 1)
                {
                    isEnde = true;
                }
            }//Game
            Console.WriteLine("Ende: " + gesucht);

        }
        static bool SollWeiter()
        {
            Console.WriteLine("Kommt da noch was?(j/n)");
            string key = Console.ReadLine();
            if (key.ToLower() == "n")
            {
                return false;
            }//Ende if
            return true;
        }
        static bool isEqual(string a, string b)
        {
            if (a.Length == b.Length)
                for (int i = 0; i < a.Length; i++)
                    if (a[i] != b[i])
                        return false;

            return true;
        }
    }
}
