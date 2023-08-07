using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RyacilDurumKaydi
{
    public int AcilDurumKaydiId { get; set; }

    public DateTime? AcilDurumTarihi { get; set; }

    public string? KisaAciklama { get; set; }

    public short? DepartmanId { get; set; }

    public int? KonumId { get; set; }

    public string? DetayliAciklama { get; set; }

    public string? AcilDurumunEtkileri { get; set; }

    public string? AcilDurumSebepleri { get; set; }

    public string? AcilDurumSonuclari { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikorganizasyonlar? Departman { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
