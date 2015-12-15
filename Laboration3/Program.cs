using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Program
    {
        enum MenuAlternatives { ListAllArtists = 1, GetByGenre, AddArtistToLibrary, AddMemberToGroup, AddAlbumToArtist, AddSongToAlbum, End}

        static void Main(string[] args)
        {
            MusicLibrary myMusicLibrary = new MusicLibrary();
            InitiateMusicLibrary(myMusicLibrary);
        }

        private static void InitiateMusicLibrary(MusicLibrary musicLibrary)
        {
            Soloartist artist1 = new Soloartist("Poppy Classic", new Member("Jane", "Class", Instrumenttype.Vocal));
            Album album11 = new Album(Genre.Pop);
            album11.AddSong(new Song { Name = "One", Duration = 121 });
            album11.AddSong(new Song { Name = "None", Duration = 212 });
            Album album12 = new Album(Genre.Classic);
            album12.AddSong(new Song { Name = "Null", Duration = 321 });
            album12.AddSong(new Song { Name = "Full", Duration = 132 });
            artist1.AddAlbum(album11);
            artist1.AddAlbum(album12);
            musicLibrary.AddArtist(artist1);

            Soloartist artist2 = new Soloartist("The Second Solo", new Member("John", "Second", Instrumenttype.Vocal));
            Album album21 = new Album(Genre.Rock);
            album21.AddSong(new Song { Name = "Two Cities", Duration = 251 });
            album21.AddSong(new Song { Name = "Two Towns", Duration = 263 });
            Album album22 = new Album(Genre.Pop);
            album22.AddSong(new Song { Name = "Two Beaches", Duration = 132 });
            album22.AddSong(new Song { Name = "Two Forget", Duration = 182 });
            artist2.AddAlbum(album21);
            artist2.AddAlbum(album22);
            musicLibrary.AddArtist(artist2);

            Group artist3 = new Group("Mostly metal group");
            artist3.AddMember(new Member(firstName: "Iolo", lastName: "Baggings", instrument: Instrumenttype.Vocal));
            artist3.AddMember(new Member(firstName: "Sammy", lastName: "Ringen", instrument: Instrumenttype.Bass));
            artist3.AddMember(new Member(firstName: "Undefined", lastName: "Member", instrument: Instrumenttype.Guitar));
            Album album31 = new Album(Genre.Metal);
            album31.AddSong(new Song { Name = "Unknown Ring", Duration = 310 });
            album31.AddSong(new Song { Name = "The Known Ring", Duration = 185 });
            album31.AddSong(new Song { Name = "Random Ballad", Duration = 210 });
            Album album32 = new Album(Genre.Metal);
            album32.AddSong(new Song { Name = "Random Ring", Duration = 162 });
            album32.AddSong(new Song { Name = "Less Random Ring", Duration = 250 });
            album32.AddSong(new Song { Name = "Known Ballad", Duration = 358 });
            Album album33 = new Album(Genre.Classic);
            album33.AddSong(new Song { Name = "Random Ring (Instrumental)", Duration = 162 });
            album33.AddSong(new Song { Name = "The Known Ballad (Remastered)", Duration = 500 });
            album33.AddSong(new Song { Name = "Random Ballad (Instrumental)", Duration = 210 });
            artist3.AddAlbum(album31);
            artist3.AddAlbum(album32);
            artist3.AddAlbum(album33);
            musicLibrary.AddArtist(artist3);
        }
    }
}
