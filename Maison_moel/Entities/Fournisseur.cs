using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Fournisseur
{
    public int Idfournisseur { get; set; }

    public string Libellefournisseur { get; set; } = null!;

    public virtual ICollection<Reapprovisionnement> Reapprovisionnements { get; set; } = new List<Reapprovisionnement>();
}
