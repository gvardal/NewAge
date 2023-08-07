using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyvergiDaireleri
{
    public short VergiDairesiId { get; set; }

    public short? UlkeId { get; set; }

    public int? SehirId { get; set; }

    public string? Ilce { get; set; }

    public string? VergiDairesiKodu { get; set; }

    public string? VergiDairesi { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisis { get; set; } = new List<PfirmaBilgisi>();

    public virtual Psehirler? Sehir { get; set; }

    public virtual Pulkeler? Ulke { get; set; }
}
