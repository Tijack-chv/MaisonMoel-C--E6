using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Notification
{
    public int IdNotification { get; set; }

    public int IdTypeNotification { get; set; }

    public string DescriptionNotification { get; set; } = null!;
}
