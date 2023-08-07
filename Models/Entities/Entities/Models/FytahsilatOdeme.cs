using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FytahsilatOdeme
{
    public int TahsilatOdemeId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public int? FinansalDonemId { get; set; }

    public bool? TahsilatOdemeTuru { get; set; }

    public bool? AlacakBorcDekontu { get; set; }

    public string? BelgeSeriNo { get; set; }

    public bool? PlanlananGerceklesen { get; set; }

    public int? IslemTuruId { get; set; }

    public int? SonrakiTahsilatOdemeId { get; set; }

    public int? SiparisId { get; set; }

    public int? SatinAlmaId { get; set; }

    public long? FaturaId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public bool? MasrafFisi { get; set; }

    public int? MasrafSahibiId { get; set; }

    public byte? KasaId { get; set; }

    public byte? BankaHesapId { get; set; }

    public string? GumrukBeyannameId { get; set; }

    public bool? OtomatikYevmiyeKaydi { get; set; }

    public int? HesapId { get; set; }

    public int? VirmanYapilanHesapId { get; set; }

    public bool? Hatirlat { get; set; }

    public bool? Tekrarla { get; set; }

    public string? TekrarPeriyodu { get; set; }

    public byte? PlanlananTahsilatOdemeTuruId { get; set; }

    public DateTime? PlanlananTarih { get; set; }

    public decimal? PlanlananTutar { get; set; }

    public byte? PlanlananParaBirimiId { get; set; }

    public int? KapatanTahsilatOdemeId { get; set; }

    public long? KapatanFaturaDekontId { get; set; }

    public bool? SabitKur { get; set; }

    public double? PlanlananKur { get; set; }

    public double? PlanlananToplam { get; set; }

    public string? PlanlananTutarYazi { get; set; }

    public string? Aciklama { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? OnayaGonderildi { get; set; }

    public byte? GerceklesenTahsilatOdemeTuruId { get; set; }

    public DateTime? GerceklesenTarih { get; set; }

    public decimal? GerceklesenTutar { get; set; }

    public byte? GerceklesenParaBirimiId { get; set; }

    public double? GerceklesenKur { get; set; }

    public double? GerceklesenToplam { get; set; }

    public string? GerceklesenTutarYazi { get; set; }

    public int? PosId { get; set; }

    public string? DosyaAdi { get; set; }

    public long? BelgeId { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public int? YevmiyeKaydiYapanId { get; set; }

    public bool? Iptal { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public int? IptalEdenCalisanId { get; set; }

    public byte? RparaBirimi { get; set; }

    public decimal? Rkuru { get; set; }

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

    public virtual FybankaHesabi? BankaHesap { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisis { get; set; } = new List<FcekSenetGecmisi>();

    public virtual ICollection<FcekSenet> FcekSenetOdemes { get; set; } = new List<FcekSenet>();

    public virtual ICollection<FcekSenet> FcekSenetTahsilats { get; set; } = new List<FcekSenet>();

    public virtual FyfinansalDonemler? FinansalDonem { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleris { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleris { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayis { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual PparaBirimi? GerceklesenParaBirimi { get; set; }

    public virtual PFytahsilatOdemeTuru? GerceklesenTahsilatOdemeTuru { get; set; }

    public virtual FygumrukBeyannamesi? GumrukBeyanname { get; set; }

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual ICollection<IkbordroAvansDetayi> IkbordroAvansDetayis { get; set; } = new List<IkbordroAvansDetayi>();

    public virtual ICollection<FytahsilatOdeme> InverseSonrakiTahsilatOdeme { get; set; } = new List<FytahsilatOdeme>();

    public virtual Ikcalisanlar? IptalEdenCalisan { get; set; }

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PFislemTuru? IslemTuru { get; set; }

    public virtual Fyfatura? KapatanFaturaDekont { get; set; }

    public virtual Fykasalar? Kasa { get; set; }

    public virtual Ikcalisanlar? MasrafSahibi { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual PparaBirimi? PlanlananParaBirimi { get; set; }

    public virtual PFytahsilatOdemeTuru? PlanlananTahsilatOdemeTuru { get; set; }

    public virtual PSypo? Pos { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual PparaBirimi? RparaBirimiNavigation { get; set; }

    public virtual SateklifSipari? SatinAlma { get; set; }

    public virtual Sysiparisler? Siparis { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? SonrakiTahsilatOdeme { get; set; }

    public virtual Miysahesaplar? VirmanYapilanHesap { get; set; }

    public virtual Ikcalisanlar? YevmiyeKaydiYapan { get; set; }
}
