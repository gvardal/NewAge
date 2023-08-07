using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BydegisenParcaListesi
{
    public int DegisenParcaListesiId { get; set; }

    public int? BakimPlaniId { get; set; }

    public int? UrunId { get; set; }

    public byte? DurumId { get; set; }

    public string? Aciklama { get; set; }

    public int? Miktar { get; set; }

    public decimal? Maliyeti { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public int? TuketimKonumuId { get; set; }

    public virtual ByyillikBakimPlani? BakimPlani { get; set; }

    public virtual PBybakimDurumu? Durum { get; set; }

    public virtual SasatinAlmaTalebi? SatinAlmaTalebi { get; set; }

    public virtual Uykonum? TuketimKonumu { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
