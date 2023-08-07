using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Miysahesaplar
{
    public int Id { get; set; }

    public byte? FirmaId { get; set; }

    public int? HesapSahibi { get; set; }

    public string? HesapTuru { get; set; }

    public short? TicariIslemGrubuId { get; set; }

    public short? HesapKategorisi { get; set; }

    public string? HesapKodu { get; set; }

    public int? OncekiHesapKodu { get; set; }

    public byte[]? Logo { get; set; }

    public string? FirmaAdi { get; set; }

    public string? UnvanIi { get; set; }

    public bool? Aktif { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Unvani { get; set; }

    public string? HesapKaynagi { get; set; }

    public long? Kampanya { get; set; }

    public short? Sektor { get; set; }

    public string? YillikKazanc { get; set; }

    public byte? PotansiyelHesapTuru { get; set; }

    public byte? MusteriTuru { get; set; }

    public string? IsModeli { get; set; }

    public byte? TedarikciTuru { get; set; }

    public bool? Oncelikli { get; set; }

    public string? Uyari { get; set; }

    public string? MusteriDurumu { get; set; }

    public string? Degerlendirme { get; set; }

    public short? CalisanSayisi { get; set; }

    public short? SubeSayisi { get; set; }

    public short? AracSayisi { get; set; }

    public byte? MakineTezgahSayisi { get; set; }

    public DateTime? TalepTarihi { get; set; }

    public DateTime? SonrakiGorusmeTarihi { get; set; }

    public string? IlgilenilenUrun { get; set; }

    public string? MevcutYazilimlar { get; set; }

    public bool? YeniYazilim { get; set; }

    public string? YazilimSuresi { get; set; }

    public string? Aciklama { get; set; }

    public string? MusteriOzellikleri { get; set; }

    public string? VergiDairesi { get; set; }

    public short? VergiDairesiId { get; set; }

    public string? VergiNo { get; set; }

    public string? HarcamaBirimiVergiNo { get; set; }

    public string? Duns { get; set; }

    public string? MersisNo { get; set; }

    public string? Nacekodu { get; set; }

    public string? Telefon1 { get; set; }

    public string? Telefon2 { get; set; }

    public string? Telefon3 { get; set; }

    public string? Gsm { get; set; }

    public string? Faks { get; set; }

    public string? EPosta { get; set; }

    public string? EFaturaPketiketi { get; set; }

    public string? Evdadresi { get; set; }

    public string? KayitliElektronikPostaKep { get; set; }

    public string? Fgbmektup { get; set; }

    public string? Fgbbsmutabakat { get; set; }

    public string? Fgbbamutabakat { get; set; }

    public string? FgbteklifSozlesme { get; set; }

    public string? Fgbekstre { get; set; }

    public int? RbvergiLevhasi { get; set; }

    public int? RbticariSicilGazetesi { get; set; }

    public int? RbimzaSirkusu { get; set; }

    public int? RbbankaHesapBilgileri { get; set; }

    public string? Sifresi { get; set; }

    public string? WebSite { get; set; }

    public string? Fadres { get; set; }

    public int? Fsehir { get; set; }

    public int? Filce { get; set; }

    public string? Fsemt { get; set; }

    public string? FpostaKodu { get; set; }

    public short? Fulke { get; set; }

    public bool? EBulten { get; set; }

    public int? YmcagriDestekSuresi { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifre { get; set; }

    public string? UzakMasaIp { get; set; }

    public string? UmkullaniciAdi { get; set; }

    public string? Umsifre { get; set; }

    public string? EvdwebServisAdresi { get; set; }

    public string? EvdkullaniciAdi { get; set; }

    public string? Evdsifre { get; set; }

    public bool? DovizFaturasi { get; set; }

    public byte? ParaBirimi { get; set; }

    /// <summary>
    /// Alış=True Satış =False
    /// </summary>
    public bool? AlisSatisKuru { get; set; }

    public decimal? KurOrani { get; set; }

    public int? BdsatisHesabi { get; set; }

    public byte? SyvadeKoduId { get; set; }

    public byte? SavadeKoduId { get; set; }

    public string? VadeBaslangici { get; set; }

    public bool? Tevkifatli { get; set; }

    public byte? VergiGrubuId { get; set; }

    public string? FiyatListesi { get; set; }

    public decimal? KrediDegerlendirmesi { get; set; }

    public decimal? KrediLimiti { get; set; }

    public string? KrediGorusu { get; set; }

    public string? OdemeGunu { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Onaylandi { get; set; }

    public DateTime? MusteriOlmaTarihi { get; set; }

    public bool? AlacakDekontlari { get; set; }

    public bool? BorcDekontlari { get; set; }

    public bool? MaliDurumlar { get; set; }

    public string? OzelTalimatlar { get; set; }

    public int? KonumId { get; set; }

    public decimal? SevkiyatAdresi { get; set; }

    public decimal? AmbarSevkiyatAdresi { get; set; }

    public short? SevkiyatSekli { get; set; }

    public byte? TeslimSartiId { get; set; }

    public int? AmbarKodu { get; set; }

    public byte? RotaBilgisi1 { get; set; }

    public byte? RotaBilgisi2 { get; set; }

    public byte? RotaBilgisi3 { get; set; }

    public string? TasimaOdemesi { get; set; }

    public bool? UyelikDurumu { get; set; }

    public bool? SecmeListesiGerekli { get; set; }

    public bool? PaketlemeListesiGerekli { get; set; }

    public bool? OzelMarkaGerekli { get; set; }

    public bool? MusteriUrunKodlariGerekli { get; set; }

    public bool? SevkiyatOncesiOnayGerekli { get; set; }

    public bool? DepoNumaralariGerekli { get; set; }

    public bool? DepartmanNumaralariGerekli { get; set; }

    public byte? SevkiyatSuresi { get; set; }

    public string? OzelSevkiyatTalimatlari { get; set; }

    public string? RotaNotu { get; set; }

    public decimal? Gpsenlem { get; set; }

    public decimal? Gpsboylam { get; set; }

    public bool? Iskonto { get; set; }

    public double? IskontoOrani { get; set; }

    public int? IskontoBdhesabi { get; set; }

    public string? IskontoNotu { get; set; }

    public double? KomisyonOrani { get; set; }

    public string? FtedarikciKodu { get; set; }

    public string? UtskurumKodu { get; set; }

    public bool? YeniMagzaIndirimi { get; set; }

    public double? YeniMagzaIndirimOrani { get; set; }

    public int? YmindirimBdhesabi { get; set; }

    public string? YmindirimNotu { get; set; }

    public bool? Ambar { get; set; }

    public double? AmbarOrani { get; set; }

    public int? AmbarIndirimiBdhesabi { get; set; }

    public string? AmbarIndirimNotu { get; set; }

    public int? IsOrtagi { get; set; }

    public string? TedarikciDegerlendirme { get; set; }

    public string? VarlikTuru { get; set; }

    public bool EfaturaMukellefi { get; set; }

    public string? EFaturaProfili { get; set; }

    public string? EFaturaSenaryo { get; set; }

    public string? AdiSoyadi { get; set; }

    public int? AlicilarHesapKodu { get; set; }

    public int? SaticilarHesapKodu { get; set; }

    public int? FyihracatAlacaklarHesapKoduId { get; set; }

    public int? FyihracatGelirlerHesapKoduId { get; set; }

    public int? FysatisHesabiId { get; set; }

    public int? FymasrafMerkeziId { get; set; }

    public byte? Ibanbanka1 { get; set; }

    public string? HesapNo1 { get; set; }

    public string? Ibanno1 { get; set; }

    public byte? Ibanno1ParaBirimi { get; set; }

    public byte? Ibanbanka2 { get; set; }

    public string? HesapNo2 { get; set; }

    public string? Ibanno2 { get; set; }

    public byte? Ibanno2ParaBirimi { get; set; }

    public byte? Ibanbanka3 { get; set; }

    public string? HesapNo3 { get; set; }

    public string? Ibanno3 { get; set; }

    public byte? Ibanno3ParaBirimi { get; set; }

    public byte? Ibanbanka4 { get; set; }

    public string? HesapNo4 { get; set; }

    public string? Ibanno4 { get; set; }

    public byte? Ibanno4ParaBirimi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? EkAlan1 { get; set; }

    public string? EkAlan2 { get; set; }

    public string? EkAlan3 { get; set; }

    public string? EkAlan4 { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public DateTime? SonGuncellemeTarihi { get; set; }

    public virtual FyhesapPlani? AlicilarHesapKoduNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenet> FcekSenetAlinanHesaps { get; set; } = new List<FcekSenet>();

    public virtual ICollection<FcekSenet> FcekSenetVerilenHesaps { get; set; } = new List<FcekSenet>();

    public virtual ICollection<Fdemirba> FdemirbaKalibrasyonFirmasis { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaMiysahesaplars { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaMusteris { get; set; } = new List<Fdemirba>();

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmets { get; set; } = new List<FdemirbasZimmet>();

    public virtual Pilceler? FilceNavigation { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriHesapKoduNavigations { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriVirmanYapilanHesaps { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual Psehirler? FsehirNavigation { get; set; }

    public virtual Pulkeler? FulkeNavigation { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<Fyefatura> Fyefaturas { get; set; } = new List<Fyefatura>();

    public virtual ICollection<Fyfatura> FyfaturaMusteriKodus { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaTasiyiciFirmas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FygumrukBeyannamesi> FygumrukBeyannamesis { get; set; } = new List<FygumrukBeyannamesi>();

    public virtual FyhesapFinansBilgisi? FyhesapFinansBilgisi { get; set; }

    public virtual FyhesapPlani? FyihracatAlacaklarHesapKodu { get; set; }

    public virtual FyhesapPlani? FyihracatGelirlerHesapKodu { get; set; }

    public virtual ICollection<FykasaIslemleri> FykasaIslemleris { get; set; } = new List<FykasaIslemleri>();

    public virtual PFymasrafMerkezi? FymasrafMerkezi { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeHesaps { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeVirmanYapilanHesaps { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual MiysahesapKategorileri? HesapKategorisiNavigation { get; set; }

    public virtual Ikcalisanlar? HesapSahibiNavigation { get; set; }

    public virtual MiysahesapTuru? HesapTuruNavigation { get; set; }

    public virtual PFbankalar? Ibanbanka1Navigation { get; set; }

    public virtual PFbankalar? Ibanbanka2Navigation { get; set; }

    public virtual PFbankalar? Ibanbanka3Navigation { get; set; }

    public virtual PFbankalar? Ibanbanka4Navigation { get; set; }

    public virtual PparaBirimi? Ibanno1ParaBirimiNavigation { get; set; }

    public virtual PparaBirimi? Ibanno2ParaBirimiNavigation { get; set; }

    public virtual PparaBirimi? Ibanno3ParaBirimiNavigation { get; set; }

    public virtual PparaBirimi? Ibanno4ParaBirimiNavigation { get; set; }

    public virtual ICollection<IiziyaretciKayit> IiziyaretciKayits { get; set; } = new List<IiziyaretciKayit>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Miysahesaplar> InverseIsOrtagiNavigation { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> InverseOncekiHesapKoduNavigation { get; set; } = new List<Miysahesaplar>();

    public virtual Miysahesaplar? IsOrtagiNavigation { get; set; }

    public virtual Miykampanyalar? KampanyaNavigation { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual ICollection<KssatisSatinAlmaPlani> KssatisSatinAlmaPlanis { get; set; } = new List<KssatisSatinAlmaPlani>();

    public virtual ICollection<KycatikToplamaKayitlari> KycatikToplamaKayitlariBaliciAtikFirmas { get; set; } = new List<KycatikToplamaKayitlari>();

    public virtual ICollection<KycatikToplamaKayitlari> KycatikToplamaKayitlariBtasiyiciAtikFirmas { get; set; } = new List<KycatikToplamaKayitlari>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlanis { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<MiyambarBilgisi> MiyambarBilgisis { get; set; } = new List<MiyambarBilgisi>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarAltYuklenicis { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarIsOrtagiNavigations { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarMusteriKoduNavigations { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplaris { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyisbitirmeBelgeleri> MiyisbitirmeBelgeleris { get; set; } = new List<MiyisbitirmeBelgeleri>();

    public virtual ICollection<Miykampanyalar> MiykampanyalarIsOrtagiNavigations { get; set; } = new List<Miykampanyalar>();

    public virtual ICollection<Miykampanyalar> MiykampanyalarMusteris { get; set; } = new List<Miykampanyalar>();

    public virtual ICollection<MiymusteriOzellikleri> MiymusteriOzellikleris { get; set; } = new List<MiymusteriOzellikleri>();

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclaris { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesis { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual ICollection<MiysahesapKategoriIskontolari> MiysahesapKategoriIskontolaris { get; set; } = new List<MiysahesapKategoriIskontolari>();

    public virtual ICollection<MiysahesapSahibiGecmisi> MiysahesapSahibiGecmisis { get; set; } = new List<MiysahesapSahibiGecmisi>();

    public virtual MiymusteriDurumu? MusteriDurumuNavigation { get; set; }

    public virtual Miysahesaplar? OncekiHesapKoduNavigation { get; set; }

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual PpotansiyelMusteriTuru? PotansiyelHesapTuruNavigation { get; set; }

    public virtual ICollection<PsevkiyatYontemi> PsevkiyatYontemis { get; set; } = new List<PsevkiyatYontemi>();

    public virtual ICollection<Pyprojeler> PyprojelerIlgiliKurumNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerIsOrtagiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerMusteris { get; set; } = new List<Pyprojeler>();

    public virtual Dybyevraklar? RbbankaHesapBilgileriNavigation { get; set; }

    public virtual Dybyevraklar? RbimzaSirkusuNavigation { get; set; }

    public virtual Dybyevraklar? RbticariSicilGazetesiNavigation { get; set; }

    public virtual Dybyevraklar? RbvergiLevhasiNavigation { get; set; }

    public virtual PLyrotaBilgisi? RotaBilgisi1Navigation { get; set; }

    public virtual PLyrotaBilgisi? RotaBilgisi2Navigation { get; set; }

    public virtual PLyrotaBilgisi? RotaBilgisi3Navigation { get; set; }

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmes { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SateklifSipari> SateklifSipariIsOrtagiKoduNavigations { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariTedarikciKoduNavigations { get; set; } = new List<SateklifSipari>();

    public virtual FyhesapPlani? SaticilarHesapKoduNavigation { get; set; }

    public virtual PSavadeler? SavadeKodu { get; set; }

    public virtual Psektoru? SektorNavigation { get; set; }

    public virtual PsevkiyatYontemi? SevkiyatSekliNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Syrakipler> Syrakiplers { get; set; } = new List<Syrakipler>();

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<Sysiparisler> SysiparislerIsOrtagiKoduNavigations { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerMusteriKodus { get; set; } = new List<Sysiparisler>();

    public virtual PSyvadeler? SyvadeKodu { get; set; }

    public virtual PtedarikciTuru? TedarikciTuruNavigation { get; set; }

    public virtual PLyteslimSarti? TeslimSarti { get; set; }

    public virtual PFyticariIslemGrubu? TicariIslemGrubu { get; set; }

    public virtual ICollection<UrunYorumlari> UrunYorumlaris { get; set; } = new List<UrunYorumlari>();

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsivis { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmri> UyisEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisis { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UysgrafikTasarim> UysgrafikTasarims { get; set; } = new List<UysgrafikTasarim>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiTaserons { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiTasiyiciFirmas { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiUretimFirmas { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyurunRotasi> UyurunRotasis { get; set; } = new List<UyurunRotasi>();

    public virtual PMiysavarlikTuru? VarlikTuruNavigation { get; set; }

    public virtual PFyvergiDaireleri? VergiDairesiNavigation { get; set; }

    public virtual PMiysavergiTuru? VergiGrubu { get; set; }

    public virtual ICollection<Ymcanlilar> Ymcanlilars { get; set; } = new List<Ymcanlilar>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniMusteriKodus { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniTasiyiciFirmas { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsiviMusteri1s { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsiviMusteri2s { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsiviMusteris { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsiviTedarikcis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanterMusteri1s { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanterMusteri2s { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanterMusteris { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanterTedarikcis { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleris { get; set; } = new List<YmmusteriIstekSikayetleri>();
}
