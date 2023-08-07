using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyurunler
{
    public int UrunId { get; set; }

    public string? Adi { get; set; }

    public string? UrunKodu { get; set; }

    public byte? RevizyonNo { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public string? ResimNo { get; set; }

    public string? UrunAciklamasi { get; set; }

    public string? Etiketler { get; set; }

    public int? UrunKategorisiId { get; set; }

    public short? UrunMarkasiId { get; set; }

    public short? UrunGrubuId { get; set; }

    public string? Gtipkodu { get; set; }

    public byte[]? UrunResim { get; set; }

    public string? UrunTeknikDokumani { get; set; }

    public bool? SatilabilirUrun { get; set; }

    public bool? UretilebilirUrun { get; set; }

    public bool? MontajUrunu { get; set; }

    public bool? GenelUrun { get; set; }

    public string? UrunTuru { get; set; }

    public bool? Proje { get; set; }

    public bool? ModelUrun { get; set; }

    public bool? KatalogUrunu { get; set; }

    public decimal? AzamiStok { get; set; }

    public decimal? GuvenlikStogu { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public decimal? LotBuyuklugu { get; set; }

    public short? OlcuBirimiTuruId { get; set; }

    public decimal? UretimOlcuKatsayisi { get; set; }

    public int? UretimOlcuBirimiId { get; set; }

    public decimal? IiuretimOlcuKatsayisi { get; set; }

    public int? IiuretimOlcuBirimiId { get; set; }

    public decimal? SatinAlmaOlcuKatsayisi { get; set; }

    public int? SatinAlmaOlcuBirimiId { get; set; }

    public decimal? IisatinAlmaOlcuKatsayisi { get; set; }

    public int? IisatinAlmaOlcuBirimiId { get; set; }

    public byte? SatinAlmaParaBirimiId { get; set; }

    public byte? SatisParaBirimiId { get; set; }

    public decimal? StandartMaliyet { get; set; }

    public decimal? IlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? IlkMaddeMalzemeMaliyetiVp { get; set; }

    public decimal? DirekIscilikMaliyeti { get; set; }

    public decimal? EkipmanKullanimMaliyeti { get; set; }

    public decimal? FasonIslemMaliyeti { get; set; }

    public decimal? GenelUretimMaliyeti { get; set; }

    public double? GenelUretimMaliyetParametresi { get; set; }

    public short? MaliyetTuketimOmru { get; set; }

    public decimal? FiiliMaliyet { get; set; }

    public decimal? FiiliIlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? FiiliDirekIscilikMaliyeti { get; set; }

    public decimal? FiiliEkipmanKullanimMaliyeti { get; set; }

    public decimal? FiiliFasonIslemMaliyeti { get; set; }

    public decimal? FiiliGenelUretimMaliyeti { get; set; }

    public short? GirdiKaliteKontrolSoruGrubuId { get; set; }

    public short? CikisKaliteKontrolSoruGrubuId { get; set; }

    public decimal? MinSatisFiyati { get; set; }

    public decimal? NumuneFiyati { get; set; }

    public decimal? ListeFiyati { get; set; }

    public decimal? SonKullaniciFiyati { get; set; }

    public decimal? BayiFiyati { get; set; }

    public decimal? CozumOrtagiFiyati { get; set; }

    public decimal? ProjeFiyati { get; set; }

    public byte? Kdvorani { get; set; }

    public byte? TevkifatOrani { get; set; }

    public double? IskontoOrani { get; set; }

    public short? KarOrani { get; set; }

    public decimal? KomisyonOrani { get; set; }

    public decimal? UrunKatsayisi { get; set; }

    public int? YdsatisMuhasebeHesapId { get; set; }

    public int? YisatisMuhasebeHesapId { get; set; }

    public int? YisatisIadeMuhasebeHesapId { get; set; }

    public int? StokMuhasebeHesapId { get; set; }

    public int? MaliyetMuhasebeHesapId { get; set; }

    public int? ArGeMuhasebeHesapId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public bool? SenkronizasyonGrubu { get; set; }

    public string? SenkronizasyonGrupKodu { get; set; }

    public string? SenkronizasyonGrupAdi { get; set; }

    public decimal? En { get; set; }

    public decimal? Boy { get; set; }

    public decimal? Yukseklik { get; set; }

    public decimal? OzgulAgirlik { get; set; }

    public string? HesaplamaTuru { get; set; }

    public decimal? Hacim { get; set; }

    public decimal? NetAgirlik { get; set; }

    public decimal? Agirlik { get; set; }

    public decimal? EnKoli { get; set; }

    public decimal? BoyKoli { get; set; }

    public decimal? YukseklikKoli { get; set; }

    public decimal? HacimKoli { get; set; }

    public decimal? NetAgirlikKoli { get; set; }

    public decimal? EnDisKutu { get; set; }

    public decimal? BoyDisKutu { get; set; }

    public decimal? YukseklikDisKutu { get; set; }

    public decimal? HacimDisKutu { get; set; }

    public decimal? NetAgirlikDisKutu { get; set; }

    public decimal? AgirlikDisKutu { get; set; }

    public string? Upc { get; set; }

    public string? Upckoli { get; set; }

    public string? UpcdisKutu { get; set; }

    public decimal? KoliAdedi { get; set; }

    public decimal? DisKutuAdedi { get; set; }

    public string? SevkiyatDogrulamaTuru { get; set; }

    public byte? Poz { get; set; }

    public byte? TedarikSuresi { get; set; }

    public string? UrunHatti { get; set; }

    public string? EkAlan1 { get; set; }

    public string? EkAlan2 { get; set; }

    public string? EkAlan3 { get; set; }

    public string? EkAlan4 { get; set; }

    public string? EkAlan5 { get; set; }

    public string? Uyari { get; set; }

    public DateTime? SatisBaslangicTarihi { get; set; }

    public DateTime? SatisBitisTarihi { get; set; }

    public bool? Uretimde { get; set; }

    public int? Rating { get; set; }

    public decimal? MinTeslimatToleransi { get; set; }

    public decimal? MakTeslimatToleransi { get; set; }

    public byte? KontrolPeriyodu { get; set; }

    public byte? GarantiSuresi { get; set; }

    public string? SatinAlmaKodu { get; set; }

    public string? SatinAlmaAdi { get; set; }

    public int? DevamUrunuId { get; set; }

    public DateTime? SonGuncellemeTarihi { get; set; }

    public string? Abcsinifi { get; set; }

    public short? KkdilgiliOrganId { get; set; }

    public string? Sdohash { get; set; }

    public string? SdocriticalHash { get; set; }

    public int? SablonUrunId { get; set; }

    public int? VarsayilanSevkiyatKonumId { get; set; }

    public string? TevkifatTuruId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }
}
