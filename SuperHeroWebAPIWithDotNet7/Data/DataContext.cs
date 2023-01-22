

namespace SuperHeroWebAPIWithDotNet7.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /** Either you have the option of configuring the connection string within
         * the DataContext.cs itself by overriding OnConfiguring as below or
         * in the Program.cs while registering the DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-0T718VJ;Database=SuperHeroDb;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        */

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
