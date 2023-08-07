using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFymaliyetYeriDetayi
{
    public int MaliyetYeriDetayiId { get; set; }

    public short? MaliyetYeriId { get; set; }

    public int? FinansalDonemId { get; set; }

    public byte? GenelGiderId { get; set; }

    public virtual FyfinansalDonemler? FinansalDonem { get; set; }

    public virtual ICollection<FysatilanMalinMaliyetDetayi> FysatilanMalinMaliyetDetayis { get; set; } = new List<FysatilanMalinMaliyetDetayi>();

    public virtual PFygenelGiderler? GenelGider { get; set; }

    public virtual PFymaliyetYerleri? MaliyetYeri { get; set; }
}
