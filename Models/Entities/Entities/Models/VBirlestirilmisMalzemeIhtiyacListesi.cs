using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VBirlestirilmisMalzemeIhtiyacListesi
{
    public int? BirlestirilenMalzemeSayisi { get; set; }

    public int? BirlestirilenUretimPlaniSayisi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public byte? Durum { get; set; }

    public DateTime? EnErkenTerminTarihi { get; set; }

    public decimal? ToplamTalepMiktari { get; set; }

    public string? Aciklama { get; set; }
}
