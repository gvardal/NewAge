using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Rrapor
{
    public int RaporId { get; set; }

    public string? KategoriAdi { get; set; }

    public string? RaporKodu { get; set; }

    public string? RaporAdi { get; set; }

    public string RaporKoduAdi { get; set; } = null!;

    public string? RaporAciklamasi { get; set; }

    public bool? Kisisel { get; set; }

    public bool? Yazdirildi { get; set; }

    public string? RaporTuru { get; set; }

    public string? RaporTipi { get; set; }

    public string? RaporDosyaYolu { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public int? SonYazdiranCalisanId { get; set; }

    public DateTime? SonYazdirmaTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<RraporParametreleri> RraporParametreleris { get; set; } = new List<RraporParametreleri>();

    public virtual ICollection<RraporYetkisi> RraporYetkisis { get; set; } = new List<RraporYetkisi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SonYazdiranCalisan { get; set; }
}
