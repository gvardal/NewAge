using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VMalzemeTuketimi
{
    public long StokHareketiId { get; set; }

    public string HammaddeKoduAdi { get; set; } = null!;

    public string? EnvanterTuru { get; set; }

    public string EkleyenCalisan { get; set; } = null!;

    public DateTime HareketTarihi { get; set; }

    public decimal Miktar { get; set; }

    public long? UretimPlaniId { get; set; }

    public string ÜretilenÜrün { get; set; } = null!;
}
