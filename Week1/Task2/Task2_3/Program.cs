using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Input a size of array, please: ");
            while (!Int32.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("You must enter integer, try again please!\nInput a size of array, please: ");
            }

            short[] array = GetRandomArray(size);
            Console.WriteLine("Array before sort:");
            foreach (var i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Sort(array); // or we can do 'Array.Sort(array)' and sort array without our sorting implementation
            Console.WriteLine("Array after sort:");
            foreach (var i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();
        }
        static short[] GetRandomArray(int size)
        {
            short[] array = new short[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = (short)rnd.Next(-500, 500);
            }
            return array;
        }
        static void Sort(short[] array)//a variant of sorting implementation
        {
            int localMinPos;
            short tempValue;
            for (int i = 0; i < array.Length; i++)
            {
                localMinPos = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[localMinPos])
                    {
                        localMinPos = j;
                    }
                }
                tempValue = array[i];
                array[i] = array[localMinPos];
                array[localMinPos] = tempValue;
            }
        }
    }
}

