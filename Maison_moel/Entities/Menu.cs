using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Menu
{
    public int Idmenu { get; set; }

    public string Libellemenu { get; set; } = null!;

    public virtual ICollection<PromoMenu> PromoMenus { get; set; } = new List<PromoMenu>();

    public virtual ICollection<Plat> Idplats { get; set; } = new List<Plat>();
}
