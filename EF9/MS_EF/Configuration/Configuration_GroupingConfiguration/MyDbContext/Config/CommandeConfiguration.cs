using Configuration_GroupingConfiguration.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration_GroupingConfiguration.MyDbContext.Config
{
    public class CommandeConfiguration : IEntityTypeConfiguration<Commande>
    {
        public void Configure(EntityTypeBuilder<Commande> entity)
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("Com_Commande");
            entity.Property(e => e.dateTime).IsRequired();
            entity.Property(e => e.totalHT).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.HasOne(e => e.Client).WithMany(e => e.Commandes).HasForeignKey(e => e.ClientId);
        }
    }
}
