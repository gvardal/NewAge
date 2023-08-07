using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTumSiparisDetayiBilgileri
{
    public byte? FirmaId { get; set; }

    public long SiparisDetayiId { get; set; }

    public int? SiparisKodu { get; set; }

    public string? UrunKodu { get; set; }

    public string? Upc { get; set; }

    public string? UrunAdi { get; set; }

    public string? UrunKoduAdi { get; set; }

    public string? ResimNo { get; set; }

    public string? FirmaAdi { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public string? OlcuBirimi { get; set; }

    public decimal? BirimFiyati { get; set; }

    public double? IskontoOrani { get; set; }

    public string? VergiTuru { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? DovizFiyati { get; set; }

    public decimal? Kur { get; set; }

    public string? Sembolu { get; set; }

    public string? ParaBirimi { get; set; }

    public decimal? BirimMaliyeti { get; set; }

    public string? Aciklama { get; set; }

    public string? GizliAciklama { get; set; }

    public string? SiparisDetayiDurum { get; set; }

    public string? SiparisDurum { get; set; }

    public decimal? SevkEdilenMiktar { get; set; }

    public int? UrunId { get; set; }

    public byte? SiparisDurumId { get; set; }

    public int? Id { get; set; }

    public string? MusteriSatinAlmaNo { get; set; }

    public DateTime? TeklifTarihi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? OnGorulenTeslimTarihi { get; set; }

    public decimal? StokMiktarı { get; set; }

    public bool? Onaylandi { get; set; }

    public string? Konu { get; set; }

    public string SiparisKoduTuru { get; set; } = null!;

    public byte? SiparisDetayiDurumId { get; set; }

    public bool? Secili { get; set; }

    public int? Hafta { get; set; }

    public double? BakiyeTutar { get; set; }

    public DateTime? OnGorulenSevkiyatTarihi { get; set; }

    public string? AmbarBilgisi { get; set; }

    public string? YontemAdiKodu { get; set; }

    public int? SecenId { get; set; }

    public int? MusteriKoduId { get; set; }

    public string? UrunKategorisi { get; set; }

    public string? SiparisAlan { get; set; }

    public int? KalanGun { get; set; }

    public bool? GecikmeCezasi { get; set; }
}
