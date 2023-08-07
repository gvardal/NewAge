using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PPyprojeDurumu
{
    public byte Id { get; set; }

    public string? Durumu { get; set; }

    public virtual ICollection<Pyprojeler> Pyprojelers { get; set; } = new List<Pyprojeler>();
}
