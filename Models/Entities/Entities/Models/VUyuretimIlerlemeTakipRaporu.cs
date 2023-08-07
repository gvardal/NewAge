using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimIlerlemeTakipRaporu
{
    public long? UretimPlaniId { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitimTarihi { get; set; }

    public string? ProjeUrunKodu { get; set; }

    public string? ProjeUrunAdi { get; set; }

    public string? Aciklama { get; set; }

    public long? IsEmriId { get; set; }

    public string? AltUrunKodu { get; set; }

    public string? AltUrunAdi { get; set; }

    public decimal? Agirlik { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? StokMiktari { get; set; }

    public decimal? FireMiktari { get; set; }

    public int? IsEmriRotaId { get; set; }

    public byte? Sira { get; set; }

    public string? Ad { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public decimal? TamamlanmaOrani { get; set; }

    public string? IslemTuruAd { get; set; }

    public string? KonumKodu { get; set; }

    public decimal? GerceklesenAgirlik { get; set; }

    public decimal? CalisilanSaat { get; set; }

    public string? Durum { get; set; }

    public decimal? UretimPlaniUretimMiktari { get; set; }

    public int? RotaSayisi { get; set; }

    public double? ToplamIslemSuresi { get; set; }

    public double? PlanlananAdamSaat { get; set; }
}
