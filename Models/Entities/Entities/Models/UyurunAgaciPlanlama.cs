using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunAgaciPlanlama
{
    public long UrunAgaciPlanlamaId { get; set; }

    public long? UretimPlaniId { get; set; }

    public int? UrunId { get; set; }

    public int? YedekUrunId { get; set; }

    public decimal? YerineKullanilacakMiktar { get; set; }

    public string? UrunTuru { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? GerekliMiktar { get; set; }

    public decimal? StokRezervasyonMiktari { get; set; }

    public decimal? RezervasyonMiktari { get; set; }

    public int? KonumId { get; set; }

    public bool? Planlandi { get; set; }

    public int? PlanlayanId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Ikcalisanlar? Planlayan { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<UysauretimPlaniSiparisDetayi> UysauretimPlaniSiparisDetayis { get; set; } = new List<UysauretimPlaniSiparisDetayi>();

    public virtual Uyurunler? YedekUrun { get; set; }
}
