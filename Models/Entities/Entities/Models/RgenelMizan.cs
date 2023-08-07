using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RgenelMizan
{
    public int HesapPlaniId { get; set; }

    public decimal? BorcTutari { get; set; }

    public decimal? AlacakTutari { get; set; }

    public string HesapKoduAdi { get; set; } = null!;

    public string? HesapKodu { get; set; }

    public string? HesapAdi { get; set; }

    public int? OncekiHesapKodu { get; set; }
}
