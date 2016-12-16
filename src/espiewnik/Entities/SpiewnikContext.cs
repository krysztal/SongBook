using Microsoft.EntityFrameworkCore;


namespace espiewnik.Entities
{
    public class SpiewnikContext : DbContext
    {
        public SpiewnikContext(DbContextOptions<SpiewnikContext> options)
            : base(options)
        {}


        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySong> CategoriesSongs { get; set; }
        public DbSet<Composer> Composers { get; set; }
        public DbSet<Elaboration> Elaborations { get; set; }
        public DbSet<ElaborationComposer> ElaborationsComposers { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FileType> FileTypes { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Scope> Scops { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Voice> Voices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}