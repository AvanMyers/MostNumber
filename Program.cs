using System;

namespace MostElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minNumber = 1;
            int maxNumber = 10;
            int numberChange = 0;

            Random random = new Random();

            int[,] array = new int[10, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minNumber, maxNumber);
                    Console.Write(array[i, j] + " ");

                    if (array[i, j] > numberChange)
                        numberChange = array[i, j];
                }

                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент в матрице {numberChange}\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == numberChange)
                        array[i, j] = 0;

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
