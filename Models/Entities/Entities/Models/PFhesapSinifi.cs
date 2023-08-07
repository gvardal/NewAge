using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFhesapSinifi
{
    public byte HesapSinifiId { get; set; }

    public string? HesapSinifi { get; set; }

    public string? Aciklama { get; set; }

    public string? AktifPasif { get; set; }

    public virtual ICollection<PFhesapKategorisi> PFhesapKategorisis { get; set; } = new List<PFhesapKategorisi>();
}
