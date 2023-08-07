using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdksmesaiTuru
{
    public string MesaiTuruId { get; set; } = null!;

    public string? Aciklama { get; set; }

    public float? Carpan { get; set; }

    public virtual ICollection<Ikpdksmesai> Ikpdksmesais { get; set; } = new List<Ikpdksmesai>();
}
