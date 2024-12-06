using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class Notification
{
    public int Idnotification { get; set; }

    public int Idtypenotification { get; set; }

    public string Descriptionnotification { get; set; } = null!;

    public virtual TypeNotification IdtypenotificationNavigation { get; set; } = null!;
}
