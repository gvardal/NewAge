using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkunvanZimmet
{
    public int UnvanZimmetId { get; set; }

    public short? UnvanId { get; set; }

    public int? EkimanId { get; set; }

    public string? Cinsi { get; set; }

    public short? TeslimEdilenMiktar { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }
}
