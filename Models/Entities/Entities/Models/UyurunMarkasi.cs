using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunMarkasi
{
    public short UrunMarkasiId { get; set; }

    public string? Marka { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
