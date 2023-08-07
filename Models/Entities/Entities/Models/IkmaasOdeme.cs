using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkmaasOdeme
{
    public int MaasOdemeId { get; set; }

    public int? CalisanId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public int? FinansalDonemId { get; set; }

    public short? MaliYil { get; set; }

    public byte? MaliAy { get; set; }

    public int? SskgecmisiId { get; set; }

    public bool? AuigelirVergisiUygulansin { get; set; }

    public DateTime? CalisanaBildirimTarihi { get; set; }

    public bool? Bildirge { get; set; }

    public bool? CalismaDurumu { get; set; }

    /// <summary>
    /// 0=Normal, 1=Emekli
    /// </summary>
    public bool? SigortaIndirimi { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public DateTime? PlanlananOdemeTarihi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public DateTime? GerceklesenOdemeTarihi { get; set; }

    public decimal? KismiCalismaOdenegi { get; set; }

    public decimal? MahsuplasacakAvans { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? GerceklesenToplam { get; set; }

    public decimal? AylikCalismaGunu { get; set; }

    public decimal? AylikCalismaSaati { get; set; }

    public decimal? HaftasonuGunu { get; set; }

    public decimal? HaftasonuSaati { get; set; }

    public decimal? GenelTatilGunu { get; set; }

    public decimal? GenelTatilSaati { get; set; }

    public decimal? AylikUcret { get; set; }

    public decimal? BrutUcret { get; set; }

    public decimal? TemelUcret { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? IzinGunu { get; set; }

    public decimal? IzinSaati { get; set; }

    public decimal? IzinUcreti { get; set; }

    public decimal? HaftaSonuResmiTatilSaati { get; set; }

    public decimal? HaftaSonuResmiTatilUcreti { get; set; }

    public decimal? FazlaMesaiSaati { get; set; }

    public decimal? FazlaMesaiUcreti { get; set; }

    public decimal? EksikCalismaSaati { get; set; }

    public decimal? DigerKesintiUcreti { get; set; }

    public decimal? SosyalYardimUcretiNet { get; set; }

    public decimal? SosyalYardimUcreti { get; set; }

    public decimal? EkOdemeUcretiNet { get; set; }

    public decimal? EkOdemeUcreti { get; set; }

    public decimal? Beskesintisi { get; set; }

    public decimal? SahisSigortaEngelliIndirimi { get; set; }

    public decimal? Sgkmatrahi { get; set; }

    public byte? Sgkgun { get; set; }

    public byte? EksikGunSayisi { get; set; }

    public byte? EksikGunNedeniId { get; set; }

    public decimal? Sgkisveren { get; set; }

    public decimal? IssizlikIsveren { get; set; }

    public decimal? IssizlikIsci { get; set; }

    public decimal? Sgkisci { get; set; }

    public decimal? HesaplananGvmatrahi { get; set; }

    public decimal? HesaplananKumuleGv { get; set; }

    public decimal? Auigvmatrahi { get; set; }

    public decimal? AsgariUcretinKumuleGv { get; set; }

    public decimal? Gvmatrahi { get; set; }

    public decimal? KumuleGv { get; set; }

    public decimal? GelirVergisi { get; set; }

    public decimal? AuigelirVergisi { get; set; }

    public decimal? KesilenGelirVergisi { get; set; }

    public decimal? Agi { get; set; }

    public decimal? DamgaVergisi { get; set; }

    public decimal? AuidamgaVergisi { get; set; }

    public decimal? KesilenDamgaVergisi { get; set; }

    public decimal? ToplamMaliyet { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public int? OdemeFisId { get; set; }

    public string? Aciklama { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PIkbordroEksikGunNedeni? EksikGunNedeni { get; set; }

    public virtual FyfinansalDonemler? FinansalDonem { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<IkbordroEkOdemeler> IkbordroEkOdemelers { get; set; } = new List<IkbordroEkOdemeler>();

    public virtual ICollection<IkbordroFazlaMesai> IkbordroFazlaMesais { get; set; } = new List<IkbordroFazlaMesai>();

    public virtual ICollection<IkbordroSosyalYardimlar> IkbordroSosyalYardimlars { get; set; } = new List<IkbordroSosyalYardimlar>();

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikpdkssskgecmisi? Sskgecmisi { get; set; }
}
