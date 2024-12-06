using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Personne
{
    public int Idpersonne { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly? Datenaiss { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Cuisinier? Cuisinier { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual Serveur? Serveur { get; set; }
}
