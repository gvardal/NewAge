using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyisEmriHazirlikDurumu
{
    public byte IsEmriHazirlikDurumuId { get; set; }

    public string? Durum { get; set; }

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsivis { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasis { get; set; } = new List<UyisEmriRotasi>();
}
