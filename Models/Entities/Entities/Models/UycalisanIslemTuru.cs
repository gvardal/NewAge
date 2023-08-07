using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UycalisanIslemTuru
{
    public short CalisanKonumId { get; set; }

    public int? CalisanId { get; set; }

    public short? IslemTuruId { get; set; }

    public int? KonumId { get; set; }

    public double? FireOrani { get; set; }

    public double? Tempo { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual UyislemTuru? IslemTuru { get; set; }

    public virtual Uykonum? Konum { get; set; }
}
