using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymakinaIslemTuru
{
    public int DemirbasId { get; set; }

    public short IslemTuruId { get; set; }

    public double? FireOrani { get; set; }

    public byte? Oncelik { get; set; }

    public virtual Fdemirba Demirbas { get; set; } = null!;

    public virtual UyislemTuru IslemTuru { get; set; } = null!;
}
