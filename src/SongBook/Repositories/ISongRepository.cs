using System.Linq;
using SongBook.Entities;

namespace SongBook.Repositories
{
    public interface ISongRepository
    {
        IQueryable<Song> GetSongs();
        IQueryable<Song> FindSongs(string name);
        Song GetSong(int id);
        Song UpdateSong(Song song);
        void RemoveSong(Song song);
    }
}
