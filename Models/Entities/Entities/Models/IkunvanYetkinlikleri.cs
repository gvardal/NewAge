using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkunvanYetkinlikleri
{
    public short UnvanYetkinlikId { get; set; }

    public short? UnvanId { get; set; }

    public short? OzelYetenekId { get; set; }

    public string? IstenenSeviye { get; set; }

    public string? Aciklama { get; set; }

    public virtual PIkozelYetenekler? OzelYetenek { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }
}
