using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PRyolcumDegeriAnaliz
{
    public int OlcumDegeriAnalizId { get; set; }

    public string? OlcumDegeriAnalizAdi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<RymedikalTahlil> RymedikalTahlils { get; set; } = new List<RymedikalTahlil>();

    public virtual ICollection<RyolcumDegerleri> RyolcumDegerleris { get; set; } = new List<RyolcumDegerleri>();
}
