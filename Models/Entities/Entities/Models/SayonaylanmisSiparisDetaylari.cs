using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SayonaylanmisSiparisDetaylari
{
    public string UrunKoduAdi { get; set; } = null!;

    public decimal? SiparisMiktari { get; set; }
}
