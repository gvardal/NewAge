using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Uy24saatUretimVerisi
{
    public string? KonumKodu { get; set; }

    public string Ad { get; set; } = null!;

    public DateTime? Tarih { get; set; }

    public decimal? Adet { get; set; }

    public decimal? Fire { get; set; }

    public int? CevrimSuresi { get; set; }

    public string? UstKonumKodu { get; set; }

    public string? UstKonumAdi { get; set; }

    public int KonumId { get; set; }

    public int? UstKonumId { get; set; }
}
