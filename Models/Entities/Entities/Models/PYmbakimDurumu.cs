using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PYmbakimDurumu
{
    public string DurumId { get; set; } = null!;

    public string? Durumu { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
