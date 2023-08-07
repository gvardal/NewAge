using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class GgorevDetayi
{
    public long GorevDetayiId { get; set; }

    public int? GorevId { get; set; }

    /// <summary>
    /// Belge;True-Yorum;False
    /// </summary>
    public bool? BelgeYorum { get; set; }

    public DateTime? Tarih { get; set; }

    public int? IlgiliId { get; set; }

    public string? Aciklama { get; set; }

    public string? DosyaEkiAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ggorevler? Gorev { get; set; }

    public virtual Ikcalisanlar? Ilgili { get; set; }
}
