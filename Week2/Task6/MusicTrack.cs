using System;
using System.Collections.Generic;


namespace Task6
{
    class MusicTrack
    {
        public int TrackId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public MusicDisc MusicDisc { get; set; }

        public MusicTrack(int id, string author, string title, MusicDisc musicDisc)
        {
            this.TrackId = id;
            this.Author = author;
            this.Title = title;
            this.MusicDisc = musicDisc;
        }

        // My override of ToString() method for MusicTrack
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Author, this.Title);
        }
    }
    // Extension class for List<MusicTrack>
    static class MusicTrackExtenshion
    {
        // Extenshion method GetMaxId() for getting new track id when we need to add a new track to List<MusicTrack>
        public static int GetMaxId(this List<MusicTrack> tracks)
        {
            int maxId=0;
            if (tracks.Count>0)
            {
                foreach (var track in tracks)
                {
                    if (track.TrackId > maxId)
                    {
                        maxId = track.TrackId;
                    }
                }
            }
            return maxId;
        }

        // Extenshion method Print() for List<MusicTrack>
        public static string Print(this List<MusicTrack> tracks, MusicDisc disc)
        {
            string resultString = string.Empty;
            List<MusicTrack> tempTracksList = new List<MusicTrack>();
            foreach (var track in tracks)
            {
                if (track.MusicDisc == disc)
                {
                    tempTracksList.Add(track);
                }
            }
            if (tracks.Count > 0)
            {
                foreach (var track in tempTracksList)
                {
                    resultString += string.Format("{0}.{1}\n", tempTracksList.IndexOf(track) + 1, track);
                }
                resultString = "Music tracks list:\n" + resultString.Remove(resultString.Length - 1) + "\n";
            }
            else
            {
                resultString = "There are no tracks at this music disc!\n";
            }
            return resultString;
        }

        // 2nd overload of Extenshion method Print() for List<MusicTrack> with liNum parameter - for getting only 1 track from disc
        public static string Print(this List<MusicTrack> tracks, MusicDisc disc, int lineNum)
        {
            string trackString = tracks.Print(disc); // run Print with 2 paramrters for getting string with tracks list
            string[] lines = trackString.Replace("\r", "").Split('\n'); // split up string to array of lines with tracks titles
            return lines[lineNum].Remove(0, 2);
        }
    }
}
