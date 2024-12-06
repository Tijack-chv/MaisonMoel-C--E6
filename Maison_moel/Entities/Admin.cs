using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Admin
{
    public int IdPersonne { get; set; }

    public byte[]? ProfilAdmin { get; set; }

    public virtual Personne IdPersonneNavigation { get; set; } = null!;
}
