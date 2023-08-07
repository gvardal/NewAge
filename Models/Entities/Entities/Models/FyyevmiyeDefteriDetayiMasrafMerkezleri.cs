using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyyevmiyeDefteriDetayiMasrafMerkezleri
{
    public int YevmiyeDefteriMasrafMerkeziId { get; set; }

    public long? YevmiyeDefteriDetayiId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public string? MasrafMerkeziAciklamasi { get; set; }

    public int? ProjeId { get; set; }

    public string? ProjeAciklamasi { get; set; }

    public decimal? DagitimOrani { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual FyfaturaDetayi? FaturaDetayi { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FyyevmiyeDefteriDetayi? YevmiyeDefteriDetayi { get; set; }
}
