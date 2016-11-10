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

    static class MusicDiscExtenshion
    {
        public static new string ToString(this List<MusicDisc> discs)
        {
            string resultString = string.Empty;
            foreach (var disc in discs)
            {
                resultString += string.Format("{0}\n", disc);
            }
            resultString = resultString.Remove(resultString.Length - 1);
            return resultString;
        }
    }
}
