using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyisEmriDurumu
{
    public byte IsEmriDurumId { get; set; }

    public string? Durum { get; set; }

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsivis { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmri> UyisEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();
}
