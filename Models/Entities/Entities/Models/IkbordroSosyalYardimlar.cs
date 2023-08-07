using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkbordroSosyalYardimlar
{
    public int SosyalYardimId { get; set; }

    public int? MaasOdemeId { get; set; }

    public byte? SosyalYardimTuruId { get; set; }

    public byte? Gun { get; set; }

    public short? Saat { get; set; }

    public double? KatSayi { get; set; }

    public decimal? BrutTutar { get; set; }

    public decimal? NetTutar { get; set; }

    public virtual IkmaasOdeme? MaasOdeme { get; set; }

    public virtual PIkbordroSosyalYardimTuru? SosyalYardimTuru { get; set; }
}
