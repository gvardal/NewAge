using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunAgaciKullanilanOpsiyonlar
{
    public short UrunAgaciKullanilanOpsiyonId { get; set; }

    public long? UrunAgaciId { get; set; }

    public short? UrunOpsiyonSecenekleriId { get; set; }

    public long? UrunAgaciHavuzuId { get; set; }

    public virtual UyurunAgaci? UrunAgaci { get; set; }

    public virtual UyurunOpsiyonSecenekleri? UrunOpsiyonSecenekleri { get; set; }
}
