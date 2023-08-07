using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSysiparisDetayi
{
    public long SiparisDetayiId { get; set; }

    public int? SiparisKodu { get; set; }

    public short? SiraNo { get; set; }

    public string? MusteriSatinAlmaDetayiNo { get; set; }

    public int? KategoriKodu { get; set; }

    public int? UrunKodu { get; set; }

    public string? SanalUrunKodu { get; set; }

    public string? SanalUrunAdi { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public decimal? Alan { get; set; }

    public decimal? ToplamAlan { get; set; }

    public int? OlcuBirimi { get; set; }

    public decimal? IisiparisMiktari { get; set; }

    public int? IiolcuBirimiId { get; set; }

    public decimal? BirimFiyati { get; set; }

    public double? IskontoOrani { get; set; }

    public byte? KdvOrani { get; set; }

    public string? VergiMuafiyetSebebiId { get; set; }

    public decimal? Kdvtutari { get; set; }

    public decimal? Dkdvtutari { get; set; }

    public decimal? KdvtevkifatiTutari { get; set; }

    public string? TevkifatTuruId { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public decimal? DiskontoluBirimFiyat { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Dtoplam { get; set; }

    public decimal? DovizFiyati { get; set; }

    public decimal? Kur { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? BirimMaliyeti { get; set; }

    public string? Aciklama { get; set; }

    public string? GizliAciklama { get; set; }

    public string? AksesuarNotu { get; set; }

    public int? ProjeKodu { get; set; }

    public int? KonumId { get; set; }

    public byte? DurumId { get; set; }

    public int? MuhasebeHesapId { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? RevizyonDosyaAdi { get; set; }

    public byte? TerminGunu { get; set; }

    public byte? OpsiyonGunu { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? OnGorulenTeslimTarihi { get; set; }

    public DateTime? OnGorulenSevkiyatTarihi { get; set; }

    public long? UrunAgaciId { get; set; }

    public decimal? SevkEdilenMiktar { get; set; }

    public int? SecenId { get; set; }

    public bool? Secili { get; set; }

    public string? CizimNo { get; set; }

    public byte? PlanlananSevkiyatAracSayisi { get; set; }

    public byte? GerceklesenSevkiyatAracSayisi { get; set; }

    public string? EkAlan1 { get; set; }

    public string? EkAlan2 { get; set; }

    public string? EkAlan3 { get; set; }

    public string? EkAlan4 { get; set; }

    public bool? Iptal { get; set; }

    public int? IptalEden { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }
}
