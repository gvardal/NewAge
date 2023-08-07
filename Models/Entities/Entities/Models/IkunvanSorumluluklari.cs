using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkunvanSorumluluklari
{
    public int SorumlulukId { get; set; }

    public short? UnvanId { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Sure { get; set; }

    public byte? Agirlik { get; set; }

    public string? HedeflenenDeger { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }
}
