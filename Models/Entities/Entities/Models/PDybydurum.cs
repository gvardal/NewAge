using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PDybydurum
{
    public byte DurumId { get; set; }

    public string? Durum { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();
}
