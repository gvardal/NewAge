using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkegitimBilgileri
{
    public decimal Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public string? EgitimSeviyesi { get; set; }

    public bool? DevamEdiyor { get; set; }

    public string? OkulAdi { get; set; }

    public string? BolumAdi { get; set; }

    public int? Sehir { get; set; }

    public short? Ulke { get; set; }

    public DateTime? MezuniyetTarihi { get; set; }

    public string? DiplomaNotu { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual Pulkeler? UlkeNavigation { get; set; }
}
