using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunRotaGrubu
{
    public string RotaGrubuId { get; set; } = null!;

    public int? UrunId { get; set; }

    public byte? ZincirKodu { get; set; }

    public short? AlternatifRotaId { get; set; }

    public virtual UyurunRotasi? UyurunRotasi { get; set; }
}
