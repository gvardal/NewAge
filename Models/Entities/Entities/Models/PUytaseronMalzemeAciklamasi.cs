using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUytaseronMalzemeAciklamasi
{
    public byte TaseronMalzemeAciklamasiId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<UytaseronMalzemeTeslimFisi> UytaseronMalzemeTeslimFisis { get; set; } = new List<UytaseronMalzemeTeslimFisi>();
}
