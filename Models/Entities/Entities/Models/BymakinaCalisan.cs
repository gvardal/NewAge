using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BymakinaCalisan
{
    public int MakinaCalisanId { get; set; }

    public int? MakinaId { get; set; }

    public int? CalisanId { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Fdemirba? Makina { get; set; }
}
