using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsstokVarsayimlari
{
    public int StokId { get; set; }

    public short? ButcePlaniId { get; set; }

    public int? UrunId { get; set; }

    public decimal? DonemBasiBirimMaliyeti { get; set; }

    public decimal? DonemBasiStok { get; set; }

    public decimal? Miktari1Ay { get; set; }

    public decimal? Miktari2Ay { get; set; }

    public decimal? Miktari3Ay { get; set; }

    public decimal? Miktari4Ay { get; set; }

    public decimal? Miktari5Ay { get; set; }

    public decimal? Miktari6Ay { get; set; }

    public decimal? Miktari7Ay { get; set; }

    public decimal? Miktari8Ay { get; set; }

    public decimal? Miktari9Ay { get; set; }

    public decimal? Miktari10Ay { get; set; }

    public decimal? Miktari11Ay { get; set; }

    public decimal? Miktari12Ay { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual KsbutcePlani? ButcePlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
