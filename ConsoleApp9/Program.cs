
using System;

namespace programming
{
    class DeleteAnArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tastati limita vectorului");
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            int aux = 0;

            Console.WriteLine("Introduce ti numerele in vector");

            for (int i = 0; i < number; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tastati pozitia pe care o doriti sa o eliminati ");

            int pozitie = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numarul tastat de catre utilizator este{pozitie} ");

            for (int i = pozitie - 1; i < number - 1; i++)
            {
                aux = array[i];
                array[i] = array[i + 1];
                array[i + 1] = aux;

            }
            number--;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
