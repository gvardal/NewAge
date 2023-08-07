using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IihaberBandiYorumlari
{
    public int HaberBandiYorumlariId { get; set; }

    public int? HaberBandiId { get; set; }

    public int? EvrakId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Yorum { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual IihaberBandi? HaberBandi { get; set; }
}
