using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SateslimAlinacakSiparisDetayi
{
    public int? TeklifSiparisId { get; set; }

    public long TeklifSiparisDetayiId { get; set; }

    public long? GenelTalepId { get; set; }

    public long? MalzemeIhtiyacPlaniId { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public string? Ad { get; set; }

    public string? UrunKoduAdi { get; set; }

    public decimal? Miktar { get; set; }

    public string? OlcuBirimi { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? BirimFiyat { get; set; }

    public byte? DurumId { get; set; }

    public byte? Kdvorani { get; set; }

    public double? IskontoOrani { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public decimal? ToplamFiyat { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public byte? ParaBirimi { get; set; }

    public decimal? DovizKarsiligi { get; set; }

    public decimal? KurOrani { get; set; }

    public string? Aciklama { get; set; }

    public string? EkAciklama { get; set; }

    public bool? SiparisOnayi { get; set; }

    public bool? TeklifOnayi { get; set; }

    public long HareketReferansiId { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public decimal? TeslimatMiktari { get; set; }

    public int? KonumId { get; set; }

    public string? KontrolSonucu { get; set; }

    public long? UygunsuzUrunHizmetId { get; set; }

    public int? TeslimAlanCalisanId { get; set; }

    public string? AdiSoyadi { get; set; }

    public long? IrsaliyeNo { get; set; }

    public string? KonumKoduAdi { get; set; }

    public bool? Irsaliyelendirildi { get; set; }

    public bool? Faturalandirildi { get; set; }

    public int? UrunId { get; set; }

    public int? OlcuBirimiId { get; set; }

    public string? TalepDurumu { get; set; }

    public bool? OnKabul { get; set; }

    public int? ProjeId { get; set; }

    public string? TeslimatHareketiAciklamasi { get; set; }
}
