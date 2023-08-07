using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUrunStokBilgisi
{
    public int UrunId { get; set; }

    public int KonumId { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public string? KonumKodu { get; set; }

    public string Ad { get; set; } = null!;

    public string? KonumKoduAdi { get; set; }

    public string? Raf { get; set; }

    public string? Bolme { get; set; }

    public decimal Miktar { get; set; }

    public string? OlcuBirimi { get; set; }

    public decimal AyrilmisMiktar { get; set; }

    public decimal? KullanilabilirMiktar { get; set; }

    public decimal? YoldakiMiktar { get; set; }

    public decimal? SatinAlmaMiktar { get; set; }

    public string? SatinAlmaOlcuBirimi { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public string? KonumTuru { get; set; }

    public int? UrunKategorisiId { get; set; }

    public string? KategoriAdi { get; set; }

    public string? UrunTuru { get; set; }
}
