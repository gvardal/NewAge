using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PGgorevDurumu
{
    public byte GorevDurumuId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();
}
