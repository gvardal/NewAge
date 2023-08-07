using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkcalisanBelgeleri
{
    public int CalisanBelgeId { get; set; }

    public int CalisanId { get; set; }

    public byte? BelgeTuru { get; set; }

    public string DosyaAdi { get; set; } = null!;

    public virtual PIkcalisanBelgeTurleri? BelgeTuruNavigation { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;
}
