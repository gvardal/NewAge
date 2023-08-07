using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSiparisMrp
{
    public int? SiparisId { get; set; }

    public string? Ad { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public decimal? ToplamMiktar { get; set; }

    public string? OlcuBirimi { get; set; }

    public DateTime? EnErkenTerminTarihi { get; set; }

    public byte? Durum { get; set; }
}
