using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunAilesi
{
    public string UrunAilesiId { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Aciklama { get; set; }

    public byte[]? Resim { get; set; }

    public virtual ICollection<UyurunKategorisi> UyurunKategorisis { get; set; } = new List<UyurunKategorisi>();
}
