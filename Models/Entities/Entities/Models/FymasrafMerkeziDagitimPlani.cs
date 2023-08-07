using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FymasrafMerkeziDagitimPlani
{
    public long MasrafMerkeziDagitimPlaniId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public int? MuhasebeHesapPlaniId { get; set; }

    public decimal? DkdvdahilTutar { get; set; }

    public decimal? KdvdahilTutar { get; set; }

    public decimal? Dborc { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Dalacak { get; set; }

    public decimal? Alacak { get; set; }

    public byte? KdvoraniId { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? Kur { get; set; }

    public string? Aciklama { get; set; }

    public decimal? DagitimOrani { get; set; }

    public string? BelgeNo { get; set; }

    public DateTime? BelgeTarihi { get; set; }

    public int? ProjeId { get; set; }

    public byte? IsAlaniId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public int? UrunId { get; set; }

    public int? HareketOzelKoduId { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual FyfaturaDetayi? FaturaDetayi { get; set; }

    public virtual PFyfaturaHareketOzelKodlari? HareketOzelKodu { get; set; }

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PMiysavergiTuru? Kdvorani { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual FyhesapPlani? MuhasebeHesapPlani { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
