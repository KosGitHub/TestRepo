using System;
using System.Collections.Generic;

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

    static class MusicCatalogExtenshion
    {
        public static new string Print(this List<MusicCatalog> catalogs)
        {
            string resultString = string.Empty;
            foreach (var catalog in catalogs)
            {
                resultString += string.Format("{0}\n", catalog);
            }
            resultString = resultString.Remove(resultString.Length - 1);
            return resultString;
        }
    }
}
