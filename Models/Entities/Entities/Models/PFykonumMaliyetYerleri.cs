using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFykonumMaliyetYerleri
{
    public short KonumMaliyetYeriId { get; set; }

    public int? KonumId { get; set; }

    public short? MaliyetYeriId { get; set; }

    public bool? AktiviteHakki { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual PFymaliyetYerleri? MaliyetYeri { get; set; }
}
