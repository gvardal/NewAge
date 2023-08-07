using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFdemirbasDurumu
{
    public byte DemirbasDurumuId { get; set; }

    public string? DemirbasDurumu { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();
}
