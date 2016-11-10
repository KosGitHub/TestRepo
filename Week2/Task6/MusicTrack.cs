using System;
using System.Collections.Generic;


namespace Task6
{
    class MusicTrack
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public MusicDisc MusicDisc { get; set; }

        public MusicTrack(string author, string title, MusicDisc musicDisc)
        {
            this.Author = author;
            this.Title = title;
            this.MusicDisc = musicDisc;
        }

        // My override of ToString() method for MusicTrack
        public override string ToString()
        {
            return string.Format("{0} - {1}",this.Author, this.Title);
        }
    }

    static class MusicTrackExtenshion
    {
        public static new string ToString(this List<MusicTrack> tracks)
        {
            string resultString = string.Empty;
            foreach (var track in tracks)
            {
                resultString += string.Format("{0}\n", track);
            }
            resultString = resultString.Remove(resultString.Length - 1);
            return resultString;
        }
    }
}
