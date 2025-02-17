using EF_ConsoleApp_CodeFirst.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace EF_ConsoleApp_CodeFirst.Data;

public class MyDbContext : DbContext
{
    //Create Construcrtor
    //public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    //{
    //}


    #region "DbSet"
    public DbSet<Produit> Produits { get; set; }
    public DbSet<Categorie> Categories { get; set; }

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
                .Build();
        var constr = configuration.GetSection("ConnectionStrings:ZoneToLearnDb").Value;
        optionsBuilder.UseSqlServer(constr);
    }

    //Create OnModelCreating method
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Produit>()
            .Property(p => p.ImagePath)
            .HasDefaultValue("images/default.jpg"); 
    }



}
