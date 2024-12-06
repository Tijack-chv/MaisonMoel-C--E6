using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class CategoriePlat
{
    public int Idcategorieplat { get; set; }

    public string Libellecategorieplat { get; set; } = null!;

    public virtual ICollection<Plat> Plats { get; set; } = new List<Plat>();
}
