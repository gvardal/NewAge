using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUrunOzellikleriStogu
{
    public string UrunKoduAdi { get; set; } = null!;

    public string? Deger { get; set; }

    public string? KonumKodu { get; set; }

    public string? Sembolu { get; set; }

    public string? KonumKoduAdi { get; set; }

    public decimal? SonKullaniciFiyati { get; set; }

    public decimal? BayiFiyati { get; set; }

    public decimal? CozumOrtagiFiyati { get; set; }

    public decimal? ProjeFiyati { get; set; }

    public decimal? KullanilabilirMiktar { get; set; }

    public int UrunId { get; set; }

    public int KonumId { get; set; }

    public byte? SatisParaBirimiId { get; set; }

    public string Ad { get; set; } = null!;

    public string? KategoriKoduAdi { get; set; }

    public string? Aciklama { get; set; }
}
