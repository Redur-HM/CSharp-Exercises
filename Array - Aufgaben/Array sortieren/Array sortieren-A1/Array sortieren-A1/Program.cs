namespace Array_sortieren_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aufgabe 1:
           Legen Sie einen Array auf Basis von Ganz-Zahlen an. Der Array soll eine Größe von 10 haben
           Füllen sie den Array mit den Zahlen 0 bis 9 und geben Sie den Inhalt des Arrays auf dem Bildschirm aus
               a) Füllen sie den Array mit den Zahlen 1 bis 10 und 
                  geben Sie den Inhalt des Arrays auf dem Bildschirm aus
               b) Geben Sie den Inhalt des Arrays in umgekehrter Reihenfolge aus
               c) Füllen Sie den Array umgekehrt mit den Zahlen 10 bis 1 und 
                  geben Sie den Inhalt des Arrays auf dem Bildschirm aus
               d) Geben Sie das Ergebnis des Arrays in umgekehrter Reihenfolge aus
               e) Füllen Sie den Array mit Zufallszahlen zwischen 1 und 10 und geben Sie den Inhalt des Arrays aus.*/
            //Direkte Wertzuweisung
            int[] zahlen = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine(); //nur für den Zeilenumbruch nach der schleife
            //A
            for (int i = 0; i < 10; i++)
            {
                zahlen[i]++;
            }
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine();
            //B
            for (int i = 0; i < 10; i++)
            {
                zahlen[i] = 10 - i;
            }
            // oder einfacher Array.Reverse(zahlen);
            /* oder die shcon existierte Array rückwärts ausgeben.
            for (int i = 9; i >= 0; i--)
            Console.Write(zahlen[i] + " ");
            */
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine();
            //C
            int y = 10;
            //es ist möglich mehrer zähler in der for-schleife zu haben
            for (int i = 0; i < 10; i++, y--)
            {
                zahlen[i] = y;
                //y--;
            }
            foreach (int z in zahlen) Console.Write(z + " ");
            Console.WriteLine();
            /*oder
            for (int i = 0; i < 10; i++)
            {
                zahlen[i] = 10 - i;
            }
            */
            //D //Kopie von B
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(zahlen[i] + " ");
            }
            Console.WriteLine();
            //E
            //Random red = new Random();
            //nutzen wir hier andere Methode um Zufallszahlen zu generieren.
            for (int i = 0; i < 10; i++)
            {
                zahlen[i] = Random.Shared.Next(1, 10);
            }
            foreach (int z in zahlen) Console.Write(z + " ");
        }
    }
}
