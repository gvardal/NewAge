using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyfaturaTuru
{
    public string FaturaTuruId { get; set; } = null!;

    public string? FaturaTuru { get; set; }

    public string FaturaKoduTuru { get; set; } = null!;

    public bool? HesapTuru { get; set; }

    public bool? DovizFaturasi { get; set; }

    public byte? IslemTuruId { get; set; }

    public string? EFaturaTuru { get; set; }

    public string? Senaryo { get; set; }

    public string? MusteriKopyasiRaporAdi { get; set; }

    public virtual ICollection<Fyefatura> Fyefaturas { get; set; } = new List<Fyefatura>();

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();
}
