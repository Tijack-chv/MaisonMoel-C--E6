using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TokenUserApi
{
    public string Token { get; set; } = null!;

    public int IdUser { get; set; }

    public DateTime Date { get; set; }

    public virtual Personne IdUserNavigation { get; set; } = null!;
}
