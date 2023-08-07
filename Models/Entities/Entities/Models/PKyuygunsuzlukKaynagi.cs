using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKyuygunsuzlukKaynagi
{
    public byte UygunsuzlukKaynagiId { get; set; }

    public string? UygunsuzlukKaynagiKodu { get; set; }

    public string? KaynakAciklamasi { get; set; }

    public string? KaynakKoduAdi { get; set; }

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();
}
