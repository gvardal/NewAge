using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyopsiyonGrubuTuru
{
    public byte OpsiyonTuruId { get; set; }

    public string? OpsiyonTuruAdi { get; set; }

    public virtual ICollection<PUyopsiyonGrubu> PUyopsiyonGrubus { get; set; } = new List<PUyopsiyonGrubu>();
}
