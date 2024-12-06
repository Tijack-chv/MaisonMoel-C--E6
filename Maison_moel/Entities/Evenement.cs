using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Evenement
{
    public int IdEvenement { get; set; }

    public int IdTypeEvenement { get; set; }

    public string DescritionEvenement { get; set; } = null!;

    public string? ImageEvenement { get; set; }

    public virtual TypeEvenement IdTypeEvenementNavigation { get; set; } = null!;
}
