using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyantenVerileri
{
    public long UretimVerisiId { get; set; }

    public string? OlcumDegeri1 { get; set; }

    public string? OlcumDegeri2 { get; set; }

    public string? OlcumDegeri3 { get; set; }

    public string? BarkodNo { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }
}
