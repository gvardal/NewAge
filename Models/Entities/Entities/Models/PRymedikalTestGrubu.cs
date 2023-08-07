using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PRymedikalTestGrubu
{
    public short MedikalTestGrubuId { get; set; }

    public string? MedikalTestGrubuAdi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<RymedikalTahlil> RymedikalTahlils { get; set; } = new List<RymedikalTahlil>();
}
