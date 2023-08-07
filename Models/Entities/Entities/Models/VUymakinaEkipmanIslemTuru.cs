using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUymakinaEkipmanIslemTuru
{
    public int IsEmriRotaId { get; set; }

    public int? DemirbasId { get; set; }

    public int? EkipmanId { get; set; }

    public byte? Oncelik { get; set; }

    public int? KonumId { get; set; }

    public int? MakineKonumu { get; set; }
}
