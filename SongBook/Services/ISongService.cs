using System.Collections.Generic;
using SongBook.Entities;
using SongBook.Dtos;


namespace SongBook.Services
{
    public interface ISongService
    {
        IEnumerable<Song> GetSongs();
        Song GetSong(int id);
        SongDto AddSong(SongDto song);
        Song UpdateSong(Song song);
        void RemoveSong(int id);
    }
}
