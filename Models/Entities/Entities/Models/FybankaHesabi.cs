using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FybankaHesabi
{
    public byte BankaHesabiId { get; set; }

    public byte? FirmaId { get; set; }

    public string? BankaHesapNo { get; set; }

    public byte? HesapTuru { get; set; }

    public bool? KrediKarti { get; set; }

    public string? Ibanno { get; set; }

    public string? BankaHesapAdi { get; set; }

    public byte? BankaAdi { get; set; }

    public string? SubeAdi { get; set; }

    public string? SubeKodu { get; set; }

    public string? MusteriKodu { get; set; }

    public string? Adres { get; set; }

    public int? Sehir { get; set; }

    public int? Ilce { get; set; }

    public short? Ulke { get; set; }

    public string? Telefon { get; set; }

    public string? Faks { get; set; }

    public string? KontakAdiSoyadi { get; set; }

    public string? EPosta { get; set; }

    public string? SwiftKodu { get; set; }

    public byte? ParaBirimi { get; set; }

    public double? KurOrani { get; set; }

    public decimal? Dbakiye { get; set; }

    public decimal? Bakiye { get; set; }

    public int? MuhasabeHesapKodu { get; set; }

    public int? MuhasebeGiderHesapPlaniId { get; set; }

    public int? MuhasebeYatirimHesapPlaniId { get; set; }

    public int? MuhasebeKarHesapPlaniId { get; set; }

    public int? MuhasebeZararHesapPlaniId { get; set; }

    public int? VerilenCeklerHesapPlaniId { get; set; }

    public int? TahsilCekleriHesapPlaniId { get; set; }

    public int? TahsilSenetleriHesapPlaniId { get; set; }

    public int? TeminatCekleriHesapPlaniId { get; set; }

    public int? TeminatSenetleriHesapPlaniId { get; set; }

    public bool? SatisRaporlari { get; set; }

    public string? Aciklama { get; set; }

    public decimal? KrediKartiLimiti { get; set; }

    public decimal? NakitLimiti { get; set; }

    public double? NakitOrani { get; set; }

    public decimal? TeminatMektubuLimiti { get; set; }

    public double? TeminatOrani { get; set; }

    public string HesapAdiBakiye { get; set; } = null!;

    public string? Logo { get; set; }

    public bool? Aktif { get; set; }

    public bool? B2b { get; set; }

    public bool? B2c { get; set; }

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

    public short? SiraNumarasi { get; set; }

    public virtual PFbankalar? BankaAdiNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiAktarilanBankaHesabis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketiBankaHesabis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<IkbordroAvan> IkbordroAvans { get; set; } = new List<IkbordroAvan>();

    public virtual ICollection<IkbordroAvansDetayi> IkbordroAvansDetayis { get; set; } = new List<IkbordroAvansDetayi>();

    public virtual Pilceler? IlceNavigation { get; set; }

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplaris { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual FyhesapPlani? MuhasabeHesapKoduNavigation { get; set; }

    public virtual FyhesapPlani? MuhasebeGiderHesapPlani { get; set; }

    public virtual FyhesapPlani? MuhasebeKarHesapPlani { get; set; }

    public virtual FyhesapPlani? MuhasebeYatirimHesapPlani { get; set; }

    public virtual FyhesapPlani? MuhasebeZararHesapPlani { get; set; }

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FyhesapPlani? TahsilCekleriHesapPlani { get; set; }

    public virtual FyhesapPlani? TahsilSenetleriHesapPlani { get; set; }

    public virtual FyhesapPlani? TeminatCekleriHesapPlani { get; set; }

    public virtual FyhesapPlani? TeminatSenetleriHesapPlani { get; set; }

    public virtual Pulkeler? UlkeNavigation { get; set; }

    public virtual FyhesapPlani? VerilenCeklerHesapPlani { get; set; }
}
