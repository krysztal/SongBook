using System.Collections.Generic;
using SongBook.Entities;


namespace SongBook.Services
{
    public interface ISongService
    {
        IEnumerable<Song> GetSongs();
        Song GetSong(int id);
        Song UpdateSong(Song song);
        void RemoveSong(Song song);
    }
}
