using System;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Our array must have MxN size!");
            Console.Write("Input M, please: ");
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("You must enter integer, try again please!\nInput M, please: ");
            }
            int m = Convert.ToInt32(size);
            Console.Write("Input N, please: ");
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("You must enter integer, try again please!\nInput N, please: ");
            }
            int n = Convert.ToInt32(size);
            Console.WriteLine();
            short[,] array = GetRandomArray(m, n);
            Console.WriteLine("Array before sort:");
            PrintArray(array);
            Console.WriteLine();
            Sort(array);
            Console.WriteLine("Array after sort:");
            PrintArray(array);
            Console.ReadLine();
        }
        static short[,] GetRandomArray(int m, int n)
        {
            short[,] array = new short[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = (short)rnd.Next(-500, 500);
                }
            }
            return array;
        }

        static void PrintArray(short[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0, 4}  ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Sort(short[,] array)
        {
            int localMinPos = 0;
            int tempSum = 0;
            int tempSumMin;
            short tempValue;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempSumMin = int.MaxValue;
                for (int k = j; k < array.GetLength(1); k++)
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        tempSum += array[i, k];
                    }
                    if (tempSum < tempSumMin)
                    {
                        tempSumMin = tempSum;
                        localMinPos = k;
                    }
                    tempSum = 0;
                }
                if (localMinPos != j)
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        tempValue = array[i, j];
                        array[i, j] = array[i, localMinPos];
                        array[i, localMinPos] = tempValue;
                    }
                }
            }
        }
    }
}