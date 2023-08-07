using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IihaberBandiDagitimListesi
{
    public int HaberBandiId { get; set; }

    public int CalisanId { get; set; }

    public DateTime? OkumaTarihi { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual IihaberBandi HaberBandi { get; set; } = null!;
}
