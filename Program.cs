using System;

namespace MostElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minRandomNumber = -10;
            int maxRandomNumber = 10;
            int mostNumberChange = int.MinValue;
            int replaceNumber = 0;

            Random random = new Random();

            int[,] numbers = new int[10, 10];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minRandomNumber, maxRandomNumber);
                    Console.Write(numbers[i, j] + " ");

                    if (numbers[i, j] > mostNumberChange)
                        mostNumberChange = numbers[i, j];
                }

                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент в матрице {mostNumberChange}\n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] == mostNumberChange)
                        numbers[i, j] = replaceNumber;

                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
