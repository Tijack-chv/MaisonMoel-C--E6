using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypeTable
{
    public int Idtypetable { get; set; }

    public string Libelletypeplat { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
