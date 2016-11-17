using System;
using System.Collections.Generic;

namespace Task6
{
    class MusicDisc
    {
        public string Name { get; set; }
        public MusicCatalog MusicCatalog { get; set; }
        public List<MusicTrack> MusicTracks { get; set; }

        public MusicDisc(string name, MusicCatalog musicCatalog)
        {
            this.Name = name;
            this.MusicCatalog = musicCatalog;
        }

        // My override of ToString() method for MusicDisc
        public override string ToString()
        {
            return string.Format(this.Name);
        }
    }

    // Extension class for List<MusicDisc>
    static class MusicDiscExtenshion
    {
        // Extenshion method Print() for List<MusicDisc>
        public static string Print(this List<MusicDisc> discs, MusicCatalog catalog)
        {
            string resultString = string.Empty;
            List<MusicDisc> tempDiscList = new List<MusicDisc>();

            foreach (var disc in discs)
            {
                if (disc.MusicCatalog == catalog)
                {
                    tempDiscList.Add(disc);
                }
            }
            if (tempDiscList.Count > 0)
            {
                foreach (var disc in tempDiscList)
                {
                    resultString += string.Format("{0}.{1}\n", tempDiscList.IndexOf(disc) + 1, disc);
                }
                resultString = "Music discs list:\n" + resultString.Remove(resultString.Length - 1) + "\n";
            }
            else
            {
                resultString = "There are no discs in this music catalog!\n";
            }
            return resultString;
        }
    }
}
