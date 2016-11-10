using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<MusicCatalog> musicCatalogs = InstatnceInitializer.musicCatalogs;
            //List<MusicDisc> musicDiscs = InstatnceInitializer.musicDiscs;
            //List<MusicTrack> musicTracks = InstatnceInitializer.musicTracks;
            InstatnceInitializer.CatalogDiscsAttach();
            Print();

            //Console.Write("Chose music catalog, please:\n" +
            //                  "1.Add\n" +
            //                  "2.Delete\n" +
            //                  "3.Search\n" +
            //                  "Enter number of operation, please:");
            //byte operationNumber;
            //string inputString = Console.ReadLine();
            //while (!byte.TryParse(inputString, out operationNumber))
            //{
            //    Console.WriteLine("Please enter a number!");
            //}
            //switch (operationNumber)
            //{
            //    case 1:
            //        Console.Write("What do you want to add?\n" +
            //                  "1.Music catalog\n" +
            //                  "2.Music disc\n" +
            //                  "3.Music track\n" +
            //                  "Enter number of operation, please:");
            //        break;
            //    case 2:
            //        Console.Write("What do you want to delete?\n" +
            //                  "1.Music catalog\n" +
            //                  "2.Music disc\n" +
            //                  "3.Music track\n" +
            //                  "Enter number of operation, please:");
            //        break;
            //    case 3:
            //        break;
            //    default:
            //        Console.WriteLine("There are no operations with this number!\n" +
            //                          "");
            //        break;
            //}
            Console.WriteLine("If you want");
            Console.WriteLine(InstatnceInitializer.musicCatalogs.Print());

            Console.ReadLine();
        }

        //Output all catalogs-discs-tracks in console
        static void Print()
        {
            Console.WriteLine("This is our music storage!");
            foreach (var musicCatalog in InstatnceInitializer.musicCatalogs)
            {
                Console.WriteLine(musicCatalog);
                foreach (var musicDisc in InstatnceInitializer.musicDiscs)
                {
                    if (musicDisc.MusicCatalog == musicCatalog)
                    {
                        Console.WriteLine("\t{0}", musicDisc);
                        foreach (var musicTrack in InstatnceInitializer.musicTracks)
                        {
                            if (musicTrack.MusicDisc == musicDisc)
                            {
                                Console.WriteLine("\t\t{0}", musicTrack);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
