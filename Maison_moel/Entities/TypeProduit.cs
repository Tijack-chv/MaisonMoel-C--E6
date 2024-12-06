using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypeProduit
{
    public int Idtypeproduit { get; set; }

    public string Libelletypeproduit { get; set; } = null!;

    public virtual ICollection<Produit> Produits { get; set; } = new List<Produit>();
}
