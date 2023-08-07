using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class AfisKonumu
{
    public byte AfisKonumId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Afisler> Afislers { get; set; } = new List<Afisler>();
}
