using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Avi
{
    public int Id { get; set; }

    public int IdPersonne { get; set; }

    public int Note { get; set; }

    public string Titre { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly Date { get; set; }

    public virtual Personne IdPersonneNavigation { get; set; } = null!;
}
