using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUysambalajTipi
{
    public byte AmbalajTipiId { get; set; }

    public string? AmbalajTipi { get; set; }

    public virtual ICollection<UysambalajBilgisi> UysambalajBilgisis { get; set; } = new List<UysambalajBilgisi>();
}
