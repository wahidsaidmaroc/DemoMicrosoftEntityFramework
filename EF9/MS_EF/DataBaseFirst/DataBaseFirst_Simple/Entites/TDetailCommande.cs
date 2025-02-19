using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst_Simple.Entites;

[Table("T_DetailCommande")]
public partial class TDetailCommande
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("_idCommande")]
    public int? IdCommande { get; set; }

    [Column("_idProduit")]
    public int? IdProduit { get; set; }

    [Column("qnt", TypeName = "decimal(18, 2)")]
    public decimal? Qnt { get; set; }

    [Column("prixUnitaire", TypeName = "decimal(18, 2)")]
    public decimal? PrixUnitaire { get; set; }

    [Column("total", TypeName = "decimal(18, 2)")]
    public decimal? Total { get; set; }

    [ForeignKey("IdCommande")]
    [InverseProperty("TDetailCommandes")]
    public virtual TBonCommande? IdCommandeNavigation { get; set; }

    [ForeignKey("IdProduit")]
    [InverseProperty("TDetailCommandes")]
    public virtual TProduit? IdProduitNavigation { get; set; }
}
