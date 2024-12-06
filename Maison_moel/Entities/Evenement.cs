using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Evenement
{
    public int Idevenement { get; set; }

    public int Idtypeevenement { get; set; }

    public string Descritionevenement { get; set; } = null!;

    public string? Imageevenement { get; set; }

    public virtual TypeEvenement IdtypeevenementNavigation { get; set; } = null!;

    public virtual ICollection<PromoMenu> PromoMenus { get; set; } = new List<PromoMenu>();

    public virtual ICollection<PromoPlat> PromoPlats { get; set; } = new List<PromoPlat>();
}
