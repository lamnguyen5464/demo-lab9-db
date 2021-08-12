using System;
using System.Collections.Generic;

namespace TestApp.Models
{
    class Song
    {
        public String id;
        public String name;
        public String composer;
        public String singer;
        public int view;
        public int official;
        public String quality;

        public Song()
        {
        }
        public Song(String id, String name, String composer, String singer, int view, int official, String quality)
        {
            this.id = id;
            this.name = name;
            this.composer = composer;
            this.singer = singer;
            this.view = view;
            this.official = official;
            this.quality = quality;
        }

        public static List<Song> getMockData()
        {
            List<Song> list = new List<Song>();
            list.Add(new Song("1", "Bai hat 1", "nhac si 1", "ca si 1", 11, 1, "HD"));
            list.Add(new Song("1", "Bai hat 2", "nhac si 1", "ca si 1", 11, 1, "HD"));
            list.Add(new Song("1", "Bai hat 3", "nhac si 1", "ca si 1", 11, 1, "HD"));
            list.Add(new Song("1", "Bai hat 4", "nhac si 1", "ca si 1", 11, 1, "HD"));
            list.Add(new Song("1", "Bai hat 6", "nhac si 1", "ca si 1", 11, 1, "HD"));
            list.Add(new Song("1", "Bai hat 7", "nhac si 1", "ca si 1", 11, 1, "HD"));
            list.Add(new Song("1", "Bai hat 8", "nhac si 1", "ca si 1", 11, 1, "HD"));
            return list;
        }
    }
}
