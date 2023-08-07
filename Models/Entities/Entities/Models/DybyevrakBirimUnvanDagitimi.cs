using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DybyevrakBirimUnvanDagitimi
{
    public int EvrakDagitimId { get; set; }

    public int? EvrakId { get; set; }

    public short? BirimId { get; set; }

    public short? UnvanId { get; set; }

    public virtual Ikorganizasyonlar? Birim { get; set; }

    public virtual Dybyevraklar? Evrak { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }
}
