using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimStokHareketi
{
    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public int? KonumId { get; set; }

    public string? Ad { get; set; }

    public string? SenkronizasyonKodu { get; set; }

    public int? UrunId { get; set; }

    public string? UrunKoduAdi { get; set; }

    public string? Upc { get; set; }

    public string? BarkodNo { get; set; }

    public string? OlcuBirimi { get; set; }

    public string StokHareketiTuruId { get; set; } = null!;

    public string? SenkronizasyonReferansi { get; set; }

    public string? Vardiya { get; set; }

    public string? Tarih { get; set; }

    public long? GirisStokHareketiLotNoId { get; set; }

    public decimal? Miktar { get; set; }
}
