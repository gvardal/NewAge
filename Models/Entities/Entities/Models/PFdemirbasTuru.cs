using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFdemirbasTuru
{
    public byte DemirbasTuruId { get; set; }

    public string? DemirbasTuru { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();
}
