using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Iksinavlar
{
    public decimal Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public string? SinavAdi { get; set; }

    public string? SinaviYapanKurum { get; set; }

    public string? Notu { get; set; }

    public DateTime? SinavTarihi { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }
}
