using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PRymedikalMuayeneTani
{
    public short TaniId { get; set; }

    public string? TaniKodu { get; set; }

    public string? TaniAdi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<RymedikalMuayeneKayitlari> RymedikalMuayeneKayitlaris { get; set; } = new List<RymedikalMuayeneKayitlari>();
}
