using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyornekAlmaTablosu
{
    public int OrnekAlmaTablosuId { get; set; }

    public short? OrnekAlmaPlaniId { get; set; }

    public decimal? MinimumMiktar { get; set; }

    public decimal? MaksimumMiktar { get; set; }

    public decimal? OrnekBuyuklugu { get; set; }

    public decimal? HataliMiktar { get; set; }

    public string? Notlar { get; set; }

    public virtual KyornekAlmaPlani? OrnekAlmaPlani { get; set; }
}
