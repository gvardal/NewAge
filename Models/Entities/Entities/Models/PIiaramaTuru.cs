using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIiaramaTuru
{
    public byte AramaTuruId { get; set; }

    public string? AramaTuru { get; set; }

    public virtual ICollection<IiaramaKaydi> IiaramaKaydis { get; set; } = new List<IiaramaKaydi>();
}
