using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunEkipmanlari
{
    public int UrunId { get; set; }

    public int EkipmanId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Fdemirba Ekipman { get; set; } = null!;

    public virtual Uyurunler Urun { get; set; } = null!;
}
