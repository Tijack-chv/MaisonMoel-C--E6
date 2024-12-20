using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypeNotification
{
    public int IdTypeNotification { get; set; }

    public string LibelleTypeNotification { get; set; } = null!;

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
