using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UystokAmbarFisi
{
    public int StokAmbarFisiId { get; set; }

    public byte? FirmaId { get; set; }

    public string? Aciklama { get; set; }

    public byte? FisTuruId { get; set; }

    public DateTime? Tarih { get; set; }

    public bool? KonumSifirlama { get; set; }

    public bool? Onaylandi { get; set; }

    public int? OnaylayanId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();
}
