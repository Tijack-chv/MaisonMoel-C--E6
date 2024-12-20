using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Reapprovisionnement
{
    public DateTime DateHeureReapro { get; set; }

    public int IdPlat { get; set; }

    public int QuantiteReapro { get; set; }

    public virtual Plat IdPlatNavigation { get; set; } = null!;
}
