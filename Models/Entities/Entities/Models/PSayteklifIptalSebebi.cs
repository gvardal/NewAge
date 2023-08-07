using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSayteklifIptalSebebi
{
    public byte TeklifRedSebebiId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();
}
