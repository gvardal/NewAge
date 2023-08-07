using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmcanliOzellikTuru
{
    public int OzellikId { get; set; }

    public string? OzellikTuru { get; set; }

    public Guid Rowguid { get; set; }

    public virtual ICollection<YmcanliOzellikleri> YmcanliOzellikleris { get; set; } = new List<YmcanliOzellikleri>();
}
