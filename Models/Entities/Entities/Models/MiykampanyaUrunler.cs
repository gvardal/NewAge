using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiykampanyaUrunler
{
    public long Id { get; set; }

    public long? KampanyaId { get; set; }

    public int? UrunId { get; set; }

    public decimal? ListeFiyati { get; set; }

    public decimal? SonKullaniciFiyati { get; set; }

    public decimal? KampanyaFiyat { get; set; }

    public virtual Miykampanyalar? Kampanya { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
