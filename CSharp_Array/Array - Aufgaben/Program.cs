using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Array___Aufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            /*Aufgabe 1:
            Erstellen Sie ein Programm, welches einen Array auf der Basis von integer in der Größe von 20 enthält.
            1) Füllen Sie den Array mit den Werten 0 - 19 und geben Sie die Werte aus
            2) Füllen Sie den Array mit den Werten 1 - 20 und geben Sie die Werte aus
            3) Füllen Sie den Array mit den Potenzen zur Basis 2 und geben Sie die Werte aus
            4) Füllen Sie den Array mit dem Quadrat der Werte und geben Sie die Werte aus
            5) Füllen Sie den Array mit Zufallswerten zwischen 1 und 20,
            sortieren Sie den Array in aufsteigender / absteigender Richtung und 
            geben Sie je die Werte aus
            6) Bestimmen Sie die Summe der Werte innerhalb Ihres Arrays*/
            Console.WriteLine("Hello, Erdmenschen!");
            //1)
            int[] Arr = new int[20];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i;
                Console.Write(Arr[i] + " ");
            }
            //2)
            Console.WriteLine("\n Aufgabe 2");
            for (int i = 1; i <= Arr.Length; i++)
            {
                Arr[i - 1] = i;
                Console.Write(Arr[i - 1] + " ");
            }
            /*oder 
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = i + 1;
                Console.Write(Arr[i] + " ");
            }
            */
            //3)
            int[] arr3 = new int[20];
            arr3 = Arr;
            Console.WriteLine("\n Aufgabe 3");
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = (int)Math.Pow(2, i);
                Console.Write(arr3[i] + " ");
            }
            //4)
            Console.WriteLine("\n Aufgabe 4");
            int[] arr4 = new int[20];
            for (int i = 1; i <= arr4.Length; i++)
            {
                arr4[i - 1] = i;
                //Console.Write(arr4[i - 1] + " ");
            }
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = (int)Math.Pow(arr4[i], 2);
                // oder arr4[i] = arr4[i] * arr4[i];
                Console.Write(arr4[i] + " ");
            }
            //5)
            //6)
            Console.WriteLine("\n Aufgabe 5 und 6");
            int[] arr5 = new int[20];
            Random red = new Random();
            int sum = 0;
            for(int i = 0; i< arr5.Length; i++)
            {
                arr5[i] = red.Next(1, 21);
                sum += arr5[i];
           }
            // Sortiert das Array in aufsteigender Reihenfolge (vom kleinsten zum größten Wert).
            Array.Sort(arr5);
            foreach (var i in arr5)
            {
                Console.Write(i + " ");
            }
            // Kehrt die Reihenfolge des Arrays um (vom größten zum kleinsten Wert).
            Array.Reverse(arr5);
            Console.WriteLine("\n");
            foreach ( int i in arr5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nDie Summe ist: {sum}");
            Console.ReadKey();
        }
    }
}