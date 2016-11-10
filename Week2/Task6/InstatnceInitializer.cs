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
            new MusicTrack("Nirvana", "My area", musicDiscs[0]),
            new MusicTrack("Papa Roach", "She loves me not", musicDiscs[0]),
            new MusicTrack("The danger", "Rockers", musicDiscs[0]),
            new MusicTrack("Slipknot", "Bit him now", musicDiscs[1]),
            new MusicTrack("Grampers", "Go there", musicDiscs[1]),
            new MusicTrack("Rammstein", "America", musicDiscs[1]),
            new MusicTrack("Metallica", "Sain angel", musicDiscs[2]),
            new MusicTrack("Metallica", "Nothing else metter", musicDiscs[2]),
            new MusicTrack("Metallica", "Metal man", musicDiscs[2]),
            new MusicTrack("System of a down", "Toxicity", musicDiscs[3]),
            new MusicTrack("System of a down", "Chop suey", musicDiscs[3]),
            new MusicTrack("System of a down", "Aerials", musicDiscs[3]),
            new MusicTrack("Bethovin", "Sun melody", musicDiscs[4]),
            new MusicTrack("Leonardo DeBravo", "Stronger", musicDiscs[4]),
            new MusicTrack("Valleriano Mateo", "Belissimo", musicDiscs[4]),
            new MusicTrack("Luciano Pavarotti", "Senioritta", musicDiscs[5]),
            new MusicTrack("Luciano Pavarotti", "Amore mio", musicDiscs[5]),
            new MusicTrack("Luciano Pavarotti", "Delishious", musicDiscs[5]),
            new MusicTrack("Bakh", "Spring melody", musicDiscs[6]),
            new MusicTrack("Bakh", "Winter cold", musicDiscs[6]),
            new MusicTrack("Bakh", "Der auden moiye", musicDiscs[6]),
            new MusicTrack("Symphonica", "Rain", musicDiscs[7]),
            new MusicTrack("Ben Howard", "From heart", musicDiscs[7]),
            new MusicTrack("Melo Mussinio", "Mucho mareo", musicDiscs[7]),
            new MusicTrack("Armin VanBuren", "Electric life", musicDiscs[8]),
            new MusicTrack("Tom Claris", "Club Boom", musicDiscs[8]),
            new MusicTrack("Jimm Morgan", "The streets", musicDiscs[8]),
            new MusicTrack("Tiesto", "Many hours", musicDiscs[9]),
            new MusicTrack("Tiesto", "Gangers", musicDiscs[9]),
            new MusicTrack("Tiesto", "Next door", musicDiscs[9]),
            new MusicTrack("Aivengo", "Hands", musicDiscs[10]),
            new MusicTrack("Nick Shneider", "Ruffers", musicDiscs[10]),
            new MusicTrack("Mark Love", "Her legs", musicDiscs[10]),
            new MusicTrack("Dash Berlin", "Clouds", musicDiscs[11]),
            new MusicTrack("Dash Berlin", "Next episode", musicDiscs[11]),
            new MusicTrack("Dash Berlin", "Love me", musicDiscs[11]),
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
    }
}
