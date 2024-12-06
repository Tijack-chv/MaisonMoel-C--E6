using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Commande
{
    public int Idetat { get; set; }

    public int Idtable { get; set; }

    public int Idpersonne { get; set; }

    public DateTime Datecommande { get; set; }

    public int Idcommande { get; set; }

    public virtual ICollection<Comporter> Comporters { get; set; } = new List<Comporter>();

    public virtual Etat IdetatNavigation { get; set; } = null!;

    public virtual Serveur IdpersonneNavigation { get; set; } = null!;

    public virtual Table IdtableNavigation { get; set; } = null!;
}
