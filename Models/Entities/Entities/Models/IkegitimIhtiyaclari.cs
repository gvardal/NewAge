using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkegitimIhtiyaclari
{
    public short EgitimIhtiyacId { get; set; }

    public short? OzelYetenekId { get; set; }

    public short? UnvanId { get; set; }

    public int? EgitimId { get; set; }

    public string? Aciklama { get; set; }

    public virtual IkegitimKatalogu? Egitim { get; set; }

    public virtual PIkozelYetenekler? OzelYetenek { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }
}
