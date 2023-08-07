using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class GolayTuru
{
    public byte OlayTuruId { get; set; }

    public string? OlayTuru { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();
}
