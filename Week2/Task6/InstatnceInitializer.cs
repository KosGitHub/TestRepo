using System;
using System.Collections.Generic;

namespace Task6
{
    static class InstatnceInitializer
    {
        public static List<MusicCatalog> musicCatalogs = new List<MusicCatalog>
        {
            new MusicCatalog("Rock Music"),
            new MusicCatalog("Classic Music"),
            new MusicCatalog("Electronic Music")
        };

        public static List<MusicDisc> musicDiscs = new List<MusicDisc>
        {
            new MusicDisc("Best Rock Compositions", musicCatalogs[0]),
            new MusicDisc("Hard sounds", musicCatalogs[0]),
            new MusicDisc("Metallica - The best", musicCatalogs[0]),
            new MusicDisc("System of a down - Toxicity", musicCatalogs[0]),
            new MusicDisc("The melodica", musicCatalogs[1]),
            new MusicDisc("Luciano Pavarotti", musicCatalogs[1]),
            new MusicDisc("Bakh - Spring melody", musicCatalogs[1]),
            new MusicDisc("Orchestric wind", musicCatalogs[1]),
            new MusicDisc("Armin VanBuren - ASOT", musicCatalogs[2]),
            new MusicDisc("Tiesto - Club Life", musicCatalogs[2]),
            new MusicDisc("Electronic - The best 2016", musicCatalogs[2]),
            new MusicDisc("Dash Berlin - Clouds", musicCatalogs[2]),
        };

        public static List<MusicTrack> musicTracks = new List<MusicTrack>
        {
            new MusicTrack(1, "Nirvana", "My area", musicDiscs[0]),
            new MusicTrack(2, "Papa Roach", "She loves me not", musicDiscs[0]),
            new MusicTrack(3, "The danger", "Rockers", musicDiscs[0]),
            new MusicTrack(4, "Slipknot", "Bit him now", musicDiscs[1]),
            new MusicTrack(5, "Grampers", "Go there", musicDiscs[1]),
            new MusicTrack(6, "Rammstein", "America", musicDiscs[1]),
            new MusicTrack(7, "Metallica", "Sain angel", musicDiscs[2]),
            new MusicTrack(8, "Metallica", "Nothing else metter", musicDiscs[2]),
            new MusicTrack(9, "Metallica", "Metal man", musicDiscs[2]),
            new MusicTrack(10, "System of a down", "Toxicity", musicDiscs[3]),
            new MusicTrack(11, "System of a down", "Chop suey", musicDiscs[3]),
            new MusicTrack(12, "System of a down", "Aerials", musicDiscs[3]),
            new MusicTrack(13, "Bethovin", "Sun melody", musicDiscs[4]),
            new MusicTrack(14, "Leonardo DeBravo", "Stronger", musicDiscs[4]),
            new MusicTrack(15, "Valleriano Mateo", "Belissimo", musicDiscs[4]),
            new MusicTrack(16, "Luciano Pavarotti", "Senioritta", musicDiscs[5]),
            new MusicTrack(17, "Luciano Pavarotti", "Amore mio", musicDiscs[5]),
            new MusicTrack(18, "Luciano Pavarotti", "Delishious", musicDiscs[5]),
            new MusicTrack(19, "Bakh", "Spring melody", musicDiscs[6]),
            new MusicTrack(20, "Bakh", "Winter cold", musicDiscs[6]),
            new MusicTrack(21, "Bakh", "Der auden moiye", musicDiscs[6]),
            new MusicTrack(22, "Symphonica", "Rain", musicDiscs[7]),
            new MusicTrack(23, "Ben Howard", "From heart", musicDiscs[7]),
            new MusicTrack(24, "Melo Mussinio", "Mucho mareo", musicDiscs[7]),
            new MusicTrack(25, "Armin VanBuren", "Electric life", musicDiscs[8]),
            new MusicTrack(26, "Tom Claris", "Club Boom", musicDiscs[8]),
            new MusicTrack(27, "Jimm Morgan", "The streets", musicDiscs[8]),
            new MusicTrack(28, "Tiesto", "Many hours", musicDiscs[9]),
            new MusicTrack(29, "Tiesto", "Gangers", musicDiscs[9]),
            new MusicTrack(30, "Tiesto", "Next door", musicDiscs[9]),
            new MusicTrack(31, "Aivengo", "Hands", musicDiscs[10]),
            new MusicTrack(32, "Nick Shneider", "Ruffers", musicDiscs[10]),
            new MusicTrack(33, "Mark Love", "Her legs", musicDiscs[10]),
            new MusicTrack(34, "Dash Berlin", "Clouds", musicDiscs[11]),
            new MusicTrack(35, "Dash Berlin", "Next episode", musicDiscs[11]),
            new MusicTrack(36, "Dash Berlin", "Love me", musicDiscs[11]),
        };

        // Method of the attaching catalogs with their discs
        public static void CatalogDiscsAttach()
        {
            foreach (var musicCatalog in musicCatalogs)
            {
                musicCatalog.MusicDiscs = new List<MusicDisc>();
                foreach (var musicDisc in musicDiscs)
                {
                    if (musicDisc.MusicCatalog == musicCatalog)
                    {
                        musicCatalog.MusicDiscs.Add(musicDisc);
                    }
                }
            }
        }

        // Method of the attaching discs with their tracks
        public static void DiscTracksAttach()
        {
            foreach (var musicDisc in musicDiscs)
            {
                musicDisc.MusicTracks = new List<MusicTrack>();
                foreach (var track in musicTracks)
                {
                    if (track.MusicDisc == musicDisc)
                    {
                        musicDisc.MusicTracks.Add(track);
                    }
                }
            }
        }
    }
}
