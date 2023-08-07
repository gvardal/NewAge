using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkyabanciDil
{
    public long Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public int? YabanciDil { get; set; }

    public string? OkumaSeviyesi { get; set; }

    public string? YazmaSeviyesi { get; set; }

    public string? KonusmaSeviyesi { get; set; }

    public string? OgrenilenKurumYer { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }

    public virtual Pdil? YabanciDilNavigation { get; set; }
}
