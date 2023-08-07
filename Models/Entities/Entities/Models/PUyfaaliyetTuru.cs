using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyfaaliyetTuru
{
    public byte FaaliyetTuruId { get; set; }

    public string? Ad { get; set; }

    public string? Sembol { get; set; }

    public virtual ICollection<UyislemTuru> UyislemTurus { get; set; } = new List<UyislemTuru>();
}
