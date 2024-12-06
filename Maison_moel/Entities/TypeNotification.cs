using System;
using System.Collections.Generic;

namespace Maison_moel.Entities;

public partial class TypeNotification
{
    public int Idtypenotification { get; set; }

    public string Libelletypenotification { get; set; } = null!;

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
