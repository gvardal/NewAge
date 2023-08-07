using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RyacilDurumSenaryolari
{
    public int AcilDurumSenaryoId { get; set; }

    public DateTime? SenaryoTarihi { get; set; }

    public short? AcilDurumKategorisiId { get; set; }

    public string? AcilDurumunTanimi { get; set; }

    public int? AnalizEdenId { get; set; }

    public int? AcilDurumLideriId { get; set; }

    public int? RiskAnaliziId { get; set; }

    public bool? Dofac { get; set; }

    public string? DetayliSenaryo { get; set; }

    public string? DerhalYapilacaklar { get; set; }

    public string? HareketPlani { get; set; }

    public string? IletişimPlani { get; set; }

    public string? Zayifliklar { get; set; }

    public string? KurtarmaPlani { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual PRyacilDurumKategorisi? AcilDurumKategorisi { get; set; }

    public virtual Ikcalisanlar? AcilDurumLideri { get; set; }

    public virtual Ikcalisanlar? AnalizEden { get; set; }

    public virtual Kydof? RiskAnalizi { get; set; }

    public virtual ICollection<RyacilDurumEkipleri> RyacilDurumEkipleris { get; set; } = new List<RyacilDurumEkipleri>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
