using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkcalisanDurumu
{
    public string CalisanDurumuId { get; set; } = null!;

    public string? Durum { get; set; }

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();
}
