using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUykonum
{
    public int KonumId { get; set; }

    public byte? FirmaId { get; set; }

    public string? KonumKodu { get; set; }

    public string Ad { get; set; } = null!;

    public byte? KonumTuruId { get; set; }

    public int? MasrafMerkezi { get; set; }

    public decimal? MaliyetOrani { get; set; }

    public decimal? DogalgazMaliyeti { get; set; }

    public decimal? ElektrikMaliyeti { get; set; }

    public decimal? SuMaliyeti { get; set; }

    public decimal? Kapasite { get; set; }

    public decimal? VardiyaUzunlugu { get; set; }

    public byte? KisaMolalar { get; set; }

    public decimal? KisaMolaSuresi { get; set; }

    public byte? YemekMolasi { get; set; }

    public decimal? YemekMolaSuresi { get; set; }

    public decimal? IdealUretimHizi { get; set; }

    public byte? CalismaGrubu { get; set; }

    public byte? ParalelIslemSayisi { get; set; }

    public double? FireOrani { get; set; }

    public decimal? FazlaUretimToleransi { get; set; }

    public int? StokKonumu { get; set; }

    public int? YariMamulStokKonumuId { get; set; }

    public int? UstKonumId { get; set; }

    public string? KonumKoduAdi { get; set; }

    public string? Aciklama { get; set; }

    public string? RaporAdi { get; set; }

    public bool? EksiyeDusebilir { get; set; }

    public string? Ipadres { get; set; }

    public string? SiraAraligi { get; set; }

    public string? RafAraligi { get; set; }

    public string? BolmeAraligi { get; set; }

    public int? Xkoordinati { get; set; }

    public int? Ykoordinati { get; set; }

    public bool? StokHareketleriniSirala { get; set; }

    public bool? Secili { get; set; }

    public bool? OtomatikEnvanterOlusturma { get; set; }

    public byte? DemirbasDurumu { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public string? SenkronizasyonKodu { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }
}
