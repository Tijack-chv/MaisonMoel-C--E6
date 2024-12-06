using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Produit
{
    public int Quantite { get; set; }

    public int Idproduit { get; set; }

    public string Titreproduit { get; set; } = null!;

    public string Descriptionproduit { get; set; } = null!;

    public int Prixht { get; set; }

    public int Idtypeproduit { get; set; }

    public virtual TypeProduit IdtypeproduitNavigation { get; set; } = null!;

    public virtual ICollection<Reapprovisionnement> Reapprovisionnements { get; set; } = new List<Reapprovisionnement>();

    public virtual ICollection<Alergene> Idalergenes { get; set; } = new List<Alergene>();

    public virtual ICollection<Plat> Idplats { get; set; } = new List<Plat>();
}
