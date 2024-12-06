using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class CategoriePlat
{
    public int IdCategoriePlat { get; set; }

    public string LibelleCategoriePlat { get; set; } = null!;

    public virtual ICollection<Plat> Plats { get; set; } = new List<Plat>();
}
