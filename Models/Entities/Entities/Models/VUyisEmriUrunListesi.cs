using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyisEmriUrunListesi
{
    public string? Adi { get; set; }

    public long? UretimPlaniId { get; set; }

    public long IsEmriId { get; set; }

    public int IsEmriRotaId { get; set; }

    public int? KonumId { get; set; }

    public decimal? Agirlik { get; set; }

    public string? UrunKodu { get; set; }

    public int UrunId { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public byte? RotaDurumu { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public long? KesimIsEmriId { get; set; }

    public decimal? KesimSuresi { get; set; }

    public decimal? KesilenMalzemeAgirligi { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public short? IslemTuruId { get; set; }

    public bool? KesimIslemi { get; set; }
}
