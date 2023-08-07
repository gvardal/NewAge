using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFcekSenetDurum
{
    public byte DurumId { get; set; }

    public string? Durum { get; set; }

    public int? FykurFarkiKarHesabiId { get; set; }

    public int? FykurFarkiZararHesabiId { get; set; }

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisiDurums { get; set; } = new List<FcekSenetGecmisi>();

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisiOncekiDurums { get; set; } = new List<FcekSenetGecmisi>();

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();
}
