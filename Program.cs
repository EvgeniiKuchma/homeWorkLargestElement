using System;

namespace homeWorkLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int rows = 10;
            int cols = 10;
            int minValue = 0;
            int maxValue = 11;
            int changeMaxElement = 0;
            int maxElement = int.MinValue;

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maxElement == array[i, j])
                    {
                        array[i, j] = changeMaxElement;
                    }
                }
            }

            Console.WriteLine($"\nmaxElement = {maxElement}");
            Console.WriteLine("\n");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
