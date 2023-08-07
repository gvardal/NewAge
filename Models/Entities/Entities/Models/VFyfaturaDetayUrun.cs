using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFyfaturaDetayUrun
{
    public long FaturaDetayiId { get; set; }

    public int? SiparisKodu { get; set; }

    public int? SasiparisId { get; set; }

    public string? MusteriSatinAlmaNo { get; set; }

    public string? SeriSiraNo { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public string? FaturaKoduTuru { get; set; }

    public string? FirmaAdi { get; set; }

    public string? UrunKoduAdi { get; set; }

    public int? UrunId { get; set; }

    public decimal? Miktari { get; set; }

    public string? OlcuBirimi { get; set; }

    public string? VergiTuru { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Kur { get; set; }

    public string? FaturaDetayiAciklama { get; set; }

    public string? IsAlani { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public bool? IptalEdildi { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public long? FaturaId { get; set; }

    public long? BagliFaturaId { get; set; }

    public long? IadeFaturaId { get; set; }

    public bool? Yazdirildi { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public int? HesapId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? SasiparisDetayiId { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public double? DiskontoluBirimFiyat { get; set; }

    public decimal? DdetayToplam { get; set; }

    public string? Iso4127kodu { get; set; }

    public string? MasrafMerkeziKodu { get; set; }

    public string? MasrafMerkeziAdi { get; set; }

    public string? KonumKoduAdi { get; set; }
}
