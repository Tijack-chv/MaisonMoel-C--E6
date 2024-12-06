using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Reservation
{
    public int Idpersonne { get; set; }

    public DateTime Dateheureres { get; set; }

    public int Idtable { get; set; }

    public int Nbpersonnes { get; set; }

    public virtual Client IdpersonneNavigation { get; set; } = null!;

    public virtual Table IdtableNavigation { get; set; } = null!;
}
