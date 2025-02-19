using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst_Simple.Entites;

[Table("T_Produit")]
public partial class TProduit
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string? Description { get; set; }

    [Column("codeProduit")]
    [StringLength(50)]
    public string? CodeProduit { get; set; }

    [Column("prixUnitaire", TypeName = "decimal(18, 2)")]
    public decimal? PrixUnitaire { get; set; }

    [Column("_idCategorie")]
    public int? IdCategorie { get; set; }

    [ForeignKey("IdCategorie")]
    [InverseProperty("TProduits")]
    public virtual TCategorie? IdCategorieNavigation { get; set; }

    [InverseProperty("IdProduitNavigation")]
    public virtual ICollection<TDetailCommande> TDetailCommandes { get; set; } = new List<TDetailCommande>();
}
