using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Personne
{
    public int IdPersonne { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly? DateNaiss { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual ICollection<Avi> Avis { get; set; } = new List<Avi>();

    public virtual Cuisinier? Cuisinier { get; set; }

    public virtual Serveur? Serveur { get; set; }

    public virtual ICollection<TokenUserApi> TokenUserApis { get; set; } = new List<TokenUserApi>();
}
