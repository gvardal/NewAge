using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UykonumIslemTuru
{
    public int KonumId { get; set; }

    public short IslemTuruId { get; set; }

    public double? FireOrani { get; set; }

    public byte? Oncelik { get; set; }

    public virtual UyislemTuru IslemTuru { get; set; } = null!;

    public virtual Uykonum Konum { get; set; } = null!;
}
