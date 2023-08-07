using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UrunYorumlari
{
    public long UrunYorumId { get; set; }

    public int? UrunId { get; set; }

    public int? KullaniciId { get; set; }

    public string? Yorum { get; set; }

    public virtual Miysahesaplar? Kullanici { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
