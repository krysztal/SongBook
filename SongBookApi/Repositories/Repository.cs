using SongBook.Entities;

namespace SongBook.Repositories
{
    public class Repository : IRepository
    {
        protected SongBookContext _context;
        public Repository(SongBookContext context)
        {
            _context = context;
        }
    }
}
