using System.Linq;
using SongBook.Entities;

namespace SongBook.Repositories
{
    public interface ISongRepository
    {
        IQueryable<Song> GetSongs();
        IQueryable<Song> FindSongs(string name);
        Song GetSong(int id);
        Song AddSong(Song song);
        Song UpdateSong(Song song);
        void RemoveSong(int id);
    }
}
