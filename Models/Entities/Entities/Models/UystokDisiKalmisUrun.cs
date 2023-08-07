using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UystokDisiKalmisUrun
{
    public int UrunId { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public decimal? ToplamStok { get; set; }

    public decimal? GuvenlikStogu { get; set; }

    public bool? UretilebilirUrun { get; set; }

    public bool? SatilabilirUrun { get; set; }

    public string? UrunTuru { get; set; }

    public string? Ad { get; set; }
}
