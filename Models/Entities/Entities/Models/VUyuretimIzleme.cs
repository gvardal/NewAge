using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimIzleme
{
    public string? KonumKodu { get; set; }

    public string Ad { get; set; } = null!;

    public short? IslemTuruId { get; set; }

    public byte? RotaDurumu { get; set; }

    public string? Aciklama { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public decimal? GerceklesenCikti { get; set; }

    public decimal? OrtalamaCevrimSuresi { get; set; }

    public DateTime? SonCevrimZamani { get; set; }
}
