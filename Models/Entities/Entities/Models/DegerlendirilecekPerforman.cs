using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DegerlendirilecekPerforman
{
    public int PerformansDegerlendirmeId { get; set; }

    public int? PerformansId { get; set; }

    public int? DegerlendirenId { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public DateTime? DegerlendirmeTarihi { get; set; }

    public byte DurumId { get; set; }

    public string? Aciklama { get; set; }
}
