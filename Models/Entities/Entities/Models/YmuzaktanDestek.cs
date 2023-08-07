using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmuzaktanDestek
{
    public int UzaktanDestekId { get; set; }

    public int? MusteriIstekSikayetId { get; set; }

    public int? SorumluId { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public int? Sure { get; set; }

    public string? Sonuc { get; set; }

    public virtual YmmusteriIstekSikayetleri? MusteriIstekSikayet { get; set; }

    public virtual Ikcalisanlar? Sorumlu { get; set; }
}
