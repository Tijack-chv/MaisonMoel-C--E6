﻿using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Evenement
{
    public int IdEvenement { get; set; }

    public int IdTypeEvenement { get; set; }

    public string DescriptionEvenement { get; set; } = null!;

    public string? ImageEvenement { get; set; }

    public DateTime? DateEvenement { get; set; }

    public virtual TypeEvenement IdTypeEvenementNavigation { get; set; } = null!;

    public virtual ICollection<PromoPlat> PromoPlats { get; set; } = new List<PromoPlat>();
}
