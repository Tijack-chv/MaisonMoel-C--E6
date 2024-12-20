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

    public string? ImagePlat { get; set; }

    public virtual ICollection<Comporter> Comporters { get; set; } = new List<Comporter>();

    public virtual CategoriePlat IdCategoriePlatNavigation { get; set; } = null!;

    public virtual TypePlat IdTypePlatNavigation { get; set; } = null!;

    public virtual ICollection<PromoPlat> PromoPlats { get; set; } = new List<PromoPlat>();

    public virtual ICollection<Reapprovisionnement> Reapprovisionnements { get; set; } = new List<Reapprovisionnement>();

    public virtual ICollection<Alergene> IdAlergenes { get; set; } = new List<Alergene>();
}
