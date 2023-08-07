using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFstopajKodlari
{
    public byte StopajKoduId { get; set; }

    public string? StopajKodu { get; set; }

    public string? StopajAdi { get; set; }

    public string StopajKoduAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public double? Orani { get; set; }

    public int? MuhasebeHesapId { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual FyhesapPlani? MuhasebeHesap { get; set; }
}
