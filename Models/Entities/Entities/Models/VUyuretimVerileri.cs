using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimVerileri
{
    public string? BarkodNo { get; set; }

    public long UretimVerisiId { get; set; }

    public string? OperasyonuKodu { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public byte? IsEmriDurumId { get; set; }

    public byte? RotaDurumu { get; set; }

    public long UretimPlaniId { get; set; }

    public string Ad { get; set; } = null!;

    public string? KonumKoduAdi { get; set; }

    public int? CevrimSuresi { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public int? IsEmriRotasiId { get; set; }

    public decimal? Adet { get; set; }

    public decimal? Fire { get; set; }

    public DateTime? Tarih { get; set; }

    public int KonumId { get; set; }
}
