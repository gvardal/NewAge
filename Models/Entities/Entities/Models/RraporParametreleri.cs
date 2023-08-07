using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RraporParametreleri
{
    public int RaporParametreId { get; set; }

    public int? RaporId { get; set; }

    public string? ParametreAdi { get; set; }

    public string? ParametreKodu { get; set; }

    public bool? ParametreTuru { get; set; }

    public string? ParametreDegeri { get; set; }

    public DateTime? ParametreTarih { get; set; }

    public string? Aciklama { get; set; }

    public virtual Rrapor? Rapor { get; set; }
}
