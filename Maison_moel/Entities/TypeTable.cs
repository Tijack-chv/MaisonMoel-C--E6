using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypeTable
{
    public int IdTypeTable { get; set; }

    public string LibelleTypeTable { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
