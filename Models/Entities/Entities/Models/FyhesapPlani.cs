using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyhesapPlani
{
    public int HesapPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public string? HesapKodu { get; set; }

    public int? OncekiHesapKodu { get; set; }

    public int? AnaHesapKodu { get; set; }

    public string HesapKoduAdi { get; set; } = null!;

    public string? HesapAdi { get; set; }

    public string? HesapAciklamasi { get; set; }

    public bool? SabitDegisken { get; set; }

    public string? OzelKod { get; set; }

    public string? OzelKod1 { get; set; }

    public string? OzelKod2 { get; set; }

    public string? Turu { get; set; }

    public byte? Seviye { get; set; }

    public string? HesapTuru { get; set; }

    public bool? HesapCarpani { get; set; }

    public byte? HesapKategorisi { get; set; }

    public byte? ParaBirimi { get; set; }

    public double? DovizKuru { get; set; }

    public decimal? Bakiyesi { get; set; }

    public decimal? BaslangicBakiyesi { get; set; }

    public bool? Aktif { get; set; }

    public bool? HareketleriDuzenle { get; set; }

    public decimal? BorcToplam { get; set; }

    public decimal? AlacakToplam { get; set; }

    public decimal? KalanBorc { get; set; }

    public decimal? KalanAlacak { get; set; }

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

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual ICollection<Fdemirba> FdemirbaFybirikmisAmortismanMuhasebeHesabis { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaFydemirbasCikisMuhasebeHesabis { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaFydemirbasGirisMuhasebeHesabis { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> FdemirbaFygiderMuhasebeHesabis { get; set; } = new List<Fdemirba>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FybankaHesabi> FybankaHesabiMuhasabeHesapKoduNavigations { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiMuhasebeGiderHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiMuhasebeKarHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiMuhasebeYatirimHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiMuhasebeZararHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiTahsilCekleriHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiTahsilSenetleriHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiTeminatCekleriHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiTeminatSenetleriHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesabi> FybankaHesabiVerilenCeklerHesapPlanis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<Fybutce> Fybutces { get; set; } = new List<Fybutce>();

    public virtual ICollection<FyeBeyanname> FyeBeyannameKdv01s { get; set; } = new List<FyeBeyanname>();

    public virtual ICollection<FyeBeyanname> FyeBeyannameKdv08s { get; set; } = new List<FyeBeyanname>();

    public virtual ICollection<FyeBeyanname> FyeBeyannameKdv18s { get; set; } = new List<FyeBeyanname>();

    public virtual ICollection<FyeBeyanname> FyeBeyannameMatrah01s { get; set; } = new List<FyeBeyanname>();

    public virtual ICollection<FyeBeyanname> FyeBeyannameMatrah08s { get; set; } = new List<FyeBeyanname>();

    public virtual ICollection<FyeBeyanname> FyeBeyannameMatrah18s { get; set; } = new List<FyeBeyanname>();

    public virtual ICollection<FyefaturaDetay> FyefaturaDetays { get; set; } = new List<FyefaturaDetay>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleris { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<Fykasalar> Fykasalars { get; set; } = new List<Fykasalar>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayis { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual PFhesapKategorisi? HesapKategorisiNavigation { get; set; }

    public virtual PFhesapTuru? HesapTuruNavigation { get; set; }

    public virtual ICollection<IkbordroAvan> IkbordroAvans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFyisAvansHesabiNavigations { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFypersonelFazlaMesaiHesabis { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFypersonelGiderleriHesabiNavigations { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFypersonelIssizlikIsVerenHesabis { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFypersonelKidemTazminatiHesabis { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFypersonelPrimOdemeleriHesabis { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFypersonelSgkisverenHesabis { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarFyucretAvansHesabiNavigations { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<FyhesapPlani> InverseOncekiHesapKoduNavigation { get; set; } = new List<FyhesapPlani>();

    public virtual ICollection<MiysahesapTuru> MiysahesapTurus { get; set; } = new List<MiysahesapTuru>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarAlicilarHesapKoduNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarFyihracatAlacaklarHesapKodus { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarFyihracatGelirlerHesapKodus { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarSaticilarHesapKoduNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual FyhesapPlani? OncekiHesapKoduNavigation { get; set; }

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriCekMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIcekMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIicekMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIiicekMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIiisenetMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIisenetMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIsenetMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIvcekMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriIvsenetMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFcekSenetYeri> PFcekSenetYeriSenetMuhasebeHesapKodus { get; set; } = new List<PFcekSenetYeri>();

    public virtual ICollection<PFharcamaTuru> PFharcamaTurus { get; set; } = new List<PFharcamaTuru>();

    public virtual ICollection<PFislemTuruDetayi> PFislemTuruDetayis { get; set; } = new List<PFislemTuruDetayi>();

    public virtual ICollection<PFstopajKodlari> PFstopajKodlaris { get; set; } = new List<PFstopajKodlari>();

    public virtual ICollection<PFyfaturaHareketOzelKodlari> PFyfaturaHareketOzelKodlariKkegkdvmuhasebeHesaps { get; set; } = new List<PFyfaturaHareketOzelKodlari>();

    public virtual ICollection<PFyfaturaHareketOzelKodlari> PFyfaturaHareketOzelKodlariKkegmuhasebeHesaps { get; set; } = new List<PFyfaturaHareketOzelKodlari>();

    public virtual ICollection<PFygenelGiderHesapPlani> PFygenelGiderHesapPlanis { get; set; } = new List<PFygenelGiderHesapPlani>();

    public virtual ICollection<PFyvergiGrubuDetayi> PFyvergiGrubuDetayiSatinAlmaHesapKodus { get; set; } = new List<PFyvergiGrubuDetayi>();

    public virtual ICollection<PFyvergiGrubuDetayi> PFyvergiGrubuDetayiSatisHesapKodus { get; set; } = new List<PFyvergiGrubuDetayi>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatinAlmaHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatinAlmaIadeHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatinAlmaOdenecekHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatinAlmaTevkifatHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatisHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatisHesapTevkifatKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatisIadeHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual ICollection<PMiysavergiTuru> PMiysavergiTuruSatisOdenecekHesapKodus { get; set; } = new List<PMiysavergiTuru>();

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiFydagitilacakFiyatArttirimHesabis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiFydenklestirmeGelirHesabis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiFydenklestirmeGiderHesabis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiFymalinanMusteriCekleriNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiFympersonelGiderleriHesabiNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<Pyprojeler> PyprojelerFyamortismanGiderleriHesabiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerFyfinansmanGiderleriHesabiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerFygenelGiderlerHesabiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerFyhizmetAlimGiderleriNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerFymalzemeGiderleriHesabiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerFypersonelGiderleriHesabiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<Pyprojeler> PyprojelerFyvergiResimHarclarGiderleriHesabiNavigations { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<UydurusTuru> UydurusTuruFyamortismanGiderHesaps { get; set; } = new List<UydurusTuru>();

    public virtual ICollection<UydurusTuru> UydurusTuruFymaliyetMuhasebeHesaps { get; set; } = new List<UydurusTuru>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisiBdarGeMuhasebeHesaps { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisiBdmaliyetMuhasebeHesaps { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisiBdstokMuhasebeHesabis { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisiBdyisatisIadeMuhasebeHesaps { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisiBdyurtdisiSatisHesabis { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisiBdyurticiSatisHesabis { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<Uyurunler> UyurunlerArGeMuhasebeHesaps { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerMaliyetMuhasebeHesaps { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerStokMuhasebeHesaps { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerYdsatisMuhasebeHesaps { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerYisatisIadeMuhasebeHesaps { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerYisatisMuhasebeHesaps { get; set; } = new List<Uyurunler>();
}
