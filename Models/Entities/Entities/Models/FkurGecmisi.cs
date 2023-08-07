using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FkurGecmisi
{
    public int KurGecmisId { get; set; }

    public DateTime? Tarih { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? AlisKuru { get; set; }

    public decimal? SatisKuru { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }
}
