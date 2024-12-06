using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class PromoPlat
{
    public int Idevenement { get; set; }

    public int Idplat { get; set; }

    public DateTime Datedebut { get; set; }

    public DateTime Datefin { get; set; }

    public virtual Evenement IdevenementNavigation { get; set; } = null!;

    public virtual Plat IdplatNavigation { get; set; } = null!;
}
