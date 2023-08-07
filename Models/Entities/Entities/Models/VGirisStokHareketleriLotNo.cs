using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VGirisStokHareketleriLotNo
{
    public long StokHareketiLotNoId { get; set; }

    public long StokHareketiId { get; set; }

    public bool? GirisCikis { get; set; }

    public long? GirisStokHareketiLotNoId { get; set; }

    public string StokHareketiTuruId { get; set; } = null!;

    public int UrunId { get; set; }

    public int KonumId { get; set; }

    public DateTime HareketTarihi { get; set; }

    public decimal? Miktar { get; set; }

    public long? LotNo { get; set; }
}
