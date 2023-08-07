using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Lygpsalan
{
    public short AlanId { get; set; }

    public string AlanAdi { get; set; } = null!;

    public DateTime? AlanOlusturulmaTarihi { get; set; }

    public virtual ICollection<LycihazAlanDurumu> LycihazAlanDurumus { get; set; } = new List<LycihazAlanDurumu>();
}
