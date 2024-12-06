using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Etat
{
    public int Idetat { get; set; }

    public string Libelleetat { get; set; } = null!;

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();
}
