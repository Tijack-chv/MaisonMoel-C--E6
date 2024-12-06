using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Serveur
{
    public int Idpersonne { get; set; }

    public int? Appreciations { get; set; }

    public int Salaires { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly? Datenaiss { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual Personne IdpersonneNavigation { get; set; } = null!;
}
