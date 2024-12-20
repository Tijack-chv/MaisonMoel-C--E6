using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class PromoPlat
{
    public int IdEvenement { get; set; }

    public int IdPlat { get; set; }

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public virtual Evenement IdEvenementNavigation { get; set; } = null!;

    public virtual Plat IdPlatNavigation { get; set; } = null!;
}
