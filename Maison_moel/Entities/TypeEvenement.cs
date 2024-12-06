using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypeEvenement
{
    public int IdTypeEvenement { get; set; }

    public string LibelleTypeEvenement { get; set; } = null!;

    public virtual ICollection<Evenement> Evenements { get; set; } = new List<Evenement>();
}
