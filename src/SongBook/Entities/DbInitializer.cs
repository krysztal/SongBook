using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SongBook.Entities
{
    public class DbInitializer
    {
        public static void Initialize(SongBookContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
