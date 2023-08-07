using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunStokHareketleri
{
    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public DateTime HareketTarihi { get; set; }

    public decimal? Miktar { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public decimal? FiiliMaliyet { get; set; }

    public decimal? StandartMaliyet { get; set; }

    public decimal? FiiliIlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? FiiliDirekIscilikMaliyeti { get; set; }

    public decimal? FiiliEkipmanKullanimMaliyeti { get; set; }

    public decimal? FiiliFasonIslemMaliyeti { get; set; }

    public decimal? FiiliGenelUretimMaliyeti { get; set; }

    public int UrunId { get; set; }

    public bool? GirisCikis { get; set; }
}
