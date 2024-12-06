using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Alergene
{
    public int Idalergenes { get; set; }

    public string Descriptionalergenes { get; set; } = null!;

    public virtual ICollection<Produit> Idproduits { get; set; } = new List<Produit>();
}
