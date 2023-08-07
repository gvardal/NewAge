using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsanahtarPerformansGostergeleri
{
    public short AnahtarPerformansGostergesiId { get; set; }

    public int? KurumsalHedefId { get; set; }

    public int? KisiselHedefId { get; set; }

    public string? AnahtarPerformansGostergesi { get; set; }

    public string? Aciklama { get; set; }

    public string? OlcumSekli { get; set; }

    public string? Formul { get; set; }

    public string? HedeflenenDeger { get; set; }

    public string? AltSinir { get; set; }

    public string? UstSinir { get; set; }

    public decimal? Agirligi { get; set; }

    public virtual Kshedefler? KisiselHedef { get; set; }

    public virtual ICollection<Kshedefler> Kshedeflers { get; set; } = new List<Kshedefler>();

    public virtual Kshedefler? KurumsalHedef { get; set; }
}
