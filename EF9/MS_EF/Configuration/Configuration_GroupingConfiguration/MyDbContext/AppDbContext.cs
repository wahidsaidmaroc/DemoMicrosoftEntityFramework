using Configuration_GroupingConfiguration.Entites;
using Microsoft.EntityFrameworkCore;

namespace Configuration_GroupingConfiguration.MyDbContext;

public class AppDbContext : DbContext
{
    public DbSet<Produit> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //modelBuilder.Entity<Commande>(c =>
        //{
        //    c.ToTable("Com_Commande");
        //    c.HasKey(e => e.Id);
        //    c.Property(e => e.dateTime).IsRequired();
        //    c.Property(e => e.totalHT);
        //    c.HasOne(e => e.Client).WithMany(c => c.Commandes).HasForeignKey(e => e.ClientId);
        //    c.Property(e => e.Description).HasMaxLength(300);
        //}

        //    );

        //modelBuilder.Entity<Produit>(entity =>
        //{
        //    entity.HasKey(e => e.Id);
        //    entity.ToTable("Com_Produit");
        //    entity.Property(e => e.Nom).IsRequired();
        //    entity.Property(e => e.Prix).IsRequired();
        //    entity.Property(e => e.Stock).IsRequired();
        //    entity.HasIndex(e => e.URL).IsUnique();
        //}
        //);


        //modelBuilder.Entity<Client>(entity =>
        //{
        //    entity.HasKey(e => e.Id);
        //    entity.ToTable("Com_Client");
        //    entity.Property(e => e.Nom).IsRequired();
        //}
        //);


        base.OnModelCreating(modelBuilder);
        //Explication de la Ligne de Code
        //La ligne de code que vous avez mentionnée :
        new MyDbContext.Config.ProduitConfiguration().Configure(modelBuilder.Entity<Produit>());
        new MyDbContext.Config.CommandeConfiguration().Configure(modelBuilder.Entity<Commande>());
        //fait essentiellement la même chose que modelBuilder.ApplyConfiguration(new ProductConfiguration());, mais de manière plus explicite. Voici ce qu'elle fait :

        //new MyDbContext.Config.ProductConfiguration() : Crée une nouvelle instance de la classe ProductConfiguration.
        //.Configure(modelBuilder.Entity<Product>()) : Appelle la méthode Configure de ProductConfiguration, en passant l'entité Product à configurer.

    }
}
