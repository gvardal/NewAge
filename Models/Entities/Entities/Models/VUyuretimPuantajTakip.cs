using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimPuantajTakip
{
    public long? UretimPlaniId { get; set; }

    public string? ProjeKodu { get; set; }

    public string? ProjeKoduAdi { get; set; }

    public DateTime? ProjeBaslamaTarihi { get; set; }

    public long? IsEmriId { get; set; }

    public string? IsEmriKodu { get; set; }

    public string? IsEmriAdi { get; set; }

    public string? SponsorKodu { get; set; }

    public string? Sponsor { get; set; }

    public int? IsEmriRotaId { get; set; }

    public string? CalisanAdi { get; set; }

    public bool? UretimDurus { get; set; }

    public decimal? CalisilanAdamSaat { get; set; }

    public string? IslemTuru { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Gun { get; set; }

    public DateTime? GunAyYil { get; set; }

    public DateTime? CalisilanGun { get; set; }

    public long IsciZamanKartiId { get; set; }

    public int? Id { get; set; }

    public decimal? CalisilanZaman { get; set; }
}
