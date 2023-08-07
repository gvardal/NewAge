using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKydofdurum
{
    public byte DofdurumId { get; set; }

    public string? Durum { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Kydof> Kydofs { get; set; } = new List<Kydof>();
}
