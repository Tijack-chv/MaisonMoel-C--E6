using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Message
{
    public int Id { get; set; }

    public string Message1 { get; set; } = null!;

    public int IdPersonne { get; set; }

    public DateTime Date { get; set; }

    public bool EstVue { get; set; }

    public virtual Personne IdPersonneNavigation { get; set; } = null!;
}
