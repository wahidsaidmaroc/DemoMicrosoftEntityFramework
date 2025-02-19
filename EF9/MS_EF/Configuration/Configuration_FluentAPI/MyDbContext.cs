using Configuration_FluentAPI.Entites;
using Microsoft.EntityFrameworkCore;


namespace Configuration_FluentAPI
{
    public class MyDbContext : DbContext
    {
        public DbSet<Commande> Commandes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=MaBase;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Commande>(c =>
            {
                c.ToTable("Com_Commande");
                c.HasKey(e => e.Id);
                c.Property(e => e.dateTime).IsRequired();
                c.Property(e => e.totalHT);
                c.HasOne(e => e.Client).WithMany(c => c.Commandes).HasForeignKey(e => e.ClientId);
                c.Property(e => e.Description).HasMaxLength(300);
            }
            
            );

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("Com_Produit");
                entity.Property(e => e.Nom).IsRequired();
                entity.Property(e => e.Prix).IsRequired();
                entity.Property(e => e.Stock).IsRequired();
                entity.HasIndex(e => e.URL).IsUnique();
            }
            );


            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("Com_Client");
                entity.Property(e => e.Nom).IsRequired();
            }
            );
        }
    }
}
