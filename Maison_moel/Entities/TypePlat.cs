using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypePlat
{
    public int IdTypePlat { get; set; }

    public string LibelleTypePlat { get; set; } = null!;

    public virtual ICollection<Plat> Plats { get; set; } = new List<Plat>();
}
