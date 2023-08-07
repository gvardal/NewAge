using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UytaseronMalzemeTeslimHareketleri
{
    public int UytaseronMalzemeTeslimHareketleriId { get; set; }

    public int? TaseronMalzemeTeslimFisiDetayi { get; set; }

    public DateTime? TeslimTarihi { get; set; }

    public long? TeslimatIrsaliyeId { get; set; }

    public long? TeslimatFaturaId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UytaseronMalzemeTeslimFisiDetayi? TaseronMalzemeTeslimFisiDetayiNavigation { get; set; }

    public virtual Fyfatura? TeslimatFatura { get; set; }

    public virtual Fyfatura? TeslimatIrsaliye { get; set; }
}
