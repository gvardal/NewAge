using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FysatilanMalinMaliyeti
{
    public int FinansalDonemId { get; set; }

    public int UrunId { get; set; }

    public decimal? FiiliMaliyet { get; set; }

    public decimal? FiiliIlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? FiiliDirekIscilikMaliyeti { get; set; }

    public decimal? FiiliEkipmanKullanimMaliyeti { get; set; }

    public decimal? FiiliFasonIslemMaliyeti { get; set; }

    public decimal? FiiliGenelUretimMaliyeti { get; set; }

    public virtual FyfinansalDonemler FinansalDonem { get; set; } = null!;

    public virtual Uyurunler Urun { get; set; } = null!;
}
