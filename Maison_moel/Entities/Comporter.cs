using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Comporter
{
    public int IdCommande { get; set; }

    public int IdPlat { get; set; }

    public int Prix { get; set; }

    public int NbCommander { get; set; }

    public virtual Commande IdCommandeNavigation { get; set; } = null!;

    public virtual Plat IdPlatNavigation { get; set; } = null!;
}
