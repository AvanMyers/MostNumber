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

            int[,] numberArray = new int[10, 10];

            for (int i = 0; i < numberArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberArray.GetLength(1); j++)
                {
                    numberArray[i, j] = random.Next(minRandomNumber, maxRandomNumber);
                    Console.Write(numberArray[i, j] + " ");

                    if (numberArray[i, j] > mostNumberChange)
                        mostNumberChange = numberArray[i, j];
                }

                Console.WriteLine("");
            }

            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент в матрице {mostNumberChange}\n");

            for (int i = 0; i < numberArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberArray.GetLength(1); j++)
                {
                    if (numberArray[i, j] == mostNumberChange)
                        numberArray[i, j] = replaceNumber;

                    Console.Write(numberArray[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
