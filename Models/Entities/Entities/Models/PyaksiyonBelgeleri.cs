using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyaksiyonBelgeleri
{
    public long AksiyonBelgeId { get; set; }

    public int ProjeId { get; set; }

    public int? AksiyonId { get; set; }

    public string? Aciklama { get; set; }

    public string EklentiDosyaAdi { get; set; } = null!;

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PyprojeAdimlari? Aksiyon { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Pyprojeler Proje { get; set; } = null!;

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
