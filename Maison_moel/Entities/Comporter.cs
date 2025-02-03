using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Comporter
{
    public int IdCommande { get; set; }

    public int IdPlat { get; set; }

    public decimal Prix { get; set; }

    public int NbCommander { get; set; }

    public int IdEtat { get; set; }

    public virtual Commande IdCommandeNavigation { get; set; } = null!;

    public virtual Etat IdEtatNavigation { get; set; } = null!;

    public virtual Plat IdPlatNavigation { get; set; } = null!;
}
