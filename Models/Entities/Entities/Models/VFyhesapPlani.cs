using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFyhesapPlani
{
    public int HesapPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public string? HesapKodu { get; set; }

    public int? OncekiHesapKodu { get; set; }

    public int? AnaHesapKodu { get; set; }

    public string HesapKoduAdi { get; set; } = null!;

    public string? HesapAdi { get; set; }

    public string? HesapAciklamasi { get; set; }

    public bool? SabitDegisken { get; set; }

    public string? OzelKod { get; set; }

    public string? OzelKod1 { get; set; }

    public string? OzelKod2 { get; set; }

    public string? Turu { get; set; }

    public byte? Seviye { get; set; }

    public string? HesapTuru { get; set; }

    public bool? HesapCarpani { get; set; }

    public byte? HesapKategorisi { get; set; }

    public byte? ParaBirimi { get; set; }

    public double? DovizKuru { get; set; }

    public decimal? Bakiyesi { get; set; }

    public decimal? BaslangicBakiyesi { get; set; }

    public bool? Aktif { get; set; }

    public bool? HareketleriDuzenle { get; set; }

    public decimal? BorcToplam { get; set; }

    public decimal? AlacakToplam { get; set; }

    public decimal? KalanBorc { get; set; }

    public decimal? KalanAlacak { get; set; }

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
}
