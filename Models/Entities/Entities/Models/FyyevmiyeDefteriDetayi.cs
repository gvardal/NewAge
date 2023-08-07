using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyyevmiyeDefteriDetayi
{
    public long YevmiyeDefteriDetayiId { get; set; }

    public long YevmiyeDefteriId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public DateTime? BelgeTarihi { get; set; }

    public string? BelgeNo { get; set; }

    public int HesapPlaniId { get; set; }

    public string? Aciklama { get; set; }

    public decimal BorcTutari { get; set; }

    public decimal AlacakTutari { get; set; }

    public decimal? BakiyeTutari { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public long? FaturaId { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FyyevmiyeDefteriDetayiMasrafMerkezleri> FyyevmiyeDefteriDetayiMasrafMerkezleris { get; set; } = new List<FyyevmiyeDefteriDetayiMasrafMerkezleri>();

    public virtual FyhesapPlani HesapPlani { get; set; } = null!;

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual FyyevmiyeDefteri YevmiyeDefteri { get; set; } = null!;
}
