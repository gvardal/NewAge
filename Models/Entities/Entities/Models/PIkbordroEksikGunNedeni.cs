using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkbordroEksikGunNedeni
{
    public byte EksikGunNedeniId { get; set; }

    public string? EksikGunKodu { get; set; }

    public string? Aciklama { get; set; }

    public string EksikGunKoduAdi { get; set; } = null!;

    public virtual ICollection<IkmaasOdeme> IkmaasOdemes { get; set; } = new List<IkmaasOdeme>();
}
