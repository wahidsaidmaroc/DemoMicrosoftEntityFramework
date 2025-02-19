using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst_Simple.Entites;

[Table("T_Categorie")]
public partial class TCategorie
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("categorie")]
    [StringLength(50)]
    public string? Categorie { get; set; }

    [InverseProperty("IdCategorieNavigation")]
    public virtual ICollection<TProduit> TProduits { get; set; } = new List<TProduit>();
}
