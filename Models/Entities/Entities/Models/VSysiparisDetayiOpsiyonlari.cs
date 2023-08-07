using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSysiparisDetayiOpsiyonlari
{
    public long SiparisDetayiOpsiyonId { get; set; }

    public string? SecenekAdi { get; set; }

    public string? OpsiyonGrubu { get; set; }

    public decimal? Adet { get; set; }

    public long? SecilenUrunAgaciId { get; set; }

    public float? IslemSuresi { get; set; }

    public float? HazirlamaSuresi { get; set; }

    public string? Aciklama { get; set; }

    public int? SiparisId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public string? OpsiyonAciklamasi { get; set; }

    public decimal? UrunFiyati { get; set; }

    public bool? SiparisOpsiyonu { get; set; }

    public short OpsiyonGrubuId { get; set; }

    public bool? RapordaGosterme { get; set; }

    public string? RaporAciklama { get; set; }
}
