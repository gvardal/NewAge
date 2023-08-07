using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyvergiIstisnaSebebi
{
    public string VergiIstisnaSebebiId { get; set; } = null!;

    public string? KisaAciklama { get; set; }

    public string KoduAciklamasi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();
}
