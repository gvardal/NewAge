using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiyfirsatTuru
{
    public byte FirsatTuruId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Miyfirsatlar> Miyfirsatlars { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<PMiyfirsatDurumu> PMiyfirsatDurumus { get; set; } = new List<PMiyfirsatDurumu>();
}
