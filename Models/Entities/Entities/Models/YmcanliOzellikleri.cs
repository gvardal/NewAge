using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmcanliOzellikleri
{
    public int CanliOzellikId { get; set; }

    public long? CanliId { get; set; }

    public int? OzellikId { get; set; }

    public string? Deger { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public virtual Ymcanlilar? Canli { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual YmcanliOzellikTuru? Ozellik { get; set; }
}
