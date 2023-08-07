using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdkscalisanVardiyaPlani
{
    public int CalisanVardiyaPlaniId { get; set; }

    public byte CalismaGrubuId { get; set; }

    public DateTime Tarih { get; set; }

    public int CalisanId { get; set; }

    public int? KonumId { get; set; }

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual IkpdkscalismaGrubu CalismaGrubu { get; set; } = null!;

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uykonum? Konum { get; set; }
}
