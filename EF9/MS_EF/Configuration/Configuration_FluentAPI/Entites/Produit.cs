using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration_FluentAPI.Entites
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public decimal Prix { get; set; }
        public int Stock { get; set; }
        public string? URL { get; set; }
    }
}
