using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Plat
{
    public int IdPlat { get; set; }

    public int IdCategoriePlat { get; set; }

    public int IdTypePlat { get; set; }

    public string NomPlat { get; set; } = null!;

    public int Quantite { get; set; }

    public string DescriptionPlat { get; set; } = null!;

    public decimal PrixHt { get; set; }

    public virtual CategoriePlat IdCategoriePlatNavigation { get; set; } = null!;

    public virtual TypePlat IdTypePlatNavigation { get; set; } = null!;
}
