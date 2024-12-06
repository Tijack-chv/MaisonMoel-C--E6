using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Reapprovisionnement
{
    public int Idproduit { get; set; }

    public int Idfournisseur { get; set; }

    public DateTime Dateheurereapro { get; set; }

    public int Quantitecommande { get; set; }

    public virtual Fournisseur IdfournisseurNavigation { get; set; } = null!;

    public virtual Produit IdproduitNavigation { get; set; } = null!;
}
