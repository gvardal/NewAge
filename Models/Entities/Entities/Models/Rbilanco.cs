using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Rbilanco
{
    public string HesapKoduAdi { get; set; } = null!;

    public decimal? BaslangicBakiyesi { get; set; }

    public decimal? Bakiyesi { get; set; }

    public string? HesapTuruSembol { get; set; }

    public string? HesapTuru { get; set; }

    public string KategoriKoduAdi { get; set; } = null!;

    public string? HesapSinifi { get; set; }

    public bool? HesapCarpani { get; set; }

    public int? OncekiHesapKodu { get; set; }

    public string? HesapTuruKodu { get; set; }

    public string? AktifPasif { get; set; }
}
