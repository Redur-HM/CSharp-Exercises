namespace Programmieraufgaben_Array_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Array02
            
            Entwickeln Sie ein Programm, das die Zeichen 'a' und 'A' in einem Array 'Text' zählt. 
            Natürlich müssen Sie das Array durch Tastatureingaben vorher entsprechend füllen. 
            Länge des Textes oder Arrays mit: .Length 
            Sie können auch ein String statt eines Arrays nutzen 
            (Ein String ist ein Array aus Chars) 
            Erweiterung: 
            Lassen Sie den Nutzer entscheiden, welche Buchstaben gesucht werden sollen 
            */
            //Mein();
            //Variant02();
            Dozent();

        }
        static void Mein()
        {
            Console.Write("Geben Sie einen Text ein: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            char[] tarray = text.ToCharArray();
            Console.Write("Welchee Buchstabe wird gesucht? ");
            char buchstabe1 = Console.ReadLine()[0];
            // [0] greift auf das erste Zeichen des eingegebenen Strings zu.
            char buchstabe = char.ToLower(buchstabe1);
            int Zaehler = 0;
            for (int i = 0; i < tarray.Length; i++)
            {
                if (tarray[i] == buchstabe)
                {
                    Zaehler++;
                }
            }
            Console.WriteLine($"Die Buchstabe '{buchstabe1}' kommt {Zaehler} mal vor.");
        }
        static void Variant02()
        {
            Console.Write("Geben Sie einen Text ein: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            char[] tarray = text.ToCharArray();
            Console.Write("Welchee Buchstabe wird gesucht? ");
            char buchstabe1 = Console.ReadLine()[0];
            char buchstabe = char.ToLower(buchstabe1);
            int anzahl = tarray.Count(c=> c == buchstabe);
            Console.WriteLine($"Die Buchstabe '{buchstabe1}' kommt {anzahl} mal vor.");

        }
        static void Dozent()
        {
            Console.WriteLine("Text hier: ");
            string text = Console.ReadLine();
            int count = 0;
            foreach (char x in text)
                if (x == 'a' || x == 'A')
                    count++;
            Console.WriteLine(count);
        }
    }
}
