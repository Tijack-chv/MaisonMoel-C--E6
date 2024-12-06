using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class PromoMenu
{
    public int Idevenement { get; set; }

    public int Idmenu { get; set; }

    public DateTime Datedebut { get; set; }

    public DateTime Datefin { get; set; }

    public virtual Evenement IdevenementNavigation { get; set; } = null!;

    public virtual Menu IdmenuNavigation { get; set; } = null!;
}
