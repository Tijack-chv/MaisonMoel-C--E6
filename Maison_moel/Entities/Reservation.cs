using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Reservation
{
    public int IdTable { get; set; }

    public int? IdPersonne { get; set; }

    public int NbPersonnes { get; set; }

    public DateTime? DateMoment { get; set; }

    public int IdReservation { get; set; }

    public DateTime DateReservation { get; set; }

    public virtual Table IdTableNavigation { get; set; } = null!;
}
