using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsinsanKaynagi
{
    public int InsanKaynagiId { get; set; }

    public short? ButcePlaniId { get; set; }

    public decimal? OrtalamaMaliyet { get; set; }

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

    public virtual KsbutcePlani? ButcePlani { get; set; }
}
