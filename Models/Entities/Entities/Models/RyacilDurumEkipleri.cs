using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RyacilDurumEkipleri
{
    public int Id { get; set; }

    public int? AcilDurumSenaryoId { get; set; }

    public int? CalisanId { get; set; }

    public string? Aciklama { get; set; }

    public virtual RyacilDurumSenaryolari? AcilDurumSenaryo { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }
}
