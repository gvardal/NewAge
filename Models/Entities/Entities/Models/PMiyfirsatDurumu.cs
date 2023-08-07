using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiyfirsatDurumu
{
    public byte FirsatDurumuId { get; set; }

    public byte? FirsatTuruId { get; set; }

    public string? Aciklama { get; set; }

    public virtual PMiyfirsatTuru? FirsatTuru { get; set; }

    public virtual ICollection<Miyfirsatlar> Miyfirsatlars { get; set; } = new List<Miyfirsatlar>();
}
