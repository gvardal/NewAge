using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Sysiparisler
{
    public int SiparisId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public string? SiparisKodu { get; set; }

    public byte? RevizyonNo { get; set; }

    public int? OncekiSiparisId { get; set; }

    public int? MusteriIstekSikayetId { get; set; }

    public bool? OzelTeklifSiparis { get; set; }

    public int? FirsatId { get; set; }

    public byte SiparisTuru { get; set; }

    public DateTime? TeklifTarihi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public int? YetkiliId { get; set; }

    public byte? OpsiyonGunu { get; set; }

    public short? TerminGunu { get; set; }

    public DateTime? TeklifGecerlilikSuresi { get; set; }

    public bool? ParcaliSevkiyat { get; set; }

    public DateTime? PlanlananSevkiyatTarihi { get; set; }

    public DateTime? GerceklesenSevkiyatTarihi { get; set; }

    public DateTime? SiparisIptalTarihi { get; set; }

    public byte? TeklifRedSebebiId { get; set; }

    public string? RakipFirma { get; set; }

    public bool? Hatirlat { get; set; }

    public byte Durum { get; set; }

    public bool? InternetSiparisi { get; set; }

    public int? HesapKodu { get; set; }

    public int? MusteriKoduId { get; set; }

    public string? Konu { get; set; }

    public string? MusteriSatinAlmaNo { get; set; }

    public string? Uyari { get; set; }

    public string? GizliAciklama { get; set; }

    public string? Garanti { get; set; }

    public string? EkAlan { get; set; }

    public string? EkAlan1 { get; set; }

    public string? EkAlan2 { get; set; }

    public string? EkAlan3 { get; set; }

    public string? EkAlan4 { get; set; }

    public string? EkAlan5 { get; set; }

    public string? EkAlan6 { get; set; }

    public byte VadeKodu { get; set; }

    public bool? GecikmeCezasi { get; set; }

    public string? GecikmeCezasiNotu { get; set; }

    public bool? DovizFaturasi { get; set; }

    public byte? RparaBirimi { get; set; }

    public decimal? Rkuru { get; set; }

    public byte? ParaBirimi { get; set; }

    public decimal? KurOrani { get; set; }

    public decimal? AraToplam { get; set; }

    public decimal? DaraToplam { get; set; }

    public double? IskontoOrani { get; set; }

    public decimal? IskontoTutari { get; set; }

    public decimal? DiskontoTutari { get; set; }

    public double? VergiOrani { get; set; }

    public decimal? VergiTutari { get; set; }

    public decimal? DvergiTutari { get; set; }

    public decimal? Kdvtevkifati { get; set; }

    public decimal? Dkdvtevkifati { get; set; }

    public decimal? Tasima { get; set; }

    public decimal? Dtasima { get; set; }

    public decimal? Yukleme { get; set; }

    public decimal? Dyukleme { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Dtoplam { get; set; }

    public decimal? IskontoluToplam { get; set; }

    public decimal? DiskontoluToplam { get; set; }

    public decimal? Komisyon { get; set; }

    public int? IsOrtagiKodu { get; set; }

    public int? ProjeKodu { get; set; }

    public short? SevkiyatYontemi { get; set; }

    public byte? TeslimSartiId { get; set; }

    public int? AmbarSevkiyatAdresiId { get; set; }

    public string? SevkiyatNotu { get; set; }

    public int? FaturaAdresiId { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public long? BelgeId { get; set; }

    public bool? Yazdirildi { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public bool? SiparisYazdirildi { get; set; }

    public DateTime? SiparisYazdirmaTarihi { get; set; }

    public bool? Paketlendi { get; set; }

    public DateTime? PaketlemeTarihi { get; set; }

    public bool? Faturalandirildi { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public long? FaturaId { get; set; }

    public bool? Gonderildi { get; set; }

    public DateTime? GonderimTarihi { get; set; }

    public bool? Onaylandi { get; set; }

    public string? Onaylayan { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? FinansOnayi { get; set; }

    public string? FinanstanOnaylayan { get; set; }

    public int? TeklifAlanId { get; set; }

    public int? SiparisAlanId { get; set; }

    public int? SiparisAlanId2 { get; set; }

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

    public virtual MiyambarBilgisi? AmbarSevkiyatAdresi { get; set; }

    public virtual ICollection<BankaHatalari> BankaHatalaris { get; set; } = new List<BankaHatalari>();

    public virtual PSysiparisDurumu DurumNavigation { get; set; } = null!;

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual MiyambarBilgisi? FaturaAdresi { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<Sysiparisler> InverseOncekiSiparis { get; set; } = new List<Sysiparisler>();

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual Miysahesaplar? IsOrtagiKoduNavigation { get; set; }

    public virtual YmmusteriIstekSikayetleri? MusteriIstekSikayet { get; set; }

    public virtual Miysahesaplar? MusteriKodu { get; set; }

    public virtual Sysiparisler? OncekiSiparis { get; set; }

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual Pyprojeler? ProjeKoduNavigation { get; set; }

    public virtual PparaBirimi? RparaBirimiNavigation { get; set; }

    public virtual PsevkiyatYontemi? SevkiyatYontemiNavigation { get; set; }

    public virtual Ikcalisanlar? SiparisAlan { get; set; }

    public virtual Ikcalisanlar? SiparisAlanId2Navigation { get; set; }

    public virtual PsiparisTuru SiparisTuruNavigation { get; set; } = null!;

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Syrakipler> Syrakiplers { get; set; } = new List<Syrakipler>();

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual Ikcalisanlar? TeklifAlan { get; set; }

    public virtual PSayteklifIptalSebebi? TeklifRedSebebi { get; set; }

    public virtual PLyteslimSarti? TeslimSarti { get; set; }

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsivis { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmri> UyisEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisis { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual PSyvadeler VadeKoduNavigation { get; set; } = null!;

    public virtual Ikcalisanlar? Yetkili { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemes { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
