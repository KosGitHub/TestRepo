using System;
using System.IO;

namespace Task3_3
{
    class Program
    {
        private static string path = @"Catalog\";
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            ShowSubdirectories(directory, 0);//2nd parameter (nesting) is needed for beautiful output in Console
            Console.ReadLine();
        }
        static void ShowSubdirectories(DirectoryInfo directory, int nesting)
        {
            if (directory.Exists)
            {
                Console.WriteLine("{0}{1}", new String('\t', nesting), directory.Name);
                FileInfo[] innerFilles = directory.GetFiles();
                if (innerFilles.Length > 0)
                {
                    nesting++;
                    foreach (var innerFille in innerFilles)
                    {
                        Console.WriteLine("{0}{1}", new String('\t', nesting), innerFille.Name);
                    }
                }
                DirectoryInfo[] subDirectories = directory.GetDirectories();
                if (subDirectories.Length > 0)
                {
                    foreach (var subDirectory in subDirectories)
                    {
                        ShowSubdirectories(subDirectory, nesting);
                    }
                }
            }
            else
            {
                Console.WriteLine("Directory \'{0}\' does not exist!", directory.Name);
            }
        }
    }
}
