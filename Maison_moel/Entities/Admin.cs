using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Admin
{
    public int Idpersonne { get; set; }

    public byte[]? Profiladmin { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly? Datenaiss { get; set; }

    public virtual Personne IdpersonneNavigation { get; set; } = null!;
}
