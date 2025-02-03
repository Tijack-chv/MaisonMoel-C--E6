using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Commande
{
    public int IdCommande { get; set; }

    public int IdEtat { get; set; }

    public int IdReservation { get; set; }

    public int IdPersonne { get; set; }

    public DateTime DateCommande { get; set; }

    public bool EstPayer { get; set; }

    public virtual ICollection<Comporter> Comporters { get; set; } = new List<Comporter>();

    public virtual Etat IdEtatNavigation { get; set; } = null!;

    public virtual Serveur IdPersonneNavigation { get; set; } = null!;

    public virtual Reservation IdReservationNavigation { get; set; } = null!;
}
