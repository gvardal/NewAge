using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FysatilanMalinMaliyetDetayi
{
    public int SatilanMalinMaliyetDetayiId { get; set; }

    public byte? FirmaId { get; set; }

    public int? FinansalDonemId { get; set; }

    public int? UrunId { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public int? MaliyetYeriDetayiId { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? BirimMaliyet { get; set; }

    public decimal? ToplamMaliyet { get; set; }

    public decimal? RaporlamaKuruMaliyeti { get; set; }

    public decimal? KurOrani { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public virtual FyfinansalDonemler? FinansalDonem { get; set; }

    public virtual UyisEmri? IsEmri { get; set; }

    public virtual PFymaliyetYeriDetayi? MaliyetYeriDetayi { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
