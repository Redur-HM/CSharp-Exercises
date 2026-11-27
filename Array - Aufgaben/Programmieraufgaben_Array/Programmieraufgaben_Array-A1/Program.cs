namespace Programmieraufgaben_Array_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Array01 
            Entwickeln Sie ein Programm, um die Namen aller Teilnehmer Ihrer Klasse über die 
            Tastatur zu erfassen und in einem Array abzulegen. Anschließend sollen die Werte der 
            Liste am Monitor angezeigt werden.*/
            //Meine_lösung();
            Dozent();

            Console.ReadKey();
        }
        static void Meine_lösung()
        {
            Console.Write("Geben Sie die Anzahl der Teilnehmer ein:");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            string[] namen = new string[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"Geben Sie den Namen von dem {1 + i}. Teilnehmer ein:");
                namen[i] = Console.ReadLine();
            }//Ende for-Schleife
            Console.Write("Die Teilnehmer sind: ");
            for (int i = 0; i < anzahl; i++)
            {
                if (i == anzahl - 1)
                {
                    Console.Write(namen[i]);
                }
                else
                {
                    Console.Write(namen[i] + ", ");
                }
            }//Ende for-Schleife
        }//Ende Meine_lösung static
        static void Dozent()
        {
            Console.WriteLine("Wieviele Teilnehmer sind in der Klasse");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] klasse = new string[n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Gib einen Namen für Teilnehmer {i + 1} ein");
                klasse[i] = Console.ReadLine();
            }
            foreach (string s in klasse)
                Console.Write(s);
            //Varinate 2
            //bool sollWeiter = true;
            string[] klasse2 = new string[0];
            //while(sollWeiter)
            while (SollWeiter())
            {
                //Array.Resize(ref klasse2, klasse2.Length + 1);
                string[] temp = new string[klasse2.Length + 1];
                for (int i = 0; i < klasse2.Length; i++)
                    temp[i] = klasse2[i];
                klasse2 = temp;

                Console.WriteLine("Gib einen Namen ein");
                klasse2[klasse2.Length - 1] = Console.ReadLine();

                //    Console.WriteLine("Kommt da noch was?(j/n)");
                //    string key = Console.ReadLine();
                //    if (key.ToLower() == "n")
                //    {
                //        sollWeiter = false;
                //    }//Ende if>

            }//ende While
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
        }
    }
}
