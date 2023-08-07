using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsaylaraGoreSiparisler
{
    public string? Yil { get; set; }

    public string? Ay { get; set; }

    public int? UrunKodu { get; set; }

    public decimal? Toplam { get; set; }

    public int Id { get; set; }
}
