using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class RoleCuisinier
{
    public int Idrole { get; set; }

    public string Libellerole { get; set; } = null!;

    public virtual ICollection<Cuisinier> Cuisiniers { get; set; } = new List<Cuisinier>();
}
