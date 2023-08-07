using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IiaramaKaydi
{
    public decimal AramaKaydiId { get; set; }

    public DateTime? AramaTarihi { get; set; }

    public int? Aranan { get; set; }

    public string? Arayan { get; set; }

    public string? Firma { get; set; }

    public string? Telefon { get; set; }

    public string? EPosta { get; set; }

    public string? WebSitesi { get; set; }

    public byte? AramaTuru { get; set; }

    public string? IletimNotu { get; set; }

    public DateTime? OkumaTarihi { get; set; }

    public bool? GorevListesi { get; set; }

    public string? Sonuc { get; set; }

    public string? GorusmeSonucu { get; set; }

    public virtual PIiaramaTuru? AramaTuruNavigation { get; set; }

    public virtual Ikcalisanlar? ArananNavigation { get; set; }
}
