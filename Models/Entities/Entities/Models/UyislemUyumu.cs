using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyislemUyumu
{
    public short BirincilIslemTuruId { get; set; }

    public short IkincilIslemTuruId { get; set; }

    public float? UyumOrani { get; set; }

    public DateTime? HazirlikSuresi { get; set; }

    public virtual UyislemTuru BirincilIslemTuru { get; set; } = null!;

    public virtual UyislemTuru IkincilIslemTuru { get; set; } = null!;
}
