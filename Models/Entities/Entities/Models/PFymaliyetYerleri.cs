using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFymaliyetYerleri
{
    public short MaliyetYeriId { get; set; }

    public string? MaliyetYeriKodu { get; set; }

    public string? MaliyetYeriAdi { get; set; }

    public string? OzelKodu { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public byte? MaliyetYeriTuru { get; set; }

    public string? KapasiteBirimi { get; set; }

    public string? DagitimOrani { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual ICollection<PFykonumMaliyetYerleri> PFykonumMaliyetYerleris { get; set; } = new List<PFykonumMaliyetYerleri>();

    public virtual ICollection<PFymaliyetYeriDetayi> PFymaliyetYeriDetayis { get; set; } = new List<PFymaliyetYeriDetayi>();
}
