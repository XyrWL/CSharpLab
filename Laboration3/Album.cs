using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Album
    {
        private Song[] songs;

        public Song this[int index]
        {
            get
            {
                if (index >= 0 && index < songs.Length)
                    return songs[index];
                throw new IndexOutOfRangeException();
            }
        }
        public int Length => songs.Length;
        public Genre Genre { get; private set; }

        public Album(Genre genre)
        {
            Genre = genre;
            songs = new Song[0];
        }

        public void AddSong(Song songToAdd)
        {
            if (GetSongIndex(songToAdd) < 0)
            {
                Song[] newSongs = new Song[songs.Length + 1];
                for (int i = 0; i < songs.Length; i++)
                {
                    newSongs[i] = songs[i];
                }
                newSongs[songs.Length] = songToAdd;
                songs = newSongs;
            }
        }
        public void RemoveSong(Song songToRemove)
        {
            int removeIndex = GetSongIndex(songToRemove);
            Song[] newSongs = new Song[songs.Length - 1];
            for (int i = 0, j = 0; i < songs.Length; i++)
            {
                if (i == removeIndex)
                    continue;
                newSongs[j] = songs[i];
                j++;
            }
            songs = newSongs;
        }
        private int GetSongIndex(Song song)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i] == song)
                    return i;
            }
            return -1;
        }

        /*public static bool operator ==(Album first, Album second)
        {
            if(first == null || second == null)
                throw new ArgumentNullException();
            if (first.Genre != second.Genre)
                return false;
            if (first.songs.Length != second.songs.Length)
                return false;
            for (int i = 0; i < first.songs.Length; i++)
            {
                if (first[i] != second[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(Album first, Album second)
        {
            if (first == null || second == null)
                throw new ArgumentNullException();
            if (first.Genre != second.Genre)
                return true;
            if (first.songs.Length != second.songs.Length)
                return true;
            for (int i = 0; i < first.songs.Length; i++)
            {
                if (first[i] != second[i])
                    return true;
            }
            return false;
        }*/
        public override string ToString() => $"Genre:{Genre} Songs[{songs.Aggregate("", (current, song) => current + $"({song})")}]";
    }
}
