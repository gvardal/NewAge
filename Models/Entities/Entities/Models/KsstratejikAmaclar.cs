using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsstratejikAmaclar
{
    public short AmacId { get; set; }

    public byte? FirmaId { get; set; }

    public short? KurumsalStratejiId { get; set; }

    public string? Amac { get; set; }

    public string? Aciklama { get; set; }

    public short? IlgiliDepartmanId { get; set; }

    public string? PeriyodTanimi { get; set; }

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

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Ikorganizasyonlar? IlgiliDepartman { get; set; }

    public virtual ICollection<Kshedefler> Kshedeflers { get; set; } = new List<Kshedefler>();

    public virtual KskurumsalStratejiler? KurumsalStrateji { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
