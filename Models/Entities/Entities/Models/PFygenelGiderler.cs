using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFygenelGiderler
{
    public byte GenelGiderId { get; set; }

    public string? GenelGiderKodu { get; set; }

    public string? GenelGiderAdi { get; set; }

    public bool? Aktif { get; set; }

    public int? YansitmaHesapKodu { get; set; }

    public int? ButceFarkiHesapKodu { get; set; }

    public int? KapasiteFarkiHesapKodu { get; set; }

    public int? VerimlilikFarkiHesapKodu { get; set; }

    public int? YansitmaMasrafMerkeziId { get; set; }

    public int? ButceFarkiMasrafMerkeziId { get; set; }

    public int? KapasiteFarkiMasrafMerkeziId { get; set; }

    public int? VerimlilikFarkiMasrafMerkeziId { get; set; }

    public virtual ICollection<PFygenelGiderHesapPlani> PFygenelGiderHesapPlanis { get; set; } = new List<PFygenelGiderHesapPlani>();

    public virtual ICollection<PFymaliyetYeriDetayi> PFymaliyetYeriDetayis { get; set; } = new List<PFymaliyetYeriDetayi>();
}
