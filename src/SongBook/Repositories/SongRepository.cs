using System.Linq;
using SongBook.Entities;

namespace SongBook.Repositories
{
    public class SongRepository : Repository, ISongRepository
    {
        public SongRepository(SongBookContext context) : base(context)
        { }

        public IQueryable<Song> GetSongs()
        {
            return _context.Songs.AsQueryable();
        }

        public IQueryable<Song> FindSongs(string name)
        {
            return _context.Songs.Where(s => s.FileName.Contains(name));
        }

        public Song GetSong(int id)
        {
            return _context.Songs.SingleOrDefault(s => s.Id == id);
        }

        public Song AddSong(Song song)
        {
            _context.Add(song);
            _context.SaveChanges();
            return song;
        }

        public Song UpdateSong(Song song)
        {
            Song Song = _context.Songs.Where(s => s.Id == song.Id).First();
            Song.CopyData(song);
            _context.SaveChanges();

            return Song;
        }

        public void RemoveSong(int id)
        {
            Song Song = GetSong(id);
            _context.Remove(Song);
            _context.SaveChanges();
        }
    }
}
