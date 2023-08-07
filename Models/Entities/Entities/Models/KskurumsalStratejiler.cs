using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KskurumsalStratejiler
{
    public short KurumsalStratejiId { get; set; }

    public byte? FirmaId { get; set; }

    public string? KurumsalStratejiAdi { get; set; }

    public string? Misyon { get; set; }

    public string? Vizyon { get; set; }

    public string? Degerler { get; set; }

    public string? Politikalar { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<KsbutcePlani> KsbutcePlanis { get; set; } = new List<KsbutcePlani>();

    public virtual ICollection<KsstratejikAmaclar> KsstratejikAmaclars { get; set; } = new List<KsstratejikAmaclar>();

    public virtual ICollection<Ksswotanalizi> Ksswotanalizis { get; set; } = new List<Ksswotanalizi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
