using System;
using System.Collections;

namespace Task10._2
{
    static class ArrayListExtensions
    {
        public static void SortBubble(this ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - i - 1; j++)
                {
                    if ((int)array[j] > (int)array[j + 1])
                    {
                        int temp = (int)array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortSelection(this ArrayList array)
        {
            int min, temp;
            int length = array.Count;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if ((int)array[j] < (int)array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = (int)array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }

        public static void Print(this ArrayList arrayList)
        {
            string outputString = String.Empty;
            foreach (var item in arrayList)
            {
                outputString += string.Format("{0}, ", item);
            }
            Console.WriteLine(outputString.Trim(' ', ','));
        }
    }
}
