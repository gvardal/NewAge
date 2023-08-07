using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIstekSikayetKategorileri
{
    public byte IstekSikayetKategoriId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleris { get; set; } = new List<YmmusteriIstekSikayetleri>();
}
