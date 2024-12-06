using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Comporter
{
    public int Idcommande { get; set; }

    public int Idplat { get; set; }

    public int Prix { get; set; }

    public virtual Commande IdcommandeNavigation { get; set; } = null!;

    public virtual Plat IdplatNavigation { get; set; } = null!;
}
