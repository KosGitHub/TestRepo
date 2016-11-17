using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MusicCatalog> musicCatalogs = InstatnceInitializer.musicCatalogs;
            List<MusicDisc> musicDiscs = InstatnceInitializer.musicDiscs;
            List<MusicTrack> musicTracks = InstatnceInitializer.musicTracks;
            InstatnceInitializer.CatalogDiscsAttach();
            InstatnceInitializer.DiscTracksAttach();
            //MusicStorePrint(); // if we want to see all music store hierarchy

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(musicCatalogs.Print());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("a - Add new music catalog");
                Console.WriteLine("s - Search track in music catalog\n");
                Console.Write("Chose music catalog or press 'a' for adding new catalog:");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine("\n");
                if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                {
                    Environment.Exit(0); // close application
                }

                string inputString = key.KeyChar.ToString();
                uint catalogNumber = 0;
                //string inputString = Console.ReadLine();
                while ((!uint.TryParse(inputString, out catalogNumber) || uint.Parse(inputString) > musicCatalogs.Count) && !Regex.IsMatch(inputString, @"(?:a|s)"))
                {
                    Console.WriteLine("You chose incorrect number of catalog. Try again, please!");
                    Console.Write("Chose music catalog or press 'a' for adding new catalog:");
                    key = Console.ReadKey();
                    Console.WriteLine("\n");
                    if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                    {
                        Environment.Exit(0); // close application
                    }

                    inputString = key.KeyChar.ToString();
                }
                if (catalogNumber == 0) // if user entered 'a' for adding new catalog
                {
                    if (Regex.IsMatch(inputString, @"a"))
                    {
                        Console.WriteLine("Enter name for new catalog, please:");
                        inputString = Console.ReadLine();
                        musicCatalogs.Add(new MusicCatalog(inputString));
                    }
                    else if (Regex.IsMatch(inputString, @"s"))
                    {
                        Console.Write("Enter author of track which you want to find, please:");
                        inputString = Console.ReadLine();
                        musicCatalogs.SearchTracksByAuthor(inputString);
                    }
                }
                else // open discs list from chosen catalog
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(musicDiscs.Print(musicCatalogs[(int)catalogNumber-1]));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("a - Add new music disc");
                        Console.WriteLine("d - Delete current music catalog");
                        Console.WriteLine("ESC - Exit to music catalogs list\n");
                        Console.Write("Chose music disc or press 'a' for adding new disc or 'd' for deleting current catalog:");
                        
                        key = Console.ReadKey();
                        Console.WriteLine("\n");
                        if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                        {
                            break; // back to the catalogs list view
                        }
                        inputString = key.KeyChar.ToString();
                        uint discNumber = 0;
                        while ((!uint.TryParse(inputString, out discNumber) || uint.Parse(inputString) > musicDiscs.Count) && !Regex.IsMatch(inputString, @"(?:a|d)"))
                        {
                            Console.WriteLine("You chose incorrect number of disc. Try again, please!");
                            Console.Write("Chose music disc or press 'a' for adding new disc or 'd' for deleting current catalog:");
                            key = Console.ReadKey();
                            Console.WriteLine("\n");
                            if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                            {
                                break; // back to the catalogs list view
                            }
                            inputString = key.KeyChar.ToString();
                        }
                        if (discNumber == 0)
                        {
                            if (Regex.IsMatch(inputString, @"a"))
                            {
                                Console.WriteLine("Enter name for new disc, please:");
                                inputString = Console.ReadLine();
                                musicDiscs.Add(new MusicDisc(inputString, musicCatalogs[(int)catalogNumber - 1]));
                            }
                            else if (Regex.IsMatch(inputString, @"d"))
                            {
                                musicCatalogs.Remove(musicCatalogs[(int) catalogNumber - 1]);
                                break;
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(musicTracks.Print(musicCatalogs[(int)catalogNumber-1].MusicDiscs[(int)discNumber - 1]));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("a - Add new track");
                                Console.WriteLine("d - Delete current music disc");
                                Console.WriteLine("ESC - Exit to music discs list\n");
                                Console.Write("Chose music disc or press 'a' for adding new track or 'd' for deleting current disc:");
                                key = Console.ReadKey();
                                Console.WriteLine("\n");
                                if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                                {
                                    break; // back to the disks list view
                                }
                                inputString = key.KeyChar.ToString();
                                uint trackNumber = 0;
                                while ((!uint.TryParse(inputString, out trackNumber) || uint.Parse(inputString) > musicTracks.Count) && !Regex.IsMatch(inputString, @"(?:a|d)"))
                                {
                                    Console.WriteLine("You chose incorrect number of track. Try again, please!");
                                    Console.Write("Chose music track or press 'a' for adding new track or 'd' for deleting current disc:");
                                    key = Console.ReadKey();
                                    Console.WriteLine("\n");
                                    if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                                    {
                                        break; // back to the catalogs list view
                                    }
                                    inputString = key.KeyChar.ToString();
                                }
                                if (trackNumber == 0)
                                {
                                    if (Regex.IsMatch(inputString, @"a"))
                                    {
                                        Console.WriteLine("Enter author for new track, please:");
                                        //inputString = Console.ReadLine();
                                        string inputAuthor = Console.ReadLine();
                                        Console.WriteLine("Enter title for new track, please:");
                                        string inputTitle = Console.ReadLine();
                                        musicTracks.Add(new MusicTrack(musicTracks.GetMaxId()+1, inputAuthor, inputTitle, musicCatalogs[(int)catalogNumber-1].MusicDiscs[(int)discNumber - 1]));
                                    }
                                    else if (Regex.IsMatch(inputString, @"d"))
                                    {
                                        musicDiscs.Remove(musicCatalogs[(int)catalogNumber - 1].MusicDiscs[(int)discNumber - 1]);
                                        break;
                                    }
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //Console.WriteLine(musicCatalogs[(int)catalogNumber - 1].MusicDiscs[(int)discNumber - 1].MusicTracks[(int)trackNumber-1].ToString());
                                        //Console.WriteLine(musicCatalogs[(int)catalogNumber - 1].MusicDiscs[(int)discNumber - 1].GetTracks()[(int)trackNumber - 1]);
                                        Console.WriteLine(musicTracks.Print(musicCatalogs[(int)catalogNumber - 1].MusicDiscs[(int)discNumber - 1], (int)trackNumber));
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("d - Delete current music track");
                                        Console.WriteLine("ESC - Exit to music discs list\n");
                                        Console.Write("Press 'd' for deleting current track:");
                                        key = Console.ReadKey();
                                        Console.WriteLine("\n");
                                        if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                                        {
                                            break; // back to the tracks list view
                                        }
                                        inputString = key.KeyChar.ToString();
                                        while (!Regex.IsMatch(inputString, @"(?:d)"))
                                        {
                                            Console.WriteLine("You can only delete this track or exit. Try again, please!");
                                            Console.Write("Press 'd' for deleting current track:");
                                            key = Console.ReadKey();
                                            Console.WriteLine("\n");
                                            if (key.Key == ConsoleKey.Escape) // if user entered ESC from keyboard 
                                            {
                                                break; // back to the catalogs list view
                                            }
                                            inputString = key.KeyChar.ToString();
                                        }
                                        musicTracks.Remove(musicCatalogs[(int)catalogNumber - 1].MusicDiscs[(int)discNumber - 1].MusicTracks[(int)trackNumber-1]);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //Output all catalogs-discs-tracks in console
        static void MusicStorePrint()
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
