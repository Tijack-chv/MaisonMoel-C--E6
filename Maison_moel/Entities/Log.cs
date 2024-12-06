using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Log
{
    public int Idlogin { get; set; }

    public int? Idpersonne { get; set; }

    public string Description { get; set; } = null!;

    public virtual Personne? IdpersonneNavigation { get; set; }
}
