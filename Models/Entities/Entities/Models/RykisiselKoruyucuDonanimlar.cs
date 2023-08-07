using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RykisiselKoruyucuDonanimlar
{
    public int Kkid { get; set; }

    public string? Kkdtanimi { get; set; }

    public string? IlgiliStandart { get; set; }

    public string? IlgiliOrgan { get; set; }

    public short? UnvanId { get; set; }

    public string? Uretici { get; set; }

    public string? ParcaNo { get; set; }

    public string? KisaAciklama { get; set; }

    public string? Fiyati { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }
}
