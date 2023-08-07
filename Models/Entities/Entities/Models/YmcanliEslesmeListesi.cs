using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmcanliEslesmeListesi
{
    public long CanliEslesmeId { get; set; }

    public long? EcanliId { get; set; }

    public long? DcanliId { get; set; }

    public DateTime? EslesmeTarihi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public virtual Ymcanlilar? Dcanli { get; set; }

    public virtual Ymcanlilar? Ecanli { get; set; }
}
