using System;
using System.Collections.Generic;
using DataBaseFirst_Simple.Entites;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst_Simple.Context;

public partial class AppMyDbContext : DbContext
{
    public AppMyDbContext(DbContextOptions<AppMyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TBonCommande> TBonCommandes { get; set; }

    public virtual DbSet<TCategorie> TCategories { get; set; }

    public virtual DbSet<TClient> TClients { get; set; }

    public virtual DbSet<TDetailCommande> TDetailCommandes { get; set; }

    public virtual DbSet<TProduit> TProduits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TBonCommande>(entity =>
        {
            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.TBonCommandes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_T_BonCommande_T_Client");
        });

        modelBuilder.Entity<TClient>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TDetailCommande>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdCommandeNavigation).WithMany(p => p.TDetailCommandes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_T_DetailCommande_T_BonCommande");

            entity.HasOne(d => d.IdProduitNavigation).WithMany(p => p.TDetailCommandes).HasConstraintName("FK_T_DetailCommande_T_Produit");
        });

        modelBuilder.Entity<TProduit>(entity =>
        {
            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.TProduits)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_T_Produit_T_Categorie");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
