using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TeslimAlinanSiparisOzellik
{
    public int SiparisId { get; set; }

    public string? FirmaAdi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public int? UrunId { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public short OzellikTuruId { get; set; }

    public string? Aciklama { get; set; }

    public string? Deger { get; set; }
}
