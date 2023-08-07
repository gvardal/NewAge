using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFhesapTuru
{
    public string HesapTuruId { get; set; } = null!;

    public string? HesapTuruKodu { get; set; }

    public string? HesapTuru { get; set; }

    public string? AktifPasif { get; set; }

    public virtual ICollection<FyhesapPlani> FyhesapPlanis { get; set; } = new List<FyhesapPlani>();
}
