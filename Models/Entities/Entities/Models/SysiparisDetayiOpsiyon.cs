using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SysiparisDetayiOpsiyon
{
    public long SiparisDetayiOpsiyonId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public decimal? Adet { get; set; }

    public long? SecilenUrunAgaciId { get; set; }

    public byte? ZincirKodu { get; set; }

    public float? IslemSuresi { get; set; }

    public float? HazirlamaSuresi { get; set; }

    public string? Aciklama { get; set; }

    public string? OpsiyonAciklamasi { get; set; }

    public decimal? UrunFiyati { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }
}
