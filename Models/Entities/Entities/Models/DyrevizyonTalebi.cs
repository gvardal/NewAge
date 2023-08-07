using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DyrevizyonTalebi
{
    public decimal RevisyonTalebiId { get; set; }

    public int? EvrakId { get; set; }

    public DateTime? TalepTarihi { get; set; }

    public string? RevizyonFaktoru { get; set; }

    public decimal? IlgiliDofno { get; set; }

    public string? RevizyonTalebiAciklamasi { get; set; }

    public bool? TalepDurumu { get; set; }

    public bool? RevizyonYapildi { get; set; }

    public int? TalepEden { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public string? Ytnotu { get; set; }

    public virtual Dybyevraklar? Evrak { get; set; }

    public virtual Ikcalisanlar? TalepEdenNavigation { get; set; }
}
