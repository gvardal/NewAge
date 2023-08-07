using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RgelirTablosu
{
    public string? Aciklama { get; set; }

    public string? KategoriSembolu { get; set; }

    public byte? HesapSinifi { get; set; }

    public int? AnaHesapKodu { get; set; }

    public int? OncekiHesapKodu { get; set; }

    public string? HesapKodu { get; set; }

    public string? HesapAdi { get; set; }

    public bool? HesapCarpani { get; set; }

    public decimal? Bakiye { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public string? KategoriAdi { get; set; }

    public byte HesapKategoriId { get; set; }
}
