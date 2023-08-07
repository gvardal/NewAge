using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkisDeneyimleri
{
    public decimal Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public string? SirketinAdi { get; set; }

    public short? SirketinSektoru { get; set; }

    public short? GorevAlani { get; set; }

    public string? OrganizasyondakiYeri { get; set; }

    public string? Unvan { get; set; }

    public DateTime? IseBaslamaTarihi { get; set; }

    public DateTime? IstenAyrilmaTarihi { get; set; }

    public string? CalismaSekli { get; set; }

    public int? Sehir { get; set; }

    public short? Ulke { get; set; }

    public string? IsTanimi { get; set; }

    public virtual PgorevAlani? GorevAlaniNavigation { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual Psektoru? SirketinSektoruNavigation { get; set; }

    public virtual Pulkeler? UlkeNavigation { get; set; }
}
