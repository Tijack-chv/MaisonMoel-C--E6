using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Plat
{
    public int Idplat { get; set; }

    public int Idcategorieplat { get; set; }

    public int Idtypeplat { get; set; }

    public string Nomplat { get; set; } = null!;

    public virtual ICollection<Comporter> Comporters { get; set; } = new List<Comporter>();

    public virtual CategoriePlat IdcategorieplatNavigation { get; set; } = null!;

    public virtual TypePlat IdtypeplatNavigation { get; set; } = null!;

    public virtual ICollection<PromoPlat> PromoPlats { get; set; } = new List<PromoPlat>();

    public virtual ICollection<Menu> Idmenus { get; set; } = new List<Menu>();

    public virtual ICollection<Produit> Idproduits { get; set; } = new List<Produit>();
}
