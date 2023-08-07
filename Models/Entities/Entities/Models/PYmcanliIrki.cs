using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PYmcanliIrki
{
    public int CanliIrkId { get; set; }

    public string? CanliIrkAdi { get; set; }

    public bool? CanliCinsiId { get; set; }

    public virtual ICollection<Ymcanlilar> Ymcanlilars { get; set; } = new List<Ymcanlilar>();
}
