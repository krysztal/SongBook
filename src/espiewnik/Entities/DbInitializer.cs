using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace espiewnik.Entities
{
    public class DbInitializer
    {
        public static void Initialize(SpiewnikContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
