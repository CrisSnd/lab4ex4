using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti o functie recursiva care va afisa in ordine elementele unui vector de intregi .*/



            Console.WriteLine("Introduceti lungimea vectorului: ");
            int lungimeVector = int.Parse(Console.ReadLine());

            int[] vector = new int[lungimeVector];

            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < lungimeVector; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            AfisareVector(vector, lungimeVector - 1);

        }



        static void AfisareVector(int[] v, int i)
        {
            if (i < -1)
            {
                return;
            }
            AfisareVector(v, i-1);
            Console.WriteLine(v[i]);
        }
    }
}        


