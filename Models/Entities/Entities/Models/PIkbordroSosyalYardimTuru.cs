using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkbordroSosyalYardimTuru
{
    public byte SosyalYardimTuruId { get; set; }

    public string? Aciklama { get; set; }

    public bool? HesaplamaSekli { get; set; }

    public bool? OdemeSekli { get; set; }

    public double? KatSayi { get; set; }

    public virtual ICollection<IkbordroSosyalYardimlar> IkbordroSosyalYardimlars { get; set; } = new List<IkbordroSosyalYardimlar>();
}
