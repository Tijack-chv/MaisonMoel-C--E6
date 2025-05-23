﻿using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Client
{
    public int IdPersonne { get; set; }

    public int PointFidelite { get; set; }

    public string? ImageClient { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
