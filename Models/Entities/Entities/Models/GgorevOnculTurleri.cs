using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class GgorevOnculTurleri
{
    public byte GorevOnculTuruId { get; set; }

    public string? TurAdi { get; set; }

    public string? TurKodu { get; set; }

    public virtual ICollection<GgorevOnculleri> GgorevOnculleris { get; set; } = new List<GgorevOnculleri>();
}
