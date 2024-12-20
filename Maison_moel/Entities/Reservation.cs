using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Reservation
{
    public int IdReservation { get; set; }

    public int IdTable { get; set; }

    public int? IdPersonne { get; set; }

    public int NbPersonnes { get; set; }

    public DateTime? DateMoment { get; set; }

    public DateTime DateReservation { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual Client? IdPersonneNavigation { get; set; }

    public virtual Table IdTableNavigation { get; set; } = null!;
}
