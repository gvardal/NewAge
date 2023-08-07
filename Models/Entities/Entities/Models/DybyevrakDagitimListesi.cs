using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DybyevrakDagitimListesi
{
    public int EvrakId { get; set; }

    public int CalisanId { get; set; }

    public DateTime? SonOkumaTarihi { get; set; }

    public DateTime? IlkOkumaTarihi { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual Dybyevraklar Evrak { get; set; } = null!;
}
