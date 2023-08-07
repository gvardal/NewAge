using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UykonumTuru
{
    public byte KonumTuruId { get; set; }

    public string? Ad { get; set; }

    public virtual ICollection<Uykonum> Uykonums { get; set; } = new List<Uykonum>();
}
