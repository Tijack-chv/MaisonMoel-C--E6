﻿using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Dechet
{
    public int IdDechets { get; set; }

    public float Poids { get; set; }

    public DateTime DateSaisie { get; set; }
}
