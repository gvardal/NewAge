using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUysonStokHareketi
{
    public int UrunId { get; set; }

    public string? UrunKodu { get; set; }

    public decimal? StandartMaliyet { get; set; }

    public decimal? FiiliMaliyet { get; set; }

    public decimal? FiiliIlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? IlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? DirekIscilikMaliyeti { get; set; }

    public decimal? EkipmanKullanimMaliyeti { get; set; }

    public decimal? FasonIslemMaliyeti { get; set; }

    public decimal? GenelUretimMaliyeti { get; set; }

    public decimal? MinSatisFiyati { get; set; }

    public decimal? NumuneFiyati { get; set; }

    public decimal? ListeFiyati { get; set; }

    public decimal? SonKullaniciFiyati { get; set; }

    public decimal? BayiFiyati { get; set; }

    public decimal? CozumOrtagiFiyati { get; set; }

    public decimal? ProjeFiyati { get; set; }

    public string? Adi { get; set; }

    public int KonumId { get; set; }

    public string Ad { get; set; } = null!;

    public DateTime HareketTarihi { get; set; }

    public decimal Miktar { get; set; }

    public decimal? Bakiye { get; set; }

    public bool? GirisCikis { get; set; }

    public string? Aciklama { get; set; }

    public long? RowNumber { get; set; }
}
