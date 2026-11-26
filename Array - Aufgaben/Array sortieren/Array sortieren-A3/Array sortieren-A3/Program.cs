namespace Array_sortieren_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Aufgabe 3
            Entwickeln Sie ein Programm welches folgende Struktur: 
            array of integer/int[] = {5,4,3,2,1,9,8,7,6,0}; zunächst erzeugt und danach modifiziert! 
            a) Die Modifikation tauscht genau dann zwei aufeinanderfolgende Zahlen miteinander aus,
            wenn die nachfolgende Zahl kleiner als die vorherige ist. 
            z.B. 5,4 soll zu 4,5 werden - jedoch 1,9 bleibt bestehen, da 1 kleiner als 9 ist!
            b) Lösen Sie evtl. auftretende „Phänomene“, welche durch Überschreiten der Array-Grenzen auftreten.
            Scheuen Sie nicht davor zurück jeden einzelnen Schritt auf einem Zettel zu notieren.
            Geben Sie Ihr Ergebnis auf dem Bildschirm aus
            c) Wenn das Programm einwandfrei läuft, lassen Sie Ihre Routine aus a) und b) genau 10 Mal 
            hintereinander laufen (in einer Zählschleife) und betrachten Sie Ihr Ergebnis. 
            d) Schreiben Sie Ihr Programm so um, sodaß diesmal die Zahlen getauscht werden, 
            wenn die zweite Zahl größer als die erste ist. Also: 5,4 bleibt bestehen - jedoch 1,9 wird zu 9,1
            e) Lassen Sie auch diese Routine 10x durch eine Zählschleife iterieren. Wie lautet Ihr Ergebnis?
            f) Kommentieren Sie Ihren bislang geschriebenen Source-Code aus und entwickeln Sie, 
            auf Basis Ihres vorangegangenen, ein Programm, welches die Zeichenkette:”Mohrhuhn4Ever” ähnlich 
            wie in Teilaufgabe a), b) und c) behandelt. Wie sieht Ihr Ergebnis aus?
            */
            int[] zahlen = { 5, 4, 3, 2, 1, 9, 8, 7, 6, 0 };
            //a)
            int[] zahlA = { 5, 4, 3, 2, 1, 9, 8, 7, 6, 0 };

            for (int i = 0; i < zahlA.Length - 1; i++)
            {
                if (zahlA[i + 1] < zahlA[i])
                {
                    int temp = zahlA[i];
                    zahlA[i] = zahlA[i + 1];
                    zahlA[i + 1] = temp;
                    //(zahlA[i + 1], zahlA[i])=(zahlA[i], zahlA   [i + 1]);
                }
            }
            foreach (var z in zahlA) Console.Write(z + " ");
            Console.WriteLine();
            //b) durch diese Frage könnte ich die a) richtig lösen.
            //c)
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < zahlA.Length - 1; i++)
                {
                    if (zahlA[i + 1] < zahlA[i])
                    {
                        (zahlA[i + 1], zahlA[i]) = (zahlA[i], zahlA[i + 1]);
                    }
                }
            }
            foreach (var z in zahlA) Console.Write(z + " ");
            Console.WriteLine();

            //d)
            for (int i = 0; i < zahlen.Length - 1; i++)
            {
                if (zahlen[i + 1] > zahlen[i])
                {
                    (zahlen[i], zahlen[i + 1]) = (zahlen[i + 1], zahlen[i]);
                }
            }
            foreach (var z in zahlen) Console.Write(z + " ");
            Console.WriteLine();
            //e)
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < zahlen.Length - 1; i++)
                {
                    if (zahlen[i + 1] > zahlen[i])
                    {
                        (zahlen[i], zahlen[i + 1]) = (zahlen[i + 1], zahlen[i]);
                    }
                }
            }
            foreach (var z in zahlen) Console.Write(z + " ");
            Console.WriteLine();
            // Das Ergebnis ist unverändert.
            //f)
            string text = "Mohrhuhn4Ever";
            char[] red = text.ToCharArray();
            for (int i = 0; i < red.Length - 1; i++)
            {
                if (red[i] > red[i + 1])
                {
                    (red[i + 1], red[i]) = (red[i], red[i + 1]);
                }
            }
            foreach (var z in red) Console.Write(z);
            //Console.WriteLine(new string(red));
            Console.WriteLine();

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < red.Length - 1; i++)
                {
                    if (red[i] > red[i + 1])
                    {
                        (red[i + 1], red[i]) = (red[i], red[i + 1]);
                    }
                }
            }
            foreach (var z in red) Console.Write(z);
            Console.WriteLine();

            char[] red2 = text.ToCharArray();
            for (int i = 0; i < red2.Length - 1; i++)
            {
                if (red2[i] < red2[i + 1])
                {
                    (red2[i + 1], red2[i]) = (red2[i], red2[i + 1]);
                }
            }
            foreach (var z in red2) Console.Write(z);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
