using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PparaBirimi
{
    public byte Id { get; set; }

    public string? Sembolu { get; set; }

    public string? BozukParaSembolu { get; set; }

    public string? Iso4127kodu { get; set; }

    public string? ParaBirimi { get; set; }

    public decimal? AlisKuru { get; set; }

    public decimal? Kuru { get; set; }

    public bool? SabitKur { get; set; }

    public DateTime? SonGuncellemeTarihi { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual ICollection<FkurGecmisi> FkurGecmisis { get; set; } = new List<FkurGecmisi>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriParaBirimis { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleriVirmanYapilanParaBirimis { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FybankaHesabi> FybankaHesabis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiKarsiDovizParaBirimis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiParaBirimiNavigations { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiRparaBirimiNavigations { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<Fyfatura> FyfaturaParaBirimis { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Fyfatura> FyfaturaRparaBirimiNavigations { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FygumrukBeyannamesi> FygumrukBeyannamesis { get; set; } = new List<FygumrukBeyannamesi>();

    public virtual ICollection<FyhesapPlani> FyhesapPlanis { get; set; } = new List<FyhesapPlani>();

    public virtual ICollection<Fykasalar> Fykasalars { get; set; } = new List<Fykasalar>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeGerceklesenParaBirimis { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemePlanlananParaBirimis { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeRparaBirimiNavigations { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemes { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnalizis { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<MiyfirsatDetayi> MiyfirsatDetayis { get; set; } = new List<MiyfirsatDetayi>();

    public virtual ICollection<Miyfirsatlar> Miyfirsatlars { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplaris { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyisbitirmeBelgeleri> MiyisbitirmeBelgeleris { get; set; } = new List<MiyisbitirmeBelgeleri>();

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesis { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanno1ParaBirimiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanno2ParaBirimiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanno3ParaBirimiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarIbanno4ParaBirimiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarParaBirimiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnalizis { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<Pyprojeler> Pyprojelers { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<Sysiparisler> SysiparislerParaBirimiNavigations { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerRparaBirimiNavigations { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<UyurunRotasi> UyurunRotasis { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<Uyurunler> UyurunlerSatinAlmaParaBirimis { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerSatisParaBirimis { get; set; } = new List<Uyurunler>();

    public virtual ICollection<YmmusteriBakimPlaniDegisenParcalar> YmmusteriBakimPlaniDegisenParcalars { get; set; } = new List<YmmusteriBakimPlaniDegisenParcalar>();

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
