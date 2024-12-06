using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class RoleCuisinier
{
    public int IdRole { get; set; }

    public string LibelleRole { get; set; } = null!;

    public virtual ICollection<Cuisinier> Cuisiniers { get; set; } = new List<Cuisinier>();
}
