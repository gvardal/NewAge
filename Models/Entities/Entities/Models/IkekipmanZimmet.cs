using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkekipmanZimmet
{
    public int EkipmanZimmetId { get; set; }

    public int? CalisanId { get; set; }

    public string? Cinsi { get; set; }

    public short? TeslimEdilenMiktar { get; set; }

    public int? OlcuBirimiId { get; set; }

    public DateTime? TeslimTarihi { get; set; }

    public short? TeslimAlinanMiktar { get; set; }

    public DateTime? TeslimAlmaTarihi { get; set; }

    public string? HasarAciklamasi { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual PolcuBirimleri? OlcuBirimi { get; set; }
}
