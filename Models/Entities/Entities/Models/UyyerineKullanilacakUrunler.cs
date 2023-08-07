using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyyerineKullanilacakUrunler
{
    public long UretimPlaniYedekUrunId { get; set; }

    public long? UretimPlaniId { get; set; }

    public int? UrunId { get; set; }

    public int? YedekUrunId { get; set; }

    public decimal? KullanilacakMiktar { get; set; }

    public decimal? KullanilanMiktar { get; set; }

    public decimal? SatinAlmaIhtiyaci { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual Uyurunler? YedekUrun { get; set; }
}
