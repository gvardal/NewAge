using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Iksertifikalar
{
    public long Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public string? SertifikaAdi { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Kurum { get; set; }

    public string? SertifikaCalismaAlani { get; set; }

    public string? SeritifkaKonusu { get; set; }

    public string? UzmanlikAlani { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }
}
