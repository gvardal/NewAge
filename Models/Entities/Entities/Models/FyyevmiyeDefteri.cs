using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyyevmiyeDefteri
{
    public long YevmiyeDefteriId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public int? FinansalDonemId { get; set; }

    public short? MaliYil { get; set; }

    public byte? MaliAy { get; set; }

    public string? KayitNo { get; set; }

    public int? IslemTuru { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public int? CariHesapId { get; set; }

    public string? IslemAciklamasi { get; set; }

    public string? IslemReferansi { get; set; }

    public byte? ParaBirimiId { get; set; }

    public double? DovizKuru { get; set; }

    public decimal? IslemTutari { get; set; }

    public decimal? BorcToplam { get; set; }

    public decimal? AlacakToplam { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public long? FaturaId { get; set; }

    public int? MaasOdemeId { get; set; }

    public long? BankaHesapIslemiId { get; set; }

    public long? KasaIslemiId { get; set; }

    public int? CekSenetIslemiId { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public bool? Yazdirildi { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public int? YazdiranCalisanId { get; set; }

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

    public virtual FybankaHesapHareketi? BankaHesapIslemi { get; set; }

    public virtual Miysahesaplar? CariHesap { get; set; }

    public virtual FcekSenetGecmisi? CekSenetIslemi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual ICollection<FdemirbasAmortismanlari> FdemirbasAmortismanlaris { get; set; } = new List<FdemirbasAmortismanlari>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<FykasaIslemleri> FykasaIslemleris { get; set; } = new List<FykasaIslemleri>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayis { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PFislemTuru? IslemTuruNavigation { get; set; }

    public virtual FykasaIslemleri? KasaIslemi { get; set; }

    public virtual IkmaasOdeme? MaasOdeme { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();
}
