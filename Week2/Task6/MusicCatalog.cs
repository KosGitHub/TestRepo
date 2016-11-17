using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class MusicCatalog
    {
        public string Name { get; set; }
        public List<MusicDisc> MusicDiscs { get; set; }

        public MusicCatalog(string name)
        {
            this.Name = name;
        }

        // My override of ToString() method for MusicCatalog
        public override string ToString()
        {
            return string.Format(this.Name);
        }
    }
    // Extension class for List<MusicCatalog>
    static class MusicCatalogExtenshion
    {
        // Extenshion method Print() for List<MusicCatalog>
        public static string Print(this List<MusicCatalog> catalogs)
        {
            string resultString = string.Empty;
            if (catalogs.Count>0)
            {
                foreach (var catalog in catalogs)
                {
                    resultString += string.Format("{0}.{1}\n", catalogs.IndexOf(catalog) + 1, catalog);
                }
                resultString = "Music catalog list:\n" + resultString.Remove(resultString.Length - 1) + "\n";    
            }
            else
            {
                resultString = "There are no catalogs in you music store!\n"; 
            }
            return resultString;
        }

        public static string SearchTracksByAuthor(this List<MusicCatalog> musicCatalogs, string author )
        {
            string resultString = string.Empty;
            foreach (var musicCatalog in musicCatalogs)
            {
                foreach (var musicDisc in musicCatalog.MusicDiscs)
                {
                    foreach (var musicTrack in musicDisc.MusicTracks)
                    {
                        if (musicTrack.Author == author)
                        {
                            resultString += musicTrack.MusicDisc.MusicCatalog.ToString() + musicTrack.MusicDisc.ToString() + musicTrack;
                        }
                    }
                }
            }
            return resultString;
        }
    }
}