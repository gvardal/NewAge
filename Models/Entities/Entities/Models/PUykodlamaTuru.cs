using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUykodlamaTuru
{
    public byte KodlamaTuru { get; set; }

    public string? Adi { get; set; }

    public string? Kod { get; set; }

    public virtual ICollection<UykategoriOzellikleri> UykategoriOzellikleris { get; set; } = new List<UykategoriOzellikleri>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisis { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<UyurunOzellikleri> UyurunOzellikleris { get; set; } = new List<UyurunOzellikleri>();
}
