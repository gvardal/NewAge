using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RraporYetkisi
{
    public int RaporYetkiId { get; set; }

    public int? RaporId { get; set; }

    public int? CalisanId { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Rrapor? Rapor { get; set; }
}
