using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikcalisanlar
{
    public int Id { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public int? HesapId { get; set; }

    public string? KontakTuru { get; set; }

    public string? Kunvani { get; set; }

    public string? Kdepartmani { get; set; }

    public DateTime? OzgecmisKayitTarihi { get; set; }

    public string? OzgecmisBasligi { get; set; }

    public string? KariyerHedefi { get; set; }

    public string? AramaKelmeleri { get; set; }

    public string? BasvuruTuru { get; set; }

    public string? TercihEdilenCalismaSekli { get; set; }

    public string? TercihEdilenCalismaPozisyon { get; set; }

    /// <summary>
    /// Beyaz ise 1 Mavi ise 0 
    /// </summary>
    public bool? CalisanTuru { get; set; }

    public bool? Personel { get; set; }

    public bool? Kontak { get; set; }

    public string? BarkodNo { get; set; }

    public string? SicilNo { get; set; }

    public string? Durumu { get; set; }

    public string? TckimlikNo { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? IlkSoyadi { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifresi { get; set; }

    public byte? BagliOlduguSube { get; set; }

    public byte? IsAlaniId { get; set; }

    public short? Birimi { get; set; }

    public short? Unvani { get; set; }

    public short? Vekaleti { get; set; }

    public string? GorevYeri { get; set; }

    public string? Sskno { get; set; }

    public string? Aktif { get; set; }

    public DateTime? SskbaslangicTarihi { get; set; }

    public DateTime? IseGirisTarihi { get; set; }

    public DateTime? AyrilmaTarihi { get; set; }

    public string? IstenCikisKodu { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Cinsiyeti { get; set; }

    public string? KanGrubu { get; set; }

    public string? MedeniDurumu { get; set; }

    public DateTime? EvlilikTarihi { get; set; }

    public string? AskerlikDurumu { get; set; }

    public DateTime? AskerlikTarihi { get; set; }

    public byte[]? Resim { get; set; }

    public string? Adresi { get; set; }

    public string? PostaKodu { get; set; }

    public int? Ilce { get; set; }

    public int? Sehir { get; set; }

    public short? Ulke { get; set; }

    public string? EPosta { get; set; }

    public string? Msn { get; set; }

    public string? EvTelefonu { get; set; }

    public string? CepTelefonu { get; set; }

    public string? IsTelefonu { get; set; }

    public string? DahiliNo { get; set; }

    public string? AcilKontakAdi { get; set; }

    public string? AcilKontakSoyadi { get; set; }

    public string? AcilKontakTelefonu { get; set; }

    public bool? OzelDurumEngelli { get; set; }

    public bool? OzelDurumHukumlu { get; set; }

    public bool? OzelDurumTeror { get; set; }

    public bool? YanginlaMucadeleEkibi { get; set; }

    public bool? AramaKurtarmaEkibi { get; set; }

    public bool? IlkYardimEkibi { get; set; }

    public string? Uyruk { get; set; }

    public string? SurucuEhliyetSinifi { get; set; }

    public bool? Cocuk { get; set; }

    public byte? CocukSayisi { get; set; }

    public bool? SaglikProblemi { get; set; }

    public string? SaglikProblemiAciklama { get; set; }

    public bool? SeyhatEdebilirlik { get; set; }

    public bool? SigaraKullanimi { get; set; }

    public bool? CokUlusluSirketDeneyimi { get; set; }

    public bool? YurtDisiDeneyimi { get; set; }

    public string? WebAdresi { get; set; }

    public string? UyeOlunanDernekKlupler { get; set; }

    public string? AlinanBursOduller { get; set; }

    public string? Yayinlar { get; set; }

    public string? Notlar { get; set; }

    public string? UcretBeklenti { get; set; }

    public string? OzgecmisDosyaYolu { get; set; }

    public byte? OdemeSikligi { get; set; }

    public string? Pdksno { get; set; }

    public byte? CalismaGrubuId { get; set; }

    public bool? MaasBayragi { get; set; }

    public string? BordroHesaplamaTuru { get; set; }

    public bool? BrutNet { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? AylikUcreti { get; set; }

    public decimal? NetUcreti { get; set; }

    public decimal? SaatlikUcreti { get; set; }

    public decimal? PrimUcreti { get; set; }

    public decimal? YemekYardimi { get; set; }

    public decimal? YolYardimi { get; set; }

    public decimal? KiraYardimi { get; set; }

    public decimal? EsYardimi { get; set; }

    public decimal? YakacakYardimi { get; set; }

    public decimal? RiskTazminati { get; set; }

    public decimal? YonetimTazminati { get; set; }

    public decimal? GiydirilmisNetUcret { get; set; }

    public decimal? ToplamIzinGunu { get; set; }

    public decimal? DevirIzinGunu { get; set; }

    public decimal? KullanilanIzinGunu { get; set; }

    public decimal? IzinGunu { get; set; }

    public decimal? ToplamIzinSaati { get; set; }

    public decimal? KullanilanIzinSaati { get; set; }

    public decimal? IzinSaati { get; set; }

    public short? RaporSaati { get; set; }

    public short? EksikSaati { get; set; }

    public short? FazlaSaati { get; set; }

    public byte? HaftasonuMesaiBakiyesi { get; set; }

    public bool? Yemek { get; set; }

    public bool? Servis { get; set; }

    public string? Beden { get; set; }

    public string? AyakkabiNumarasi { get; set; }

    public int? FymaasOdemeIslemTuruId { get; set; }

    public int? FykidemTazminatiIslemTuruId { get; set; }

    public int? FypersonelGiderleriHesabi { get; set; }

    public int? FypersonelSgkisverenHesabiId { get; set; }

    public int? FypersonelIssizlikIsVerenHesabiId { get; set; }

    public int? FypersonelPrimOdemeleriHesabiId { get; set; }

    public int? FypersonelKidemTazminatiHesabiId { get; set; }

    public int? FypersonelFazlaMesaiHesabiId { get; set; }

    public int? FyisAvansHesabi { get; set; }

    public int? FyucretAvansHesabi { get; set; }

    public int? FymasrafMerkeziId { get; set; }

    public bool? SatisTemcilsiBayragi { get; set; }

    public byte? BankaAdi { get; set; }

    public string? BankaHesapKodu { get; set; }

    public short? KonumId { get; set; }

    public int? BakimEkibiId { get; set; }

    public bool? Secili { get; set; }

    public bool? B2bizni { get; set; }

    public bool? AcikRizaOnay { get; set; }

    public bool? Kvkkonay { get; set; }

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

    public virtual PfirmaBilgisi? BagliOlduguSubeNavigation { get; set; }

    public virtual YmbakimEkibi? BakimEkibi { get; set; }

    public virtual PFbankalar? BankaAdiNavigation { get; set; }

    public virtual Ikorganizasyonlar? BirimiNavigation { get; set; }

    public virtual ICollection<BymakinaCalisan> BymakinaCalisans { get; set; } = new List<BymakinaCalisan>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlaniBakimYapanCalisans { get; set; } = new List<ByyillikBakimPlani>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlaniBildirenCalisans { get; set; } = new List<ByyillikBakimPlani>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlaniDuzenleyenCalisans { get; set; } = new List<ByyillikBakimPlani>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlaniEkleyenCalisans { get; set; } = new List<ByyillikBakimPlani>();

    public virtual IkpdkscalismaGrubu? CalismaGrubu { get; set; }

    public virtual IkcalisanDurumu? DurumuNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<DybyevrakDagitimListesi> DybyevrakDagitimListesis { get; set; } = new List<DybyevrakDagitimListesi>();

    public virtual ICollection<DybyevrakKategorileri> DybyevrakKategorileris { get; set; } = new List<DybyevrakKategorileri>();

    public virtual ICollection<Dybyevraklar> DybyevraklarByhavaleEdens { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarDegerlendirens { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarDuzenleyenCalisans { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarDyhazirlayans { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarDyiptalEdens { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarDyonaylayans { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarEkleyenCalisans { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarNotEkleyens { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> DybyevraklarSonErisenCalisans { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<DybyonayListesi> DybyonayListesis { get; set; } = new List<DybyonayListesi>();

    public virtual ICollection<DydisKaynakliDokuman> DydisKaynakliDokumen { get; set; } = new List<DydisKaynakliDokuman>();

    public virtual ICollection<DykaliteKayitlari> DykaliteKayitlaris { get; set; } = new List<DykaliteKayitlari>();

    public virtual ICollection<DyrevizyonTalebi> DyrevizyonTalebis { get; set; } = new List<DyrevizyonTalebi>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenet> FcekSenetDuzenleyenCalisans { get; set; } = new List<FcekSenet>();

    public virtual ICollection<FcekSenet> FcekSenetEkleyenCalisans { get; set; } = new List<FcekSenet>();

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisis { get; set; } = new List<FcekSenetGecmisi>();

    public virtual ICollection<FcekSenet> FcekSenetSonErisenCalisans { get; set; } = new List<FcekSenet>();

    public virtual ICollection<Fdemirba> FdemirbaDuzenleyenCalisans { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaEkleyenCalisans { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaSonErisenCalisans { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaSorumlusuNavigations { get; set; } = new List<Fdemirba>();

    public virtual ICollection<FdemirbasAmortismanlari> FdemirbasAmortismanlariDuzenleyenCalisans { get; set; } = new List<FdemirbasAmortismanlari>();

    public virtual ICollection<FdemirbasAmortismanlari> FdemirbasAmortismanlariEkleyenCalisans { get; set; } = new List<FdemirbasAmortismanlari>();

    public virtual ICollection<FdemirbasAmortismanlari> FdemirbasAmortismanlariSonErisenCalisans { get; set; } = new List<FdemirbasAmortismanlari>();

    public virtual ICollection<FdemirbasAmortismanlari> FdemirbasAmortismanlariYevmiyeKaydiYapans { get; set; } = new List<FdemirbasAmortismanlari>();

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmetEkleyenCalisans { get; set; } = new List<FdemirbasZimmet>();

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmetOnaylayans { get; set; } = new List<FdemirbasZimmet>();

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmetZimmetEdilenCalisans { get; set; } = new List<FdemirbasZimmet>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriDuzenleyenCalisans { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriEkleyenCalisans { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriSonErisenCalisans { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiDuzenleyenCalisans { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiEkleyenCalisans { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiSonErisenCalisans { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiDuzenleyenCalisans { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiEkleyenCalisans { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiSonErisenCalisans { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<Fybutce> FybutceOnaylayans { get; set; } = new List<Fybutce>();

    public virtual ICollection<Fybutce> FybutceSorumlus { get; set; } = new List<Fybutce>();

    public virtual ICollection<Fyefatura> FyefaturaAktarans { get; set; } = new List<Fyefatura>();

    public virtual ICollection<Fyefatura> FyefaturaOnayYetkilisis { get; set; } = new List<Fyefatura>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayiDuzenleyenCalisans { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayiEkleyenCalisans { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayiMusteriTemsilcisis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayiSonErisenCalisans { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<Fyfatura> FyfaturaDuzenleyenCalisans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaEkleyenCalisans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaFaturaOnayGonderens { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaFaturaOnaylayanGenelMudurs { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaFaturayiOnaylayans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaIptalEdenCalisans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaIrsDagitimElemaniNavigations { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaIrsSateslimAlanNavigations { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaIrsTeslimEdenNavigations { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaMusteriTemsilcisis { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaSonErisenCalisans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaYazdiranCalisans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaYevmiyeKaydiYapans { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FygumrukBeyannamesi> FygumrukBeyannamesiDuzenleyenCalisans { get; set; } = new List<FygumrukBeyannamesi>();

    public virtual ICollection<FygumrukBeyannamesi> FygumrukBeyannamesiEkleyenCalisans { get; set; } = new List<FygumrukBeyannamesi>();

    public virtual ICollection<FygumrukBeyannamesi> FygumrukBeyannamesiSonErisenCalisans { get; set; } = new List<FygumrukBeyannamesi>();

    public virtual ICollection<FyhesapPlani> FyhesapPlaniDuzenleyenCalisans { get; set; } = new List<FyhesapPlani>();

    public virtual ICollection<FyhesapPlani> FyhesapPlaniEkleyenCalisans { get; set; } = new List<FyhesapPlani>();

    public virtual ICollection<FyhesapPlani> FyhesapPlaniSonErisenCalisans { get; set; } = new List<FyhesapPlani>();

    public virtual FyhesapPlani? FyisAvansHesabiNavigation { get; set; }

    public virtual ICollection<FykasaIslemleri> FykasaIslemleriDuzenleyenCalisans { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleriEkleyenCalisans { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleriSonErisenCalisans { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<Fykasalar> Fykasalars { get; set; } = new List<Fykasalar>();

    public virtual PFislemTuru? FykidemTazminatiIslemTuru { get; set; }

    public virtual PFislemTuru? FymaasOdemeIslemTuru { get; set; }

    public virtual PFymasrafMerkezi? FymasrafMerkezi { get; set; }

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlaniDuzenleyenCalisans { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlaniEkleyenCalisans { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual FyhesapPlani? FypersonelFazlaMesaiHesabi { get; set; }

    public virtual FyhesapPlani? FypersonelGiderleriHesabiNavigation { get; set; }

    public virtual FyhesapPlani? FypersonelIssizlikIsVerenHesabi { get; set; }

    public virtual FyhesapPlani? FypersonelKidemTazminatiHesabi { get; set; }

    public virtual FyhesapPlani? FypersonelPrimOdemeleriHesabi { get; set; }

    public virtual FyhesapPlani? FypersonelSgkisverenHesabi { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeDuzenleyenCalisans { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeEkleyenCalisans { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeIptalEdenCalisans { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeMasrafSahibis { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeOnaylayans { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeSonErisenCalisans { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeYevmiyeKaydiYapans { get; set; } = new List<FytahsilatOdeme>();

    public virtual FyhesapPlani? FyucretAvansHesabiNavigation { get; set; }

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayiDuzenleyenCalisans { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayiEkleyenCalisans { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<FyyevmiyeDefteriDetayiMasrafMerkezleri> FyyevmiyeDefteriDetayiMasrafMerkezleriDuzenleyenCalisans { get; set; } = new List<FyyevmiyeDefteriDetayiMasrafMerkezleri>();

    public virtual ICollection<FyyevmiyeDefteriDetayiMasrafMerkezleri> FyyevmiyeDefteriDetayiMasrafMerkezleriEkleyenCalisans { get; set; } = new List<FyyevmiyeDefteriDetayiMasrafMerkezleri>();

    public virtual ICollection<FyyevmiyeDefteriDetayiMasrafMerkezleri> FyyevmiyeDefteriDetayiMasrafMerkezleriSonErisenCalisans { get; set; } = new List<FyyevmiyeDefteriDetayiMasrafMerkezleri>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayiSonErisenCalisans { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteriDuzenleyenCalisans { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteriEkleyenCalisans { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteriOnaylayans { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteriSonErisenCalisans { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<GgorevDetayi> GgorevDetayiEkleyenCalisans { get; set; } = new List<GgorevDetayi>();

    public virtual ICollection<GgorevDetayi> GgorevDetayiIlgilis { get; set; } = new List<GgorevDetayi>();

    public virtual ICollection<GgorevSorumlulari> GgorevSorumlularis { get; set; } = new List<GgorevSorumlulari>();

    public virtual ICollection<Ggorevler> GgorevlerDuzenleyenCalisans { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ggorevler> GgorevlerEkleyenCalisans { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ggorevler> GgorevlerIlgiliCalisanNavigations { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ggorevler> GgorevlerIlgiliKontakNavigations { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ggorevler> GgorevlerLydegerlendirenNavigations { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ggorevler> GgorevlerSonErisenCalisans { get; set; } = new List<Ggorevler>();

    public virtual ICollection<Ggorevler> GgorevlerSorumluNavigations { get; set; } = new List<Ggorevler>();

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual ICollection<IiaramaKaydi> IiaramaKaydis { get; set; } = new List<IiaramaKaydi>();

    public virtual ICollection<IigundemMaddesi> IigundemMaddesiSorumluCalisans { get; set; } = new List<IigundemMaddesi>();

    public virtual ICollection<IigundemMaddesi> IigundemMaddesiSorumlus { get; set; } = new List<IigundemMaddesi>();

    public virtual ICollection<IihaberBandiDagitimListesi> IihaberBandiDagitimListesis { get; set; } = new List<IihaberBandiDagitimListesi>();

    public virtual ICollection<IihaberBandiYorumlari> IihaberBandiYorumlaris { get; set; } = new List<IihaberBandiYorumlari>();

    public virtual ICollection<IihaberBandi> IihaberBandis { get; set; } = new List<IihaberBandi>();

    public virtual ICollection<Iiiletisim> IiiletisimDuzenleyenCalisans { get; set; } = new List<Iiiletisim>();

    public virtual ICollection<Iiiletisim> IiiletisimEkleyenCalisans { get; set; } = new List<Iiiletisim>();

    public virtual ICollection<Iiiletisim> IiiletisimKullanicis { get; set; } = new List<Iiiletisim>();

    public virtual ICollection<Iiiletisim> IiiletisimSonErisenCalisans { get; set; } = new List<Iiiletisim>();

    public virtual ICollection<IikullaniciGrupKatilimcilari> IikullaniciGrupKatilimcilaris { get; set; } = new List<IikullaniciGrupKatilimcilari>();

    public virtual ICollection<IitoplantiDagitimListesi> IitoplantiDagitimListesis { get; set; } = new List<IitoplantiDagitimListesi>();

    public virtual ICollection<IitoplantiKatilimcisi> IitoplantiKatilimcisis { get; set; } = new List<IitoplantiKatilimcisi>();

    public virtual ICollection<IitoplantiTutanagi> IitoplantiTutanagis { get; set; } = new List<IitoplantiTutanagi>();

    public virtual ICollection<IiziyaretciKayit> IiziyaretciKayitDuzenleyenCalisans { get; set; } = new List<IiziyaretciKayit>();

    public virtual ICollection<IiziyaretciKayit> IiziyaretciKayitEkleyenCalisans { get; set; } = new List<IiziyaretciKayit>();

    public virtual ICollection<IiziyaretciKayit> IiziyaretciKayitSonErisenCalisans { get; set; } = new List<IiziyaretciKayit>();

    public virtual ICollection<IiziyaretciKayit> IiziyaretciKayitZiyaretEdilens { get; set; } = new List<IiziyaretciKayit>();

    public virtual ICollection<IiziyaretciKayit> IiziyaretciKayitZiyaretciKontaks { get; set; } = new List<IiziyaretciKayit>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlarDuzenleyenCalisans { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlarEkleyenCalisans { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlarSonErisenCalisans { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<IkbordroAvan> IkbordroAvanAvansAlanCalisans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<IkbordroAvan> IkbordroAvanDuzenleyenCalisans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<IkbordroAvan> IkbordroAvanEkleyenCalisans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<IkbordroAvan> IkbordroAvanOnaylayans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<IkbordroAvan> IkbordroAvanSonErisenCalisans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<IkcalisanBelgeleri> IkcalisanBelgeleris { get; set; } = new List<IkcalisanBelgeleri>();

    public virtual ICollection<IkcalisanYetenekleri> IkcalisanYetenekleris { get; set; } = new List<IkcalisanYetenekleri>();

    public virtual ICollection<IkcezaSicil> IkcezaSicils { get; set; } = new List<IkcezaSicil>();

    public virtual ICollection<IkegitimBilgileri> IkegitimBilgileris { get; set; } = new List<IkegitimBilgileri>();

    public virtual ICollection<IkegitimEogrenmeTakip> IkegitimEogrenmeTakips { get; set; } = new List<IkegitimEogrenmeTakip>();

    public virtual ICollection<IkegitimKatalogu> IkegitimKataloguDuzenleyenCalisans { get; set; } = new List<IkegitimKatalogu>();

    public virtual ICollection<IkegitimKatalogu> IkegitimKataloguEkleyenCalisans { get; set; } = new List<IkegitimKatalogu>();

    public virtual ICollection<IkegitimKatalogu> IkegitimKataloguSonErisenCalisans { get; set; } = new List<IkegitimKatalogu>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesis { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimPlanlama> IkegitimPlanlamaDuzenleyenCalisans { get; set; } = new List<IkegitimPlanlama>();

    public virtual ICollection<IkegitimPlanlama> IkegitimPlanlamaEkleyenCalisans { get; set; } = new List<IkegitimPlanlama>();

    public virtual ICollection<IkegitimPlanlama> IkegitimPlanlamaOnaylayanNavigations { get; set; } = new List<IkegitimPlanlama>();

    public virtual ICollection<IkekipmanZimmet> IkekipmanZimmets { get; set; } = new List<IkekipmanZimmet>();

    public virtual ICollection<IkfazlaMesai> IkfazlaMesaiCalisans { get; set; } = new List<IkfazlaMesai>();

    public virtual ICollection<IkfazlaMesai> IkfazlaMesaiOnaylayans { get; set; } = new List<IkfazlaMesai>();

    public virtual ICollection<IkisBasvurulari> IkisBasvurularis { get; set; } = new List<IkisBasvurulari>();

    public virtual ICollection<IkisDeneyimleri> IkisDeneyimleris { get; set; } = new List<IkisDeneyimleri>();

    public virtual ICollection<IkkullaniciYetkileri> IkkullaniciYetkileriDuzenleyenCalisans { get; set; } = new List<IkkullaniciYetkileri>();

    public virtual ICollection<IkkullaniciYetkileri> IkkullaniciYetkileriEkleyenCalisans { get; set; } = new List<IkkullaniciYetkileri>();

    public virtual ICollection<IkkullaniciYetkileri> IkkullaniciYetkileriKullaniciKoduNavigations { get; set; } = new List<IkkullaniciYetkileri>();

    public virtual ICollection<IkkullaniciYetkileri> IkkullaniciYetkileriSonErisenCalisans { get; set; } = new List<IkkullaniciYetkileri>();

    public virtual ICollection<IkkursSeminerler> IkkursSeminerlers { get; set; } = new List<IkkursSeminerler>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemeCalisans { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemeDuzenleyenCalisans { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemeEkleyenCalisans { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemeSonErisenCalisans { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<Iknotlar> Iknotlars { get; set; } = new List<Iknotlar>();

    public virtual ICollection<Ikorganizasyonlar> IkorganizasyonlarDepartmanSorumlusuNavigations { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<Ikorganizasyonlar> IkorganizasyonlarDuzenleyenCalisans { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<Ikorganizasyonlar> IkorganizasyonlarEkleyenCalisans { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<Ikorganizasyonlar> IkorganizasyonlarSonErisenCalisans { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipCalisans { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipCevreDegerlendirenId2Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipCevreDegerlendirenId5Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipEnerjiDegerlendirenId2Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipEnerjiDegerlendirenId5Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipIsgdegerlendirenId2Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipIsgdegerlendirenId5Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipKaliteDegerlendirenId2Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipKaliteDegerlendirenId5Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipOryantasyonuYapans { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipSidegerlendirenId2Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipSidegerlendirenId5Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipSurecDegerlendirenId2Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakipSurecDegerlendirenId5Navigations { get; set; } = new List<IkoryantasyonTakip>();

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzinCalisans { get; set; } = new List<IkpdksbordroIzin>();

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzinDuzenleyenCalisans { get; set; } = new List<IkpdksbordroIzin>();

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzinEkleyenCalisans { get; set; } = new List<IkpdksbordroIzin>();

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzinIptalEdenCalisans { get; set; } = new List<IkpdksbordroIzin>();

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzinOnaylayans { get; set; } = new List<IkpdksbordroIzin>();

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzinSonErisenCalisans { get; set; } = new List<IkpdksbordroIzin>();

    public virtual ICollection<Ikpdksbordro> Ikpdksbordros { get; set; } = new List<Ikpdksbordro>();

    public virtual ICollection<IkpdkscalisanVardiyaPlani> IkpdkscalisanVardiyaPlaniCalisans { get; set; } = new List<IkpdkscalisanVardiyaPlani>();

    public virtual ICollection<IkpdkscalisanVardiyaPlani> IkpdkscalisanVardiyaPlaniDuzenleyenCalisans { get; set; } = new List<IkpdkscalisanVardiyaPlani>();

    public virtual ICollection<IkpdkscalisanVardiyaPlani> IkpdkscalisanVardiyaPlaniEkleyenCalisans { get; set; } = new List<IkpdkscalisanVardiyaPlani>();

    public virtual ICollection<IkpdksgirisCiki> IkpdksgirisCikis { get; set; } = new List<IkpdksgirisCiki>();

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();

    public virtual ICollection<Ikpysdonemler> IkpysdonemlerDuzenleyenCalisans { get; set; } = new List<Ikpysdonemler>();

    public virtual ICollection<Ikpysdonemler> IkpysdonemlerEkleyenCalisans { get; set; } = new List<Ikpysdonemler>();

    public virtual ICollection<Ikpysdonemler> IkpysdonemlerSonErisenCalisans { get; set; } = new List<Ikpysdonemler>();

    public virtual ICollection<Ikpysperforman> IkpysperformanCalisans { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<Ikpysperforman> IkpysperformanDegerlendirens { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<Ikpysperforman> IkpysperformanDuzenleyenCalisans { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<Ikpysperforman> IkpysperformanEkleyenCalisans { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<Ikpysperforman> IkpysperformanSonErisenCalisans { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<IkpysperformansDegerlendirme> IkpysperformansDegerlendirmes { get; set; } = new List<IkpysperformansDegerlendirme>();

    public virtual ICollection<Ikreferanslar> Ikreferanslars { get; set; } = new List<Ikreferanslar>();

    public virtual ICollection<Iksertifikalar> Iksertifikalars { get; set; } = new List<Iksertifikalar>();

    public virtual ICollection<Iksinavlar> Iksinavlars { get; set; } = new List<Iksinavlar>();

    public virtual ICollection<Ikunvanlar> IkunvanlarDuzenleyenCalisans { get; set; } = new List<Ikunvanlar>();

    public virtual ICollection<Ikunvanlar> IkunvanlarEkleyenCalisans { get; set; } = new List<Ikunvanlar>();

    public virtual ICollection<Ikunvanlar> IkunvanlarSonErisenCalisans { get; set; } = new List<Ikunvanlar>();

    public virtual ICollection<IkyabanciDil> IkyabanciDils { get; set; } = new List<IkyabanciDil>();

    public virtual ICollection<IkyasalUyumTablosu> IkyasalUyumTablosuDuzenleyenCalisans { get; set; } = new List<IkyasalUyumTablosu>();

    public virtual ICollection<IkyasalUyumTablosu> IkyasalUyumTablosuEkleyenCalisans { get; set; } = new List<IkyasalUyumTablosu>();

    public virtual ICollection<IkyasalUyumTablosu> IkyasalUyumTablosuSonErisenCalisans { get; set; } = new List<IkyasalUyumTablosu>();

    public virtual Pilceler? IlceNavigation { get; set; }

    public virtual ICollection<Ikcalisanlar> InverseDuzenleyenCalisan { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> InverseEkleyenCalisan { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> InverseSonErisenCalisan { get; set; } = new List<Ikcalisanlar>();

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PIkistenCikisKodu? IstenCikisKoduNavigation { get; set; }

    public virtual ICollection<Kshedefler> KshedeflerDegerlendirens { get; set; } = new List<Kshedefler>();

    public virtual ICollection<Kshedefler> KshedeflerDuzenleyenCalisans { get; set; } = new List<Kshedefler>();

    public virtual ICollection<Kshedefler> KshedeflerEkleyenCalisans { get; set; } = new List<Kshedefler>();

    public virtual ICollection<Kshedefler> KshedeflerOnaylayans { get; set; } = new List<Kshedefler>();

    public virtual ICollection<Kshedefler> KshedeflerSonErisenCalisans { get; set; } = new List<Kshedefler>();

    public virtual ICollection<Kshedefler> KshedeflerSorumluCalisans { get; set; } = new List<Kshedefler>();

    public virtual ICollection<KskurumsalStratejiler> KskurumsalStratejilerDuzenleyenCalisans { get; set; } = new List<KskurumsalStratejiler>();

    public virtual ICollection<KskurumsalStratejiler> KskurumsalStratejilerEkleyenCalisans { get; set; } = new List<KskurumsalStratejiler>();

    public virtual ICollection<KskurumsalStratejiler> KskurumsalStratejilerSonErisenCalisans { get; set; } = new List<KskurumsalStratejiler>();

    public virtual ICollection<KssatisSatinAlmaPlani> KssatisSatinAlmaPlanis { get; set; } = new List<KssatisSatinAlmaPlani>();

    public virtual ICollection<KsstratejikAmaclar> KsstratejikAmaclarDuzenleyenCalisans { get; set; } = new List<KsstratejikAmaclar>();

    public virtual ICollection<KsstratejikAmaclar> KsstratejikAmaclarEkleyenCalisans { get; set; } = new List<KsstratejikAmaclar>();

    public virtual ICollection<KsstratejikAmaclar> KsstratejikAmaclarSonErisenCalisans { get; set; } = new List<KsstratejikAmaclar>();

    public virtual ICollection<Ksswotanalizi> KsswotanaliziDuzenleyenCalisans { get; set; } = new List<Ksswotanalizi>();

    public virtual ICollection<Ksswotanalizi> KsswotanaliziEkleyenCalisans { get; set; } = new List<Ksswotanalizi>();

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayiDuzenleyenCalisans { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayiEkleyenCalisans { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayiSonErisenCalisans { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual ICollection<KycatikToplamaKayitlari> KycatikToplamaKayitlariDuzenleyenCalisans { get; set; } = new List<KycatikToplamaKayitlari>();

    public virtual ICollection<KycatikToplamaKayitlari> KycatikToplamaKayitlariEkleyenCalisans { get; set; } = new List<KycatikToplamaKayitlari>();

    public virtual ICollection<KycatikToplamaKayitlari> KycatikToplamaKayitlariSonErisenCalisans { get; set; } = new List<KycatikToplamaKayitlari>();

    public virtual ICollection<Kydof> KydofBildirenCalisans { get; set; } = new List<Kydof>();

    public virtual ICollection<Kydof> KydofDegerlendirens { get; set; } = new List<Kydof>();

    public virtual ICollection<Kydof> KydofFaaliyetLideris { get; set; } = new List<Kydof>();

    public virtual ICollection<Kydof> KydofOnaylayanNavigations { get; set; } = new List<Kydof>();

    public virtual ICollection<KygenelOlgunlukSeviyesi> KygenelOlgunlukSeviyesis { get; set; } = new List<KygenelOlgunlukSeviyesi>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlaniDenetlenens { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlaniDuzenleyenCalisans { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlaniEkleyenCalisans { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlaniOnaylayans { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlaniSidenetciNavigations { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlaniSonErisenCalisans { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyisKazalari> KyisKazalariCalisans { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KyisKazalari> KyisKazalariDuzenleyenCalisans { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KyisKazalari> KyisKazalariEkleyenCalisans { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlaniDuzenleyenCalisans { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlaniEkleyenCalisans { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlaniGerceklestirens { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlaniSonErisenCalisans { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<KykokNedenAnalizi> KykokNedenAnalizis { get; set; } = new List<KykokNedenAnalizi>();

    public virtual ICollection<KyolgunlukSeviyesi> KyolgunlukSeviyesis { get; set; } = new List<KyolgunlukSeviyesi>();

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();

    public virtual ICollection<KysurecSahipleri> KysurecSahipleris { get; set; } = new List<KysurecSahipleri>();

    public virtual ICollection<Kysurecler> KysureclerDuzenleyenCalisans { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kysurecler> KysureclerEkleyenCalisans { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kysurecler> KysureclerSonErisenCalisans { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Kysurecler> KysureclerSurecSahibis { get; set; } = new List<Kysurecler>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmetDuzenleyenCalisans { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmetEkleyenCalisans { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmetSonErisenCalisans { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmetTespitEdens { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<LyaracIslemi> LyaracIslemis { get; set; } = new List<LyaracIslemi>();

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();

    public virtual ICollection<MiyambarBilgisi> MiyambarBilgisiDuzenleyenCalisans { get; set; } = new List<MiyambarBilgisi>();

    public virtual ICollection<MiyambarBilgisi> MiyambarBilgisiEkleyenCalisans { get; set; } = new List<MiyambarBilgisi>();

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnaliziDuzenleyenCalisans { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnaliziEkleyenCalisans { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnaliziSonErisenCalisans { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarAnalizSorumlusus { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarDuzenleyenCalisans { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarEkleyenCalisans { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarFirsatSahibiNavigations { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarKontaks { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarSonErisenCalisans { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<MiyihaleDokumanlari> MiyihaleDokumanlariHazirlayans { get; set; } = new List<MiyihaleDokumanlari>();

    public virtual ICollection<MiyihaleDokumanlari> MiyihaleDokumanlariKontrolEdens { get; set; } = new List<MiyihaleDokumanlari>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplariAlmaSorumlus { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplariDuzenleyenCalisans { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplariEkleyenCalisans { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplariIadeSorumlus { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplariSonErisenCalisans { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyisbitirmeBelgeleri> MiyisbitirmeBelgeleris { get; set; } = new List<MiyisbitirmeBelgeleri>();

    public virtual ICollection<Miykampanyalar> MiykampanyalarDuzenleyenCalisans { get; set; } = new List<Miykampanyalar>();

    public virtual ICollection<Miykampanyalar> MiykampanyalarEkleyenCalisans { get; set; } = new List<Miykampanyalar>();

    public virtual ICollection<Miykampanyalar> MiykampanyalarKampanyaSahibiNavigations { get; set; } = new List<Miykampanyalar>();

    public virtual ICollection<Miykampanyalar> MiykampanyalarSonErisenCalisans { get; set; } = new List<Miykampanyalar>();

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclariDuzenleyenCalisans { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclariEkleyenCalisans { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclariKontaks { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclariSonErisenCalisans { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesiDuzenleyenCalisans { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesiEkleyenCalisans { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesiSonErisenCalisans { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual ICollection<MiysahesapKategoriIskontolari> MiysahesapKategoriIskontolariDuzenleyenCalisans { get; set; } = new List<MiysahesapKategoriIskontolari>();

    public virtual ICollection<MiysahesapKategoriIskontolari> MiysahesapKategoriIskontolariEkleyenCalisans { get; set; } = new List<MiysahesapKategoriIskontolari>();

    public virtual ICollection<MiysahesapKategoriIskontolari> MiysahesapKategoriIskontolariSonErisenCalisans { get; set; } = new List<MiysahesapKategoriIskontolari>();

    public virtual ICollection<MiysahesapSahibiGecmisi> MiysahesapSahibiGecmisiEkleyenCalisans { get; set; } = new List<MiysahesapSahibiGecmisi>();

    public virtual ICollection<MiysahesapSahibiGecmisi> MiysahesapSahibiGecmisiHesapSahibis { get; set; } = new List<MiysahesapSahibiGecmisi>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarDuzenleyenCalisans { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarEkleyenCalisans { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarHesapSahibiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarSonErisenCalisans { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PFymasrafMerkezi> PFymasrafMerkeziDuzenleyenCalisans { get; set; } = new List<PFymasrafMerkezi>();

    public virtual ICollection<PFymasrafMerkezi> PFymasrafMerkeziEkleyenCalisans { get; set; } = new List<PFymasrafMerkezi>();

    public virtual ICollection<PFymasrafMerkezi> PFymasrafMerkeziSonErisenCalisans { get; set; } = new List<PFymasrafMerkezi>();

    public virtual ICollection<PIkkullaniciGirisKutugu> PIkkullaniciGirisKutugus { get; set; } = new List<PIkkullaniciGirisKutugu>();

    public virtual ICollection<PIkpysanaPerformansKriteriId> PIkpysanaPerformansKriteriIdDuzenleyenCalisans { get; set; } = new List<PIkpysanaPerformansKriteriId>();

    public virtual ICollection<PIkpysanaPerformansKriteriId> PIkpysanaPerformansKriteriIdEkleyenCalisans { get; set; } = new List<PIkpysanaPerformansKriteriId>();

    public virtual ICollection<PIkpysanaPerformansKriteriId> PIkpysanaPerformansKriteriIdSonErisenCalisans { get; set; } = new List<PIkpysanaPerformansKriteriId>();

    public virtual ICollection<PIkpyssoruGrubu> PIkpyssoruGrubuDuzenleyenCalisans { get; set; } = new List<PIkpyssoruGrubu>();

    public virtual ICollection<PIkpyssoruGrubu> PIkpyssoruGrubuEkleyenCalisans { get; set; } = new List<PIkpyssoruGrubu>();

    public virtual ICollection<PIkpyssoruGrubu> PIkpyssoruGrubuSonErisenCalisans { get; set; } = new List<PIkpyssoruGrubu>();

    public virtual ICollection<PKycalisanIsKazaKutugu> PKycalisanIsKazaKutugus { get; set; } = new List<PKycalisanIsKazaKutugu>();

    public virtual ICollection<PSatedarikciDegerlendirmeDonemler> PSatedarikciDegerlendirmeDonemlerDuzenleyenCalisans { get; set; } = new List<PSatedarikciDegerlendirmeDonemler>();

    public virtual ICollection<PSatedarikciDegerlendirmeDonemler> PSatedarikciDegerlendirmeDonemlerEkleyenCalisans { get; set; } = new List<PSatedarikciDegerlendirmeDonemler>();

    public virtual ICollection<PSatedarikciDegerlendirmeDonemler> PSatedarikciDegerlendirmeDonemlerKontrolEdens { get; set; } = new List<PSatedarikciDegerlendirmeDonemler>();

    public virtual ICollection<PSatedarikciDegerlendirmeDonemler> PSatedarikciDegerlendirmeDonemlerOnaylayans { get; set; } = new List<PSatedarikciDegerlendirmeDonemler>();

    public virtual ICollection<PSatedarikciDegerlendirmeDonemler> PSatedarikciDegerlendirmeDonemlerSonErisenCalisans { get; set; } = new List<PSatedarikciDegerlendirmeDonemler>();

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<PyaksiyonBelgeleri> PyaksiyonBelgeleriDuzenleyenCalisans { get; set; } = new List<PyaksiyonBelgeleri>();

    public virtual ICollection<PyaksiyonBelgeleri> PyaksiyonBelgeleriEkleyenCalisans { get; set; } = new List<PyaksiyonBelgeleri>();

    public virtual ICollection<PyaksiyonBelgeleri> PyaksiyonBelgeleriSonErisenCalisans { get; set; } = new List<PyaksiyonBelgeleri>();

    public virtual ICollection<PyaksiyonDokumanlari> PyaksiyonDokumanlariDuzenleyenCalisans { get; set; } = new List<PyaksiyonDokumanlari>();

    public virtual ICollection<PyaksiyonDokumanlari> PyaksiyonDokumanlariEkleyenCalisans { get; set; } = new List<PyaksiyonDokumanlari>();

    public virtual ICollection<PyaksiyonDokumanlari> PyaksiyonDokumanlariSonErisenCalisans { get; set; } = new List<PyaksiyonDokumanlari>();

    public virtual ICollection<PyaksiyonHavuzuRiskleri> PyaksiyonHavuzuRiskleris { get; set; } = new List<PyaksiyonHavuzuRiskleri>();

    public virtual ICollection<PyprojeAdimiSorumlulari> PyprojeAdimiSorumlularis { get; set; } = new List<PyprojeAdimiSorumlulari>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlariDuzenleyenCalisans { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlariEkleyenCalisans { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzuDuzenleyenCalisans { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzuEkleyenCalisans { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzuSonErisenCalisans { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzuSorumluNavigations { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlariSonErisenCalisans { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlariSorumluNavigations { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydiCalisans { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydiDuzenleyenCalisans { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydiEkleyenCalisans { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydiSonErisenCalisans { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual ICollection<PyprojeHavuzu> PyprojeHavuzuDuzenleyenCalisans { get; set; } = new List<PyprojeHavuzu>();

    public virtual ICollection<PyprojeHavuzu> PyprojeHavuzuEkleyenCalisans { get; set; } = new List<PyprojeHavuzu>();

    public virtual ICollection<PyprojeHavuzuInsanKaynagi> PyprojeHavuzuInsanKaynagis { get; set; } = new List<PyprojeHavuzuInsanKaynagi>();

    public virtual ICollection<PyprojeHavuzu> PyprojeHavuzuProjeYoneticisiNavigations { get; set; } = new List<PyprojeHavuzu>();

    public virtual ICollection<PyprojeHavuzu> PyprojeHavuzuSonErisenCalisans { get; set; } = new List<PyprojeHavuzu>();

    public virtual ICollection<PyprojeInsanKaynagi> PyprojeInsanKaynagis { get; set; } = new List<PyprojeInsanKaynagi>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnaliziDuzenleyenCalisans { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnaliziEkleyenCalisans { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnaliziSonErisenCalisans { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<Pyprojeler> PyprojelerDuzenleyenCalisans { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerEkleyenCalisans { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerGuncelleyens { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerMusteriProjeYoneticisiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerProjeYoneticisiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerSonErisenCalisans { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Rrapor> RraporDuzenleyenCalisans { get; set; } = new List<Rrapor>();

    public virtual ICollection<Rrapor> RraporEkleyenCalisans { get; set; } = new List<Rrapor>();

    public virtual ICollection<Rrapor> RraporSonErisenCalisans { get; set; } = new List<Rrapor>();

    public virtual ICollection<Rrapor> RraporSonYazdiranCalisans { get; set; } = new List<Rrapor>();

    public virtual ICollection<RraporYetkisi> RraporYetkisis { get; set; } = new List<RraporYetkisi>();

    public virtual ICollection<RyacilDurumEkipleri> RyacilDurumEkipleris { get; set; } = new List<RyacilDurumEkipleri>();

    public virtual ICollection<RyacilDurumKaydi> RyacilDurumKaydiDuzenleyenCalisans { get; set; } = new List<RyacilDurumKaydi>();

    public virtual ICollection<RyacilDurumKaydi> RyacilDurumKaydiEkleyenCalisans { get; set; } = new List<RyacilDurumKaydi>();

    public virtual ICollection<RyacilDurumKaydi> RyacilDurumKaydiSonErisenCalisans { get; set; } = new List<RyacilDurumKaydi>();

    public virtual ICollection<RyacilDurumSenaryolari> RyacilDurumSenaryolariAcilDurumLideris { get; set; } = new List<RyacilDurumSenaryolari>();

    public virtual ICollection<RyacilDurumSenaryolari> RyacilDurumSenaryolariAnalizEdens { get; set; } = new List<RyacilDurumSenaryolari>();

    public virtual ICollection<RyacilDurumSenaryolari> RyacilDurumSenaryolariSonErisenCalisans { get; set; } = new List<RyacilDurumSenaryolari>();

    public virtual ICollection<RyisgfarkindalikGorusmesi> RyisgfarkindalikGorusmesiDuzenleyenCalisans { get; set; } = new List<RyisgfarkindalikGorusmesi>();

    public virtual ICollection<RyisgfarkindalikGorusmesi> RyisgfarkindalikGorusmesiEkleyenCalisans { get; set; } = new List<RyisgfarkindalikGorusmesi>();

    public virtual ICollection<RyisgfarkindalikGorusmesi> RyisgfarkindalikGorusmesiGorusens { get; set; } = new List<RyisgfarkindalikGorusmesi>();

    public virtual ICollection<RyisgfarkindalikGorusmesi> RyisgfarkindalikGorusmesiGorusulens { get; set; } = new List<RyisgfarkindalikGorusmesi>();

    public virtual ICollection<RykisiselKoruyucuDonanimlar> RykisiselKoruyucuDonanimlarDuzenleyenCalisans { get; set; } = new List<RykisiselKoruyucuDonanimlar>();

    public virtual ICollection<RykisiselKoruyucuDonanimlar> RykisiselKoruyucuDonanimlarEkleyenCalisans { get; set; } = new List<RykisiselKoruyucuDonanimlar>();

    public virtual ICollection<RykisiselKoruyucuDonanimlar> RykisiselKoruyucuDonanimlarSonErisenCalisans { get; set; } = new List<RykisiselKoruyucuDonanimlar>();

    public virtual ICollection<RymalzemeBilgiGuvenlikFormlari> RymalzemeBilgiGuvenlikFormlariDuzenleyenCalisans { get; set; } = new List<RymalzemeBilgiGuvenlikFormlari>();

    public virtual ICollection<RymalzemeBilgiGuvenlikFormlari> RymalzemeBilgiGuvenlikFormlariEkleyenCalisans { get; set; } = new List<RymalzemeBilgiGuvenlikFormlari>();

    public virtual ICollection<RymalzemeBilgiGuvenlikFormlari> RymalzemeBilgiGuvenlikFormlariSonErisenCalisans { get; set; } = new List<RymalzemeBilgiGuvenlikFormlari>();

    public virtual ICollection<RymedikalMuayeneKayitlari> RymedikalMuayeneKayitlariCalisans { get; set; } = new List<RymedikalMuayeneKayitlari>();

    public virtual ICollection<RymedikalMuayeneKayitlari> RymedikalMuayeneKayitlariHekimNavigations { get; set; } = new List<RymedikalMuayeneKayitlari>();

    public virtual ICollection<RymedikalMuayeneRandevulari> RymedikalMuayeneRandevulariCalisanNavigations { get; set; } = new List<RymedikalMuayeneRandevulari>();

    public virtual ICollection<RymedikalMuayeneRandevulari> RymedikalMuayeneRandevulariDuzenleyenCalisans { get; set; } = new List<RymedikalMuayeneRandevulari>();

    public virtual ICollection<RymedikalMuayeneRandevulari> RymedikalMuayeneRandevulariEkleyenCalisans { get; set; } = new List<RymedikalMuayeneRandevulari>();

    public virtual ICollection<RymedikalMuayeneRandevulari> RymedikalMuayeneRandevulariHekimNavigations { get; set; } = new List<RymedikalMuayeneRandevulari>();

    public virtual ICollection<RymedikalTahlil> RymedikalTahlilDuzenleyenCalisans { get; set; } = new List<RymedikalTahlil>();

    public virtual ICollection<RymedikalTahlil> RymedikalTahlilEkleyenCalisans { get; set; } = new List<RymedikalTahlil>();

    public virtual ICollection<RyreceteKayitlari> RyreceteKayitlariDuzenleyenCalisans { get; set; } = new List<RyreceteKayitlari>();

    public virtual ICollection<RyreceteKayitlari> RyreceteKayitlariEkleyenCalisans { get; set; } = new List<RyreceteKayitlari>();

    public virtual ICollection<SagirdiKontrolSonucu> SagirdiKontrolSonucuDuzenleyenCalisans { get; set; } = new List<SagirdiKontrolSonucu>();

    public virtual ICollection<SagirdiKontrolSonucu> SagirdiKontrolSonucuEkleyenCalisans { get; set; } = new List<SagirdiKontrolSonucu>();

    public virtual ICollection<SagirdiKontrolSonucu> SagirdiKontrolSonucuSonErisenCalisans { get; set; } = new List<SagirdiKontrolSonucu>();

    public virtual ICollection<Saihaleler> SaihalelerDuzenleyenCalisans { get; set; } = new List<Saihaleler>();

    public virtual ICollection<Saihaleler> SaihalelerEkleyenCalisans { get; set; } = new List<Saihaleler>();

    public virtual ICollection<Saihaleler> SaihalelerSonErisenCalisans { get; set; } = new List<Saihaleler>();

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayiDuzenleyenCalisans { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayiEkleyenCalisans { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayiSonErisenCalisans { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiDuzenleyenCalisans { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiEkleyenCalisans { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiIptalEdenNavigations { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiOnaylayanFonYoneticisis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiOnaylayans { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiSonErisenCalisans { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebiTalepEdenNavigations { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmeDegerlendirenCalisans { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmeDuzenleyenCalisans { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmeEkleyenCalisans { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmeKontrolEdens { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmeOnaylayans { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmeSonErisenCalisans { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual ICollection<SateklifSipari> SateklifSipariDuzenleyenCalisans { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariEkleyenCalisans { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariOnaylayans { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariSiparisAlans { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariSonErisenCalisans { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariTalepEdenNavigations { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariTedarikciKabulEdenNavigations { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariTeklifAlans { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSipari> SateklifSipariYetkilis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayiDuzenleyenCalisans { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayiEkleyenCalisans { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayiSiparisiOnaylayans { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayiSonErisenCalisans { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketiDuzenleyenCalisans { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketiEkleyenCalisans { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketiGirdiKaliteKontrolCalisans { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketiSonErisenCalisans { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketiTeslimAlanCalisans { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketiTeslimEdenTedarikcis { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual ICollection<Sepet> SepetEkleyenCalisans { get; set; } = new List<Sepet>();

    public virtual ICollection<Sepet> SepetKullanicis { get; set; } = new List<Sepet>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Sysasozlesmeler> SysasozlesmelerDuzenleyenCalisans { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<Sysasozlesmeler> SysasozlesmelerEkleyenCalisans { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<Sysasozlesmeler> SysasozlesmelerOnaylayanNavigations { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<Sysasozlesmeler> SysasozlesmelerSonErisenCalisans { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<Sysasozlesmeler> SysasozlesmelerYetkilis { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayiDuzenleyenCalisans { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayiEkleyenCalisans { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayiSonErisenCalisans { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<Sysiparisler> SysiparislerDuzenleyenCalisans { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerEkleyenCalisans { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerSiparisAlanId2Navigations { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerSiparisAlans { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerSonErisenCalisans { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerTeklifAlans { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerYetkilis { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlaniDuzenleyenCalisans { get; set; } = new List<SyteslimatPlani>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlaniEkleyenCalisans { get; set; } = new List<SyteslimatPlani>();

    public virtual Pulkeler? UlkeNavigation { get; set; }

    public virtual Ikunvanlar? UnvaniNavigation { get; set; }

    public virtual ICollection<UycalisanIslemTuru> UycalisanIslemTurus { get; set; } = new List<UycalisanIslemTuru>();

    public virtual ICollection<UyisAkisSoruGruplari> UyisAkisSoruGruplariDuzenleyenCalisans { get; set; } = new List<UyisAkisSoruGruplari>();

    public virtual ICollection<UyisAkisSoruGruplari> UyisAkisSoruGruplariEkleyenCalisans { get; set; } = new List<UyisAkisSoruGruplari>();

    public virtual ICollection<UyisAkisSoruGruplari> UyisAkisSoruGruplariSonErisenCalisans { get; set; } = new List<UyisAkisSoruGruplari>();

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorulariDuzenleyenCalisans { get; set; } = new List<UyisAkisSorulari>();

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorulariEkleyenCalisans { get; set; } = new List<UyisAkisSorulari>();

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorulariSonErisenCalisans { get; set; } = new List<UyisAkisSorulari>();

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileriDenetleyens { get; set; } = new List<UyisAkisVerileri>();

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileriDuzenleyenCalisans { get; set; } = new List<UyisAkisVerileri>();

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileriEkleyenCalisans { get; set; } = new List<UyisAkisVerileri>();

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsiviDuzenleyenCalisans { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsiviEkleyenCalisans { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsiviOnaylayanNavigations { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsiviSonErisenCalisans { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmri> UyisEmriDuzenleyenCalisans { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyisEmri> UyisEmriEkleyenCalisans { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyisEmri> UyisEmriOnaylayanNavigations { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviCalisans { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviDuzenleyenCalisans { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviEkleyenCalisans { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviOnaylayanNavigations { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviSonErisenCalisans { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiCalisans { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiDuzenleyenCalisans { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiEkleyenCalisans { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiOnaylayanNavigations { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiSecens { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiSonErisenCalisans { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmri> UyisEmriSonErisenCalisans { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyisciZamanKartiArsivi> UyisciZamanKartiArsivis { get; set; } = new List<UyisciZamanKartiArsivi>();

    public virtual ICollection<UyisciZamanKarti> UyisciZamanKartis { get; set; } = new List<UyisciZamanKarti>();

    public virtual ICollection<Uykonum> UykonumDuzenleyenCalisans { get; set; } = new List<Uykonum>();

    public virtual ICollection<Uykonum> UykonumEkleyenCalisans { get; set; } = new List<Uykonum>();

    public virtual ICollection<Uykonum> UykonumSonErisenCalisans { get; set; } = new List<Uykonum>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlaniDepoOnaylayans { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlaniDuzeleyenCalisans { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlaniEkleyenCalisans { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlaniOnaylayans { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlaniSonErisenCalisans { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlaniTalepEdens { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayiDuzenleyenCalisans { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayiEkleyenCalisans { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayiSonErisens { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiDuzenleyenCalisans { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiEkleyenCalisans { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymalzemeIstekFisiLotNo> UymalzemeIstekFisiLotNos { get; set; } = new List<UymalzemeIstekFisiLotNo>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiSonErisenCalisans { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiTalepEdenNavigations { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisiTeslimEdenNavigations { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisiDuzenleyenCalisans { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisiEkleyenCalisans { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisiSonErisenCalisans { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisi> UymusteriMalzemeTeslimFisiTeslimAlanCalisans { get; set; } = new List<UymusteriMalzemeTeslimFisi>();

    public virtual ICollection<UysarfMalzemeZimmet> UysarfMalzemeZimmets { get; set; } = new List<UysarfMalzemeZimmet>();

    public virtual ICollection<UystokAmbarFisi> UystokAmbarFisiDuzenleyenCalisans { get; set; } = new List<UystokAmbarFisi>();

    public virtual ICollection<UystokAmbarFisi> UystokAmbarFisiEkleyenCalisans { get; set; } = new List<UystokAmbarFisi>();

    public virtual ICollection<UystokAmbarFisi> UystokAmbarFisiOnaylayans { get; set; } = new List<UystokAmbarFisi>();

    public virtual ICollection<UystokAmbarFisi> UystokAmbarFisiSonErisenCalisans { get; set; } = new List<UystokAmbarFisi>();

    public virtual ICollection<UystokHareketi> UystokHareketiDuzenleyenCalisans { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UystokHareketi> UystokHareketiEkleyenCalisans { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UystokHareketi> UystokHareketiSonErisenCalisans { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiDuzenleyenCalisans { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiEkleyenCalisans { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiKaliteOnaylayanNavigations { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiLojistikOnaylayanNavigations { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiSevkEdenCalisans { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiSonErisenCalisans { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisiUretimOnaylayanNavigations { get; set; } = new List<UytaseronMalzemeTeslimFisi>();

    public virtual ICollection<UytaseronMalzemeTeslimHareketleri> UytaseronMalzemeTeslimHareketleriDuzenleyenCalisans { get; set; } = new List<UytaseronMalzemeTeslimHareketleri>();

    public virtual ICollection<UytaseronMalzemeTeslimHareketleri> UytaseronMalzemeTeslimHareketleriEkleyenCalisans { get; set; } = new List<UytaseronMalzemeTeslimHareketleri>();

    public virtual ICollection<UytaseronMalzemeTeslimHareketleri> UytaseronMalzemeTeslimHareketleriSonErisenCalisans { get; set; } = new List<UytaseronMalzemeTeslimHareketleri>();

    public virtual ICollection<UytoplamEkipmanEtkinligi> UytoplamEkipmanEtkinligiCalisans { get; set; } = new List<UytoplamEkipmanEtkinligi>();

    public virtual ICollection<UytoplamEkipmanEtkinligi> UytoplamEkipmanEtkinligiDuzenleyenCalisans { get; set; } = new List<UytoplamEkipmanEtkinligi>();

    public virtual ICollection<UytoplamEkipmanEtkinligi> UytoplamEkipmanEtkinligiEkleyenCalisans { get; set; } = new List<UytoplamEkipmanEtkinligi>();

    public virtual ICollection<UytoplamEkipmanEtkinligi> UytoplamEkipmanEtkinligiSonErisenCalisans { get; set; } = new List<UytoplamEkipmanEtkinligi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsiviDuzenleyenCalisans { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsiviEkleyenCalisans { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsiviOnaylayanNavigations { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsiviSonErisenCalisans { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsiviYevmiyeKaydiYapans { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlaniDuzenleyenCalisans { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyuretimPlani> UyuretimPlaniEkleyenCalisans { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyuretimPlani> UyuretimPlaniOnaylayanNavigations { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyuretimPlani> UyuretimPlaniPlanlayans { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyuretimPlani> UyuretimPlaniSonErisenCalisans { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyuretimPlani> UyuretimPlaniYevmiyeKaydiYapans { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyuretimVerileriArsivi> UyuretimVerileriArsiviCalisans { get; set; } = new List<UyuretimVerileriArsivi>();

    public virtual ICollection<UyuretimVerileriArsivi> UyuretimVerileriArsiviDuzenleyenCalisans { get; set; } = new List<UyuretimVerileriArsivi>();

    public virtual ICollection<UyuretimVerileriArsivi> UyuretimVerileriArsiviEkleyenCalisans { get; set; } = new List<UyuretimVerileriArsivi>();

    public virtual ICollection<UyuretimVerileriArsivi> UyuretimVerileriArsiviSonErisenCalisans { get; set; } = new List<UyuretimVerileriArsivi>();

    public virtual ICollection<UyuretimVerileri> UyuretimVerileriCalisans { get; set; } = new List<UyuretimVerileri>();

    public virtual ICollection<UyuretimVerileri> UyuretimVerileriDuzenleyenCalisans { get; set; } = new List<UyuretimVerileri>();

    public virtual ICollection<UyuretimVerileri> UyuretimVerileriEkleyenCalisans { get; set; } = new List<UyuretimVerileri>();

    public virtual ICollection<UyuretimVerileri> UyuretimVerileriSonErisenCalisans { get; set; } = new List<UyuretimVerileri>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciDuzenleyenCalisans { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzus { get; set; } = new List<UyurunAgaciHavuzu>();

    public virtual ICollection<UyurunAgaciPlanlama> UyurunAgaciPlanlamas { get; set; } = new List<UyurunAgaciPlanlama>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciSonErisenCalisans { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonuDuzenleyenCalisans { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonuEkleyenCalisans { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonuSonErisenCalisans { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiCalisans { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiDuzenleyenCalisans { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiEkleyenCalisans { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiSecens { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiSonErisenCalisans { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunStogu> UyurunStogus { get; set; } = new List<UyurunStogu>();

    public virtual ICollection<UyurunStokDetayi> UyurunStokDetayiDuzenleyenCalisans { get; set; } = new List<UyurunStokDetayi>();

    public virtual ICollection<UyurunStokDetayi> UyurunStokDetayiEkleyenCalisans { get; set; } = new List<UyurunStokDetayi>();

    public virtual ICollection<Uyurunler> UyurunlerDuzenleyenCalisans { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerEkleyenCalisans { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerSecens { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerSonErisenCalisans { get; set; } = new List<Uyurunler>();

    public virtual Ikunvanlar? VekaletiNavigation { get; set; }

    public virtual ICollection<YmcanliOzellikleri> YmcanliOzellikleriDuzenleyenCalisans { get; set; } = new List<YmcanliOzellikleri>();

    public virtual ICollection<YmcanliOzellikleri> YmcanliOzellikleriEkleyenCalisans { get; set; } = new List<YmcanliOzellikleri>();

    public virtual ICollection<Ymcanlilar> Ymcanlilars { get; set; } = new List<Ymcanlilar>();

    public virtual ICollection<YmmusteriBakimPlaniCanli> YmmusteriBakimPlaniCanlis { get; set; } = new List<YmmusteriBakimPlaniCanli>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniDuzenleyenCalisans { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniEkleyenCalisans { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniFinansOnaylayanNavigations { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniGenelMudurOnaylayanNavigations { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniKaliteOnaylayanNavigations { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniKontaks { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniLojistikOnaylayanNavigations { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemeDuzenleyenCalisans { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemeEkleyenCalisans { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemeKontrolEdens { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemePaketOnaylayanNavigations { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemeSonErisenCalisans { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniSofors { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniSonErisenCalisans { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlaniUretimOnaylayanNavigations { get; set; } = new List<YmmusteriBakimPlani>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUrunDuzenleyenCalisans { get; set; } = new List<YmmusteriBakimPlaniUrun>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUrunEkleyenCalisans { get; set; } = new List<YmmusteriBakimPlaniUrun>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUrunKontrolEdens { get; set; } = new List<YmmusteriBakimPlaniUrun>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanterDuzenleyenCalisans { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanterEkleyenCalisans { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriIstekSikayetleriDetayi> YmmusteriIstekSikayetleriDetayis { get; set; } = new List<YmmusteriIstekSikayetleriDetayi>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriDttalepEdens { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriDuzenleyenCalisans { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriEkleyenCalisans { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriMusteriKontakAdiSoyadiNavigations { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriSikayetiAlanNavigations { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriSonErisenCalisans { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleriSorumluNavigations { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<YmproblemCozumuTakibi> YmproblemCozumuTakibiDuzenleyenCalisans { get; set; } = new List<YmproblemCozumuTakibi>();

    public virtual ICollection<YmproblemCozumuTakibi> YmproblemCozumuTakibiEkleyenCalisans { get; set; } = new List<YmproblemCozumuTakibi>();

    public virtual ICollection<YmproblemCozumuTakibiYorumlar> YmproblemCozumuTakibiYorumlars { get; set; } = new List<YmproblemCozumuTakibiYorumlar>();

    public virtual ICollection<YmuzaktanDestek> YmuzaktanDesteks { get; set; } = new List<YmuzaktanDestek>();

    public virtual ICollection<Iknotlar> Nots { get; set; } = new List<Iknotlar>();

    public virtual ICollection<PLyrotaBilgisi> Rota { get; set; } = new List<PLyrotaBilgisi>();
}
