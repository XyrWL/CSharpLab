using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    abstract class Artist
    {
        private Album[] albums;

        public Album this[int index]
        {
            get
            {
                if (index >= 0 && index < albums.Length)
                    return albums[index];
                throw new IndexOutOfRangeException();
            }
        }
        public int Length => albums.Length;
        public string Name { get; set; }

        public Artist(string name)
        {
            Name = name;
            albums = new Album[0];
        }

        public void AddAlbum(Album albumToAdd)
        {
            //if (GetAlbumIndex(albumToAdd) < 0)
            //{
                Album[] newAlbums = new Album[albums.Length + 1];
                for (int i = 0; i < albums.Length; i++)
                {
                    newAlbums[i] = albums[i];
                }
                newAlbums[albums.Length] = albumToAdd;
                albums = newAlbums;
            //}
        }
        public void RemoveAlbum(Album albumToRemove)
        {
            int removeIndex = GetAlbumIndex(albumToRemove);
            Album[] newAlbums = new Album[albums.Length - 1];
            for (int i = 0, j = 0; i < albums.Length; i++)
            {
                if (i == removeIndex)
                    continue;
                newAlbums[j] = albums[i];
                j++;
            }
            albums = newAlbums;
        }
        private int GetAlbumIndex(Album album)
        {
            for (int i = 0; i < albums.Length; i++)
            {
                if (albums[i] == album)
                    return i;
            }
            return -1;
        }
    }
}
