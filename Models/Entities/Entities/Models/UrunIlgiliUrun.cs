using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UrunIlgiliUrun
{
    public long Id { get; set; }

    public int? UrunId { get; set; }

    public int? IlgiliUrunId { get; set; }

    public virtual Uyurunler? IlgiliUrun { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
