using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUykonumUretimVerileri
{
    public long UretimVerisiId { get; set; }

    public int? IsEmriRotasiId { get; set; }

    public int? FireTuruId { get; set; }

    public DateTime? Tarih { get; set; }

    public int? CevrimSuresi { get; set; }

    public float? StandartSure { get; set; }

    public decimal? Sicaklik { get; set; }

    public decimal? Nem { get; set; }

    public decimal? Basinc { get; set; }

    public decimal? Hiz { get; set; }

    public decimal? Adet { get; set; }

    public decimal? Tartim1 { get; set; }

    public string? ProsesNo { get; set; }

    public bool? KapakDurum { get; set; }

    public string? LotNumarasi { get; set; }

    public decimal? Fire { get; set; }

    public int? IsEmriRotaId { get; set; }

    public string? Ad { get; set; }

    public string? KonumKoduAdi { get; set; }

    public long? IsciZamanKartiId { get; set; }

    public string? DurusTuruKoduAdi { get; set; }

    public int? KonumId { get; set; }

    public string? DurusTuruAdi { get; set; }
}
