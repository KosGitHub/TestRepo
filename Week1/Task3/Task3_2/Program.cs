using System;
using System.IO;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"File.dat";
            string content;
            if (File.Exists(path) && File.ReadAllLines(path).Length > 0)
            {
                Console.WriteLine("File content:");
                Console.WriteLine(File.ReadAllText(path));
                using (StreamReader streamReader = new StreamReader(path))
                {
                    content = streamReader.ReadToEnd();
                }
                string[] contentArray = content.Split(',');
                content = string.Empty;
                foreach (var number in contentArray)
                {
                    content += Math.Pow(int.Parse(number), 2) + ",";
                }
                content = content.Remove(content.Length - 1);
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.Write(content, false);
                }
                Console.WriteLine("After modification file content:");
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("File \'{0}\' doesn't exist or it's empty!", path);
            }
            Console.ReadLine();
        }
    }
}
