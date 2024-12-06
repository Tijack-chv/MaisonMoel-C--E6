using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypePlat
{
    public int Idtypeplat { get; set; }

    public string Libelletypeplat { get; set; } = null!;

    public virtual ICollection<Plat> Plats { get; set; } = new List<Plat>();
}
