using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIitoplantiDurumu
{
    public byte DurumId { get; set; }

    public string? Durum { get; set; }

    public virtual ICollection<IitoplantiTutanagi> IitoplantiTutanagis { get; set; } = new List<IitoplantiTutanagi>();
}
