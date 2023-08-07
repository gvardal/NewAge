using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RyreceteKayitlari
{
    public int ReceteId { get; set; }

    public string? ReceteNo { get; set; }

    public DateTime? Tarih { get; set; }

    public int? IlgiliMuayene { get; set; }

    public string? SeriNo { get; set; }

    public string? TakipNo { get; set; }

    public short? ReceteTuru { get; set; }

    public short? ReceteAltTuru { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual RymedikalMuayeneKayitlari? IlgiliMuayeneNavigation { get; set; }
}
