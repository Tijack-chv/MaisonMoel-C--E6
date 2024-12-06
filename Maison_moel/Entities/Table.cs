using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Table
{
    public int Idtable { get; set; }

    public int Idtypetable { get; set; }

    public string Nomtable { get; set; } = null!;

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual TypeTable IdtypetableNavigation { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
