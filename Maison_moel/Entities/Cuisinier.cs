using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Cuisinier
{
    public int IdPersonne { get; set; }

    public int? IdRole { get; set; }

    public int Salaires { get; set; }

    public virtual Personne IdPersonneNavigation { get; set; } = null!;

    public virtual RoleCuisinier? IdRoleNavigation { get; set; }
}
