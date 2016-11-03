using System;
using System.Globalization;
using System.IO;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Text.txt";
            string line;
            float sum = 0;
            NumberStyles style = NumberStyles.Float;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            if (File.Exists(path))
            {
                if (File.ReadAllLines(path).Length > 0)
                {
                    using (StreamReader streamReader = new StreamReader(path))
                    {
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string[] array = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var s in array)
                            {
                                float temp;
                                if (float.TryParse(s, style, culture, out temp))
                                {
                                    sum += temp;
                                }
                            }
                            Console.WriteLine(line);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("File \'{0}\' is empty!", path);
                }
            }
            else
            {
                Console.WriteLine("File \'{0}\' doesn't exist!", path);
            }
            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();
        }
    }
}