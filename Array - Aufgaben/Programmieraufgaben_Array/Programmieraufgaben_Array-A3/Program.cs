namespace Programmieraufgaben_Array_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Array03
            Schreiben Sie ein Programm, das Duplikate aus einem Array entfernt und ein neues 
            Array ohne Duplikate erstellt.
            */
            Mein();
        }
        static void Mein()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 6, 7 };
            int[] neuarray = new int[array.Length];
            int test = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < index; j++)
                //Die innere Schleife funktioniert beim ersten Durchlauf
                //nicht, da das neue Array noch keine Elemente enthält.
                {
                    if (array[i] == neuarray[j])
                    {
                        test = 1;
                        break;
                    }
                }
                if (test != 1)
                {
                    neuarray[index] = array[i];
                    index++;
                }
            }
            Console.WriteLine();
            foreach( int z in neuarray)
            {
                Console.WriteLine(z);
            }
            Console.ReadLine();
        }
    }
}
