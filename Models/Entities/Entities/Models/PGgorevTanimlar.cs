using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PGgorevTanimlar
{
    public byte Id { get; set; }

    public string TanimliGorev { get; set; } = null!;

    public string? Aciklama { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();
}
