using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyaksiyonDokumanlari
{
    public long AksiyonDokumanId { get; set; }

    public short? DokumanId { get; set; }

    public int AksiyonId { get; set; }

    public string? Aciklama { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PyprojeAdimlari Aksiyon { get; set; } = null!;

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
