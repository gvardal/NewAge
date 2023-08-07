using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class LyaracIslemi
{
    public long DemirbasIslemiId { get; set; }

    public short? AracId { get; set; }

    public string? YapilacakIslem { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public int? SorumluKisi { get; set; }

    public bool? Durum { get; set; }

    public string? Aciklama { get; set; }

    public virtual Lyaraclar? Arac { get; set; }

    public virtual Ikcalisanlar? SorumluKisiNavigation { get; set; }
}
