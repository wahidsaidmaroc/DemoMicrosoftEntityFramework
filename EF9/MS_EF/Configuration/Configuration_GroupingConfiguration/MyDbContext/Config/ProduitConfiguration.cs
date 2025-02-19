using Configuration_GroupingConfiguration.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Configuration_GroupingConfiguration.MyDbContext.Config
{
    public class ProduitConfiguration : IEntityTypeConfiguration<Produit>
    {
        public void Configure(EntityTypeBuilder<Produit> entity)
        {

            entity.HasKey(e => e.Id);
            entity.ToTable("Com_Produit");
            entity.Property(e => e.Nom).IsRequired();
            entity.Property(e => e.Prix).IsRequired();
            entity.Property(e => e.Stock).IsRequired();
            entity.HasIndex(e => e.URL).IsUnique();

        }
    }
}
