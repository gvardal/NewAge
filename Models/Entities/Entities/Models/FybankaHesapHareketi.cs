using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FybankaHesapHareketi
{
    public long BankaHesapIslemiId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? BankaHesabiId { get; set; }

    public int? FinansalDonemId { get; set; }

    public string? DokumanNo { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public decimal? IslemTutari { get; set; }

    public byte? ParaBirimi { get; set; }

    public decimal? KurOrani { get; set; }

    public decimal? IslemDefterTutari { get; set; }

    public decimal? DevirBakiyesi { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public byte? BankaIslemTuruId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? DovizTutari { get; set; }

    public decimal? DislemDefterTutari { get; set; }

    public decimal? DdevirBakiyesi { get; set; }

    public decimal? KarZararTutari { get; set; }

    public decimal? GelirVergisiTutari { get; set; }

    public decimal? KarsiDovizTutari { get; set; }

    public byte? KarsiDovizParaBirimiId { get; set; }

    public decimal? KarsiDovizKuru { get; set; }

    public int? KarsilikMuhasebeHesapPlaniId { get; set; }

    public byte? AktarilanBankaHesabiId { get; set; }

    public long? BankaHesapHareketiId { get; set; }

    public byte? AktarilanKasaId { get; set; }

    public long? KasaIslemId { get; set; }

    public bool? Onay { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public int? Miysahesaplar { get; set; }

    public byte? RparaBirimi { get; set; }

    public decimal? Rkuru { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual FybankaHesabi? AktarilanBankaHesabi { get; set; }

    public virtual Fykasalar? AktarilanKasa { get; set; }

    public virtual FybankaHesabi? BankaHesabi { get; set; }

    public virtual PFybankaIslemTuru? BankaIslemTuru { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual FyfinansalDonemler? FinansalDonem { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual PparaBirimi? KarsiDovizParaBirimi { get; set; }

    public virtual FyhesapPlani? KarsilikMuhasebeHesapPlani { get; set; }

    public virtual FykasaIslemleri? KasaIslem { get; set; }

    public virtual Miysahesaplar? MiysahesaplarNavigation { get; set; }

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual PparaBirimi? RparaBirimiNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual FyyevmiyeDefteri? YevmiyeDefteri { get; set; }
}
