using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmcanliDurumu
{
    public int CanliDurumId { get; set; }

    public string? CanliDurumu { get; set; }

    public virtual ICollection<Ymcanlilar> Ymcanlilars { get; set; } = new List<Ymcanlilar>();
}
