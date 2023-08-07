using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyuretimPlaniTuru
{
    public byte UretimPlaniTuruId { get; set; }

    public string? Aciklama { get; set; }

    public string? UretimTuru { get; set; }

    public string? CizelgelmeTuru { get; set; }

    public string? UretimHatti { get; set; }

    public bool? StokRezervasyonuYap { get; set; }

    public bool? ManuelTuketim { get; set; }

    public bool? PlanlanincaEnvanterOlustur { get; set; }

    public string? UretimPlaniRaporAdi { get; set; }

    public string? BarkodRaporAdi { get; set; }

    public string? UretimAnalizRaporAdi { get; set; }

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<UyisEmri> UyisEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();
}
