namespace Array_sortieren_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Aufgabe 2:
            Belegen Sie ein Array der Größe 6 mit Zufallszahlen zwischen 1 und 6. 
            a) Ermitteln Sie die Summe der Zahlen im Array und geben Sie diese auf den Bildschirm aus
            b) Ermitteln Sie den Mittelwert und geben Sie diesen auf den Bildschirm aus
            c) Ermitteln Sie die kleinste Zahl im Array und geben Sie dies auf den Bildschirm aus
            d) Ermitteln Sie die größte Zahl und geben Sie dies auf den Bildschirm aus
            */
            int[] zahlen = new int[6];
            for (int i = 0; i < 6; i++)
            {
                zahlen[i] = Random.Shared.Next(1, 7);
                Thread.Sleep(5); // pausiert das Programm für 5 Millisekunden,
                                 // damit die Zufallszahlen nicht gleich sind
                Console.Write(zahlen[i] + " ");
            }
            Console.WriteLine();
            //a)
            int sum = 0;
            foreach (var z in zahlen)
            { sum += z; }
            Console.WriteLine("Summe: " + sum);
            //b)
            float mittelwert = (float)sum / zahlen.Length;
            Console.WriteLine($"Mittelwert: {mittelwert:F2}");
            ///Kurze Version: Console.WriteLine(zahlen.Average());

            //c)
            int kleinste = zahlen[0];
            foreach (var z in zahlen)
            {
                if (z < kleinste)
                    kleinste = z;
                //kleinste = z < kleinste ? z : kleinste;
                // z < kleinste ist eine Bedingung. z wird genommen, wenn True.
                // grossste wird genommen, wenn False.
            }
            //Kurze Version: int kleinste = zahlen.Min();
            Console.WriteLine("Kleinste Zahl: " + kleinste);
            //d)
            int groesste = zahlen[0];
            for (int z = 1; z < zahlen.Length; z++)
            {
                if (groesste < zahlen[z])
                    groesste = zahlen[z];
            }
            Console.WriteLine("Größte Zahl: " + groesste);
            //Kurze Version: int groesste = zahlen.Max();
        }
    }
}
