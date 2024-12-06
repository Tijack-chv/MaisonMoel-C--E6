using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Serveur
{
    public int IdPersonne { get; set; }

    public int? Appreciations { get; set; }

    public int Salaires { get; set; }

    public virtual Personne IdPersonneNavigation { get; set; } = null!;
}
