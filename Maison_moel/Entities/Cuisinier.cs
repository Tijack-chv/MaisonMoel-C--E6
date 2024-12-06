using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Cuisinier
{
    public int Idpersonne { get; set; }

    public int Idrole { get; set; }

    public int Salaires { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly? Datenaiss { get; set; }

    public virtual Personne IdpersonneNavigation { get; set; } = null!;

    public virtual RoleCuisinier IdroleNavigation { get; set; } = null!;
}
