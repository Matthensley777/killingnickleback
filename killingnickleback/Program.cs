using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace killingnickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            var allSongs = new HashSet<Song>
            {
                new Song { Name = "Stairway to Heaven", Artist = "Led Zeplin"},
                new Song { Name = "Photograph", Artist = "Nickleback"},
                new Song { Name = "How You Remind Me", Artist = "Nickleback"},
                new Song { Name = "The Wall", Artist = "Pink Floyd"},
                new Song { Name = "Rockstar", Artist = "Nickleback"},
                new Song { Name = "Hey Jude", Artist = "The Beatles"},
                new Song { Name = "Hotel California", Artist = "Eagles"}
            };
            foreach( var song in allSongs)
            {
                if (song.Artist != "Nickleback")
                {
                    goodSongs.Add(song);
                }
                
            }
            foreach ( var song in goodSongs)
            {
                Console.WriteLine(song.Name);
                
            }
            Console.ReadLine();
        }
    }
}
