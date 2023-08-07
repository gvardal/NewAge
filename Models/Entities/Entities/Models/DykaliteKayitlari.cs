using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DykaliteKayitlari
{
    public int Id { get; set; }

    public string? Kodu { get; set; }

    public string? DokumanAdi { get; set; }

    public string? OrjinalSaklamaBirimi { get; set; }

    public string? KayitSaklamaBirimi { get; set; }

    public string? SaklamaSuresi { get; set; }

    public string? KayitSaklamaSekli { get; set; }

    public string? IptalDokumanBirimi { get; set; }

    public string? IptalSuresi { get; set; }

    public string? IptalSaklamaSekli { get; set; }

    public int? BelirleyenKullaniciId { get; set; }

    public virtual Ikcalisanlar? BelirleyenKullanici { get; set; }
}
