using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSysasozlesmeTuru
{
    public byte SozlesmeTuruId { get; set; }

    public string? SozlesmeTuru { get; set; }

    public bool? AlisSatis { get; set; }

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();
}
