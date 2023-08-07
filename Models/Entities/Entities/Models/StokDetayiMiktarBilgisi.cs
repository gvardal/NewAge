using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class StokDetayiMiktarBilgisi
{
    public int? UrunId { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string? KonumKodu { get; set; }

    public string? Ad { get; set; }

    public string? BolmeKodu { get; set; }

    public string? BolmeAdi { get; set; }

    public decimal? Miktar { get; set; }

    public long? MusteriEnvanterId { get; set; }

    public string? BarkodNo { get; set; }
}
