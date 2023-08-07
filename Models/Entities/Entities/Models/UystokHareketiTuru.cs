using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UystokHareketiTuru
{
    public string StokHareketiTuruId { get; set; } = null!;

    public bool? GirisCikis { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();
}
