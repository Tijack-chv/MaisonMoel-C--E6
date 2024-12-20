using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Alergene
{
    public int IdAlergenes { get; set; }

    public string DescriptionAlergenes { get; set; } = null!;

    public virtual ICollection<Plat> IdPlats { get; set; } = new List<Plat>();
}
