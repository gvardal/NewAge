using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Pyprojeler
{
    public int Id { get; set; }

    public byte? FirmaId { get; set; }

    public int? KurumsalHedefId { get; set; }

    public string? ProjeKodu { get; set; }

    public string? ProjeAdi { get; set; }

    public string? ProjeKisaAdi { get; set; }

    public string ProjeKoduAdi { get; set; } = null!;

    public string ProjeKoduKisaAdi { get; set; } = null!;

    public byte[]? ProjeFotosu { get; set; }

    public byte ProjeDurumu { get; set; }

    public int? ProjeTuru { get; set; }

    public string? ProjeSinifi { get; set; }

    public string? ProjeGidisati { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public int? GuncelleyenId { get; set; }

    public string? Notlar { get; set; }

    public int? ProjeYoneticisi { get; set; }

    public int? FirsatId { get; set; }

    public int? MusteriId { get; set; }

    public int? MusteriProjeYoneticisi { get; set; }

    public int? IlgiliKurum { get; set; }

    public string? ProjeYeri { get; set; }

    public string? Muhatap { get; set; }

    public string? KapsamIcinde { get; set; }

    public string? KapsamDisinda { get; set; }

    public string? ProjeCiktilari { get; set; }

    public string? IstenenSonuclar { get; set; }

    public string? Faydalar { get; set; }

    public string? Varsayimlar { get; set; }

    public string? Kisitlar { get; set; }

    public string? Pm2elKitabi { get; set; }

    public string? KrtitikBasariOlcutleri { get; set; }

    public string? KritikBasariFaktorleri { get; set; }

    public string? Aciklama { get; set; }

    public string? IsModeli { get; set; }

    public string? ProjeGereksinimi { get; set; }

    public string? BasariFaktorleri { get; set; }

    public string? ProjeNiteligi { get; set; }

    public string? ProjeHukumleri { get; set; }

    public string? EkipmanListesi { get; set; }

    public string? TeknikPersonelListesi { get; set; }

    public byte? ParaBirimi { get; set; }

    public decimal? KurOrani { get; set; }

    public decimal? Butce { get; set; }

    public decimal? SozlesmeBedeli { get; set; }

    public decimal? FiyatArtisi { get; set; }

    public decimal? FiyatEksilisi { get; set; }

    public decimal? HedeflenenKar { get; set; }

    public decimal? HedeflenenGunlukProjeUcreti { get; set; }

    public decimal? HedeflenenGunlukProjeMaliyeti { get; set; }

    public decimal? PlanlananPersonelMaliyeti { get; set; }

    public decimal? PlanlananSeyahatMaliyeti { get; set; }

    public decimal? PlanlananDonanimMaliyeti { get; set; }

    public decimal? PlanlananHizmetAlimMaliyeti { get; set; }

    public decimal? PlanlananMalzemeMaliyeti { get; set; }

    public bool? SubelerArasiSeyhat { get; set; }

    public long? TeklifKodu { get; set; }

    public int? IsOrtagi { get; set; }

    public long? OrjinalProje { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public short? IsinSuresi { get; set; }

    public string? CalismaGunu { get; set; }

    public bool? CalismaHesaplamaTuru { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public short? GerceklesenGun { get; set; }

    public decimal? GerceklesenPersonelMaliyeti { get; set; }

    public decimal? GerceklesenSeyahatMaliyeti { get; set; }

    public decimal? GerceklesenDonanimMaliyeti { get; set; }

    public decimal? GerceklesenHizmetAlimMaliyeti { get; set; }

    public decimal? GerceklesenMalzemeMaliyeti { get; set; }

    public decimal? GerceklesenTaseronFiyatArtisi { get; set; }

    public decimal? GerceklesenToplamMaliyet { get; set; }

    public int? FypersonelGiderleriHesabi { get; set; }

    public int? FyhizmetAlimGiderleri { get; set; }

    public int? FymalzemeGiderleriHesabi { get; set; }

    public int? FyfinansmanGiderleriHesabi { get; set; }

    public int? FyamortismanGiderleriHesabi { get; set; }

    public int? FyvergiResimHarclarGiderleriHesabi { get; set; }

    public int? FygenelGiderlerHesabi { get; set; }

    public int? FymasrafMerkeziId { get; set; }

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

    public string? OzelKod { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmets { get; set; } = new List<FdemirbasZimmet>();

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual FyhesapPlani? FyamortismanGiderleriHesabiNavigation { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual FyhesapPlani? FyfinansmanGiderleriHesabiNavigation { get; set; }

    public virtual FyhesapPlani? FygenelGiderlerHesabiNavigation { get; set; }

    public virtual FyhesapPlani? FyhizmetAlimGiderleriNavigation { get; set; }

    public virtual FyhesapPlani? FymalzemeGiderleriHesabiNavigation { get; set; }

    public virtual PFymasrafMerkezi? FymasrafMerkezi { get; set; }

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual FyhesapPlani? FypersonelGiderleriHesabiNavigation { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual FyhesapPlani? FyvergiResimHarclarGiderleriHesabiNavigation { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual Ikcalisanlar? Guncelleyen { get; set; }

    public virtual ICollection<IitoplantiTutanagi> IitoplantiTutanagis { get; set; } = new List<IitoplantiTutanagi>();

    public virtual ICollection<IkfazlaMesai> IkfazlaMesais { get; set; } = new List<IkfazlaMesai>();

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();

    public virtual Miysahesaplar? IlgiliKurumNavigation { get; set; }

    public virtual Miysahesaplar? IsOrtagiNavigation { get; set; }

    public virtual ICollection<KsbutceKalemleri> KsbutceKalemleris { get; set; } = new List<KsbutceKalemleri>();

    public virtual Kshedefler? KurumsalHedef { get; set; }

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();

    public virtual Miysahesaplar? Musteri { get; set; }

    public virtual Ikcalisanlar? MusteriProjeYoneticisiNavigation { get; set; }

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual PPyprojeDurumu ProjeDurumuNavigation { get; set; } = null!;

    public virtual Uyurunler? ProjeTuruNavigation { get; set; }

    public virtual Ikcalisanlar? ProjeYoneticisiNavigation { get; set; }

    public virtual ICollection<PyaksiyonBelgeleri> PyaksiyonBelgeleris { get; set; } = new List<PyaksiyonBelgeleri>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlaris { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual ICollection<PyprojeInsanKaynagi> PyprojeInsanKaynagis { get; set; } = new List<PyprojeInsanKaynagi>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnalizis { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyurunAgaci> UyurunAgacis { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleris { get; set; } = new List<YmmusteriIstekSikayetleri>();
}
