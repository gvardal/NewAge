using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikreferanslar
{
    public long Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public string? AdiSoyadi { get; set; }

    public string? CalistigiKurum { get; set; }

    public string? OrganizasyondakiYeri { get; set; }

    public string? TelefonNumarasi { get; set; }

    public string? EPostaAdresi { get; set; }

    public string? ReferansTipi { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }
}
