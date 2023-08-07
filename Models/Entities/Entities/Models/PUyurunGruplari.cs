using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyurunGruplari
{
    public short UrunGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public string? UrunCinsi { get; set; }

    public virtual ICollection<MiysahesapSahibiGecmisi> MiysahesapSahibiGecmisis { get; set; } = new List<MiysahesapSahibiGecmisi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisis { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
