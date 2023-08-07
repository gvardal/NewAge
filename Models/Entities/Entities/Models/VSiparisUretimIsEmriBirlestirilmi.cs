using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSiparisUretimIsEmriBirlestirilmi
{
    public int? SiparisNo { get; set; }

    public string? KonumKodu { get; set; }

    public int? KonumId { get; set; }

    public string? Ad { get; set; }

    public string? IslemAdi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public decimal? UretimMiktari { get; set; }

    public string? Aciklama { get; set; }

    public bool? MontajUrunu { get; set; }

    public string? UrunTuru { get; set; }

    public bool? UretilebilirUrun { get; set; }
}
