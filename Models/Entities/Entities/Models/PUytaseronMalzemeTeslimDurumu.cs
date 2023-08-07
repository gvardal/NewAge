using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUytaseronMalzemeTeslimDurumu
{
    public byte TaseronMalzemeTeslimDurumuId { get; set; }

    public string? Aciklama { get; set; }

    public bool? MusteriTaseron { get; set; }

    public virtual ICollection<UymusteriMalzemeTeslimFisiDetayi> UymusteriMalzemeTeslimFisiDetayis { get; set; } = new List<UymusteriMalzemeTeslimFisiDetayi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisis { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisiDetayi> UytaseronMalzemeTeslimFisiDetayis { get; set; } = new List<UytaseronMalzemeTeslimFisiDetayi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisis { get; set; } = new List<UytaseronMalzemeTeslimFisi>();
}
