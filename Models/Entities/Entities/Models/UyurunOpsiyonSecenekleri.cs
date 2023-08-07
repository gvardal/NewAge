using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunOpsiyonSecenekleri
{
    public long? UrunAgaciId { get; set; }

    public short? OpsiyonGrubuId { get; set; }

    public int? UrunId { get; set; }

    public string Adi { get; set; } = null!;

    public short UrunOpsiyonSecenekId { get; set; }

    public short? UstUrunOpsiyonSecenekId { get; set; }

    public short? VarsayilanAdet { get; set; }

    public short? MinimumAdet { get; set; }

    public short? MaximumAdet { get; set; }

    public bool? Varsayilan { get; set; }

    public virtual ICollection<UyurunAgaciKullanilanOpsiyonlar> UyurunAgaciKullanilanOpsiyonlars { get; set; } = new List<UyurunAgaciKullanilanOpsiyonlar>();
}
