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
            //Aufgabe03_Mein();
            //
            DozentA3();
        }
        static void Aufgabe03_Mein()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 6, 0, 7 ,  3};
            int[] neuarray = new int[array.Length];
            int test;
            int index = 0;
            int zaehler = 0;
            for (int i = 0; i < array.Length; i++)
            {
                test = 0;
                for (int j = 0; j < index; j++)
                //Die innere Schleife funktioniert beim ersten Durchlauf
                //nicht, da das neue Array noch keine Elemente enthält.
                {
                    if (array[i] == neuarray[j])
                    {
                        test = 1;
                        zaehler++;
                        break;
                    }
                }

                if (test == 0)
                {
                    neuarray[index] = array[i];
                    index++;
                }
            }
            Array.Resize(ref neuarray, neuarray.Length - zaehler);
            //Die Größe des neuen Arrays wird um die Anzahl der Duplikate verkleinert.
            //Array.Resize(ref neuarray, index); Index ist die Anzahl der eindeutigen Elemente,
            //die in das neue Array kopiert wurden.
            Console.WriteLine();
            foreach( int z in neuarray)
            {
                Console.WriteLine(z);
            }
            Console.ReadLine();
        }
        static void DozentA3()
        {
            //nicht ganz gute Lösung.
            int[] zahlen = { 0, 9, 2, 3, 5, 7, 8, 9, 8, 7, 5, 6, 2, 4, 9, 6 };
            int doppelte = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                int t = zahlen[i];
                for (int y = 0; y < i; y++)
                {
                    if (t == zahlen[y])
                    {
                        doppelte++;
                        break;//damit eine doppelte nicht mehrfach gezählt wird
                    }
                }
            }
            int[] tempZ = new int[zahlen.Length - doppelte];
            for (int i = 0; i < tempZ.Length; i++)
            {
                for (int y = 0; y < zahlen.Length; y++)
                {
                    bool isVorhanden = false;
                    for (int j = 0; j <= i; j++)
                    {
                        if (zahlen[y] == tempZ[j])
                        {
                            isVorhanden = true;
                        }
                    }
                    if (!isVorhanden)
                    {
                        tempZ[i] = zahlen[y];
                    }
                }

            }//ende temp belegen
            foreach (int z in tempZ)
                Console.Write(z + " ");

        }
    }
}
