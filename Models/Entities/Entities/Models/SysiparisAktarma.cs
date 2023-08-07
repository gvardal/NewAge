using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SysiparisAktarma
{
    public long SiparisAktarmaId { get; set; }

    public int? SiparisKodu { get; set; }

    public string? UrunKodu { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public DateTime? TerminTarihi { get; set; }
}
