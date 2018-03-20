using Microsoft.EntityFrameworkCore;

namespace EFCoreEnumBug
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ExchangeRate> ExchangeRate { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExchangeRate>()
                .HasKey(x => new {x.FromCurrency, x.ToCurrency});


            modelBuilder.Entity<ExchangeRate>()
                .Property(x => x.FromCurrency)
                .HasConversion<string>();

            modelBuilder.Entity<ExchangeRate>()
                .Property(x => x.ToCurrency)
                .HasConversion<string>();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
