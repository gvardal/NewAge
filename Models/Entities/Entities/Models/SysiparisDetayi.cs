using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SysiparisDetayi
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

    public byte? GarantiSuresi { get; set; }

    public string? GarantiAciklamasi { get; set; }

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

    public virtual PSysiparisDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual PolcuBirimleri? IiolcuBirimi { get; set; }

    public virtual UyurunKategorisi? KategoriKoduNavigation { get; set; }

    public virtual PMiysavergiTuru? KdvOraniNavigation { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual FyhesapPlani? MuhasebeHesap { get; set; }

    public virtual PolcuBirimleri? OlcuBirimiNavigation { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Pyprojeler? ProjeKoduNavigation { get; set; }

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual Sysiparisler? SiparisKoduNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<SysiparisDetayiOpsiyon> SysiparisDetayiOpsiyons { get; set; } = new List<SysiparisDetayiOpsiyon>();

    public virtual ICollection<SysiparisUrunOzellikOpsiyonlari> SysiparisUrunOzellikOpsiyonlaris { get; set; } = new List<SysiparisUrunOzellikOpsiyonlari>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlanis { get; set; } = new List<SyteslimatPlani>();

    public virtual PFytevkifatTurleri? TevkifatTuru { get; set; }

    public virtual UyurunAgaci? UrunAgaci { get; set; }

    public virtual Uyurunler? UrunKoduNavigation { get; set; }

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisis { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();

    public virtual PFyvergiIstisnaSebebi? VergiMuafiyetSebebi { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
