using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_ConsoleApp.Entites;

[Table("T_Produit", Schema ="dbo")]
[Comment("Ceci est la table des produits")]
public class Produit
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string CodeProduit { get; set; } = string.Empty;

    public string Nom { get; set; } = string.Empty;
    [Column("prixUnitaire", TypeName = "decimal(18, 2)")]

    [Range(0, 10000)]
    public decimal PrixUnitaire { get; set; }

    [StringLength(50, MinimumLength = 5)]
    public string Description { get; set; } = string.Empty;

    public int IdCategorie { get; set; }

}
