using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkbordroEkOdemeTuru
{
    public byte EkOdemeTuruId { get; set; }

    public string? Aciklama { get; set; }

    public bool? HesaplamaSekli { get; set; }

    public bool? OdemeSekli { get; set; }

    public double? KatSayi { get; set; }

    public virtual ICollection<IkbordroEkOdemeler> IkbordroEkOdemelers { get; set; } = new List<IkbordroEkOdemeler>();
}
