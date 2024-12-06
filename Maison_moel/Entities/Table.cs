using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Table
{
    public int IdTable { get; set; }

    public int IdTypeTable { get; set; }

    public string NomTable { get; set; } = null!;

    public int Capacite { get; set; }

    public virtual TypeTable IdTypeTableNavigation { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
