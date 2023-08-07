using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTaseronTeslimatPlaniDetayi
{
    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public int? SiparisId { get; set; }

    public string? Konu { get; set; }

    public string? SiparisDetayiUrunKodu { get; set; }

    public long? SiparisDetayiId { get; set; }

    public short? SiraNo { get; set; }

    public long? SevkiyatPlaniId { get; set; }

    public short? TeslimatPlaniSiraNo { get; set; }

    public decimal? TeslimatPlaniMiktar { get; set; }

    public decimal? TaserondakiMiktar { get; set; }

    public decimal? SevkEdilenMiktar { get; set; }

    public string? Durum { get; set; }

    public int? TaseronMalzemeTeslimFisiId { get; set; }

    public string? TeslimFisiAciklamasi { get; set; }

    public int? FirmaId { get; set; }

    public string? FirmaKodu { get; set; }

    public string? Taseron { get; set; }

    public int TaseronMalzemeTeslimFisiDetayiId { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? TeslimAlinanMiktar { get; set; }

    public decimal? KalanMiktar { get; set; }

    public string? TeslimFisiDetayiAciklamasi { get; set; }

    public int? UrunId { get; set; }
}
