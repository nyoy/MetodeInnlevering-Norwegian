using System;

namespace MetodeInnlevering
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mineTall = new int[7];
            int i;
            Console.Write("Innlevering - Metoder");
            Console.Write("\n\nRead og Print elementer av en array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input elementene i et array :\n");
            for (i = 0; i < mineTall.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                mineTall[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElementene i arrayet er: ");
            for (i = 0; i < mineTall.Length; i++)
            {
                Console.Write("{0}  ", mineTall[i]);
            }

            Console.Write("\nGjennomsnitt av elementene er: ");
            {
                Console.Write("{0}  ", gjennomsnittavarray(mineTall));
            }

            Console.Write("\nSiste tre elementene i arrayet er: ");
            {
                sisteelementer(mineTall);
            }

            Console.Write("\nMedian av array er: ");
            {
                
                beregnmedian(mineTall);
            }
            
            Console.Write("\nSum av 3 midterste elementer er: ");
            {
                sumavmidten(mineTall);
            }

            Console.Write("\n\nTrykk enter for å avslutte");

            Console.ReadLine();
        }
        /*///////////////////////METODER////////////////////////*/
        
        //Beregning av gjennomsnitt///////////////////////////////
        public static int gjennomsnittavarray(int[] array)
        {
            int avg = 0;
            foreach (var i in array)
            {
                //avg += item / array.Length;
                avg = avg+ i / array.Length;
            }
            return avg;
        }
        //Finne siste 3 elementer//////////////////////////////////
        public static void sisteelementer(int[] array)
        {
           var tresiste = array[^3..];
            foreach (var item in tresiste)
            {
                Console.Write("{0}  ", item);
            }
        }
        //Finner  Median/////////////////
        public static void beregnmedian(int[] array) 
        {
            int n = array.Length;

            Array.Sort(array);

            if (n % 2 != 0) //sjekker for dobble tall
                Console.Write("{0}  ", (double)array[n / 2]);
            else

            Console.Write("{0}  ",(double)(array[(n - 1) / 2] + array[n / 2]) / 2.0);
        }

        public static void sumavmidten(int[] array)
        {

            int leftmidten = array[array.Length / 2 - 1];
            int midten = array[array.Length / 2];
            int rightmidten = array[array.Length / 2 + 1];

            Console.Write("{0}  ", leftmidten + midten + rightmidten);

        }
    }
}
