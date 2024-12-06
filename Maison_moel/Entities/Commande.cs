using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Commande
{
    public int IdEtat { get; set; }

    public int IdReservation { get; set; }

    public int IdPersonne { get; set; }

    public DateTime DateCommande { get; set; }

    public int IdCommande { get; set; }

    public virtual Etat IdEtatNavigation { get; set; } = null!;

    public virtual Client IdPersonneNavigation { get; set; } = null!;
}
