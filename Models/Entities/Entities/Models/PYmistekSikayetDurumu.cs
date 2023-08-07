using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PYmistekSikayetDurumu
{
    public byte IstekSikayetDurumuId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleris { get; set; } = new List<YmmusteriIstekSikayetleri>();
}
