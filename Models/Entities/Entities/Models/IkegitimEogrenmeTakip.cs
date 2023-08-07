using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkegitimEogrenmeTakip
{
    public long EogrenmeTakipId { get; set; }

    public int EgitimVideoId { get; set; }

    public int KullaniciId { get; set; }

    public byte? Degerlendirme { get; set; }

    public string? Yorum { get; set; }

    public byte? DogruSayisi { get; set; }

    public byte? YanlisSayisi { get; set; }

    public byte? BosSayisi { get; set; }

    public bool? Sonuc { get; set; }

    public DateTime? IlkIzlemeTarihi { get; set; }

    public DateTime? SonIzlemeTarihi { get; set; }

    public virtual IkegitimKatalogu EgitimVideo { get; set; } = null!;

    public virtual Ikcalisanlar Kullanici { get; set; } = null!;
}
