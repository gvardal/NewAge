using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyolcuBirimiTurleri
{
    public short OlcuBirimiTuruId { get; set; }

    public string? OlcuBirimTuruKodu { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<PolcuBirimleri> PolcuBirimleris { get; set; } = new List<PolcuBirimleri>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
