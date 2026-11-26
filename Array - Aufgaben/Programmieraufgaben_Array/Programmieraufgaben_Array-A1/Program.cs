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
            Console.Write("Geben Sie die Anzahl der Teilnehmer ein:");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            string[] namen = new string[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"Geben Sie den Namen von dem {1 + i}. Teilnehmer ein:");
                namen[i] = Console.ReadLine();
            }
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
            }


            Console.ReadKey();
        }
    }
}
