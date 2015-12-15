using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class MusicLibrary
    {
        Artist[] artists = new Artist[0];

        public Artist this[int index]
        {
            get
            {
                if (index >= 0 && index < artists.Length)
                    return artists[index];
                throw new IndexOutOfRangeException();
            }
        }
        public int Length => artists.Length;

        public void AddArtist(Artist artistToAdd)
        {
            Artist[] newArtists = new Artist[artists.Length + 1];
            for (int i = 0; i < artists.Length; i++)
            {
                newArtists[i] = artists[i];
            }
            newArtists[artists.Length] = artistToAdd;
            artists = newArtists;
        }
        public void RemoveArtist(Artist artistToRemove)
        {
            int removeIndex = GetArtistIndex(artistToRemove);
            Artist[] newArtists = new Artist[artists.Length - 1];
            for (int i = 0, j = 0; i < artists.Length; i++)
            {
                if (i == removeIndex)
                    continue;
                newArtists[j] = artists[i];
                j++;
            }
            artists = newArtists;
        }
        private int GetArtistIndex(Artist artist)
        {
            for (int i = 0; i < artists.Length; i++)
            {
                if (artists[i] == artist)
                    return i;
            }
            return -1;
        }
        public Artist[] GetAllArtistsByGenre(Genre genre)
        {
            Artist[] artistsByGenre = new Artist[artists.Length];
            int artistCount = 0;
            for (int i = 0; i < artists.Length; i++)
            {
                for (int j = 0; j < artists[i].Length; j++)
                {
                    if (artists[i][j].Genre == genre)
                    {
                        artistsByGenre[artistCount] = artists[i];
                        artistCount++;
                        break;
                    }
                }
            }
            Artist[] result = new Artist[artistCount];
            for (int i = 0; i < artistCount; i++)
                result[i] = artistsByGenre[i];
            return result;
        }
    }
}
