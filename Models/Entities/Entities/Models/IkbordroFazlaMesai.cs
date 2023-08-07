using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkbordroFazlaMesai
{
    public int FazlaMesaiId { get; set; }

    public int? MaasOdemeId { get; set; }

    public byte? FazlaMesaiTuru { get; set; }

    public byte? Gun { get; set; }

    public short? Saat { get; set; }

    public double? KatSayi { get; set; }

    public decimal? BrutTutar { get; set; }

    public decimal? NetTutar { get; set; }

    public virtual IkmaasOdeme? MaasOdeme { get; set; }
}
