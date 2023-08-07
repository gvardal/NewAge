using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSatinAlmaMalzemeIhtiyacPlani
{
    public int? SiparisId { get; set; }

    public int? BirlestirilenMalzemeSayisi { get; set; }

    public int? BirlestirilenUretimPlaniSayisi { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public byte? Durum { get; set; }

    public DateTime? EnErkenTerminTarihi { get; set; }

    public decimal? ToplamTalepMiktari { get; set; }

    public string? OlcuBirimi { get; set; }

    public string? Aciklama { get; set; }

    public int UrunId { get; set; }
}
