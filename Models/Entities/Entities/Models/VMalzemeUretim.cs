using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VMalzemeUretim
{
    public long MusteriEnvanterId { get; set; }

    public string? EnvanterTuru { get; set; }

    public DateTime? StokGirisTarihi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public string? BarkodNo { get; set; }

    public decimal? Miktar { get; set; }

    public string Vardiya { get; set; } = null!;

    public string EkleyenCalisan { get; set; } = null!;
}
