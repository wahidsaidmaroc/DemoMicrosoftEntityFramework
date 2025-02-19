using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst_Simple.Entites;

[Table("T_Client")]
public partial class TClient
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("client")]
    [StringLength(50)]
    public string? Client { get; set; }

    [Column("adresse")]
    [StringLength(50)]
    public string? Adresse { get; set; }

    [InverseProperty("IdClientNavigation")]
    public virtual ICollection<TBonCommande> TBonCommandes { get; set; } = new List<TBonCommande>();
}
