using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst_Simple.Entites;

[Table("T_BonCommande")]
public partial class TBonCommande
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("dateCommande")]
    public DateOnly? DateCommande { get; set; }

    [Column("_idClient")]
    public int? IdClient { get; set; }

    [Column("etatCommande")]
    public int? EtatCommande { get; set; }

    [ForeignKey("IdClient")]
    [InverseProperty("TBonCommandes")]
    public virtual TClient? IdClientNavigation { get; set; }

    [InverseProperty("IdCommandeNavigation")]
    public virtual ICollection<TDetailCommande> TDetailCommandes { get; set; } = new List<TDetailCommande>();
}
