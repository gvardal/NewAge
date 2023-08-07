using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VMiysahesaplar
{
    public int Id { get; set; }

    public byte? FirmaId { get; set; }

    public int? HesapSahibi { get; set; }

    public string? HesapTuru { get; set; }

    public short? TicariIslemGrubuId { get; set; }

    public short? HesapKategorisi { get; set; }

    public string? HesapKodu { get; set; }

    public int? OncekiHesapKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public string? UnvanIi { get; set; }

    public bool? Aktif { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Unvani { get; set; }

    public string? HesapKaynagi { get; set; }

    public long? Kampanya { get; set; }

    public short? Sektor { get; set; }

    public string? YillikKazanc { get; set; }

    public byte? PotansiyelHesapTuru { get; set; }

    public byte? MusteriTuru { get; set; }

    public string? IsModeli { get; set; }

    public byte? TedarikciTuru { get; set; }

    public bool? Oncelikli { get; set; }

    public string? Uyari { get; set; }

    public string? MusteriDurumu { get; set; }

    public string? Degerlendirme { get; set; }

    public short? CalisanSayisi { get; set; }

    public short? SubeSayisi { get; set; }

    public short? AracSayisi { get; set; }

    public byte? MakineTezgahSayisi { get; set; }

    public DateTime? TalepTarihi { get; set; }

    public DateTime? SonrakiGorusmeTarihi { get; set; }

    public string? IlgilenilenUrun { get; set; }

    public string? MevcutYazilimlar { get; set; }

    public bool? YeniYazilim { get; set; }

    public string? YazilimSuresi { get; set; }

    public string? Aciklama { get; set; }

    public string? VergiDairesi { get; set; }

    public string? VergiNo { get; set; }

    public string? HarcamaBirimiVergiNo { get; set; }

    public string? Telefon1 { get; set; }

    public string? Telefon2 { get; set; }

    public string? Telefon3 { get; set; }

    public string? Gsm { get; set; }

    public string? Faks { get; set; }

    public string? EPosta { get; set; }

    public string? EFaturaPketiketi { get; set; }

    public string? Evdadresi { get; set; }

    public string? KayitliElektronikPostaKep { get; set; }

    public string? Fgbmektup { get; set; }

    public string? Fgbbsmutabakat { get; set; }

    public string? Fgbbamutabakat { get; set; }

    public string? FgbteklifSozlesme { get; set; }

    public string? Fgbekstre { get; set; }

    public int? RbvergiLevhasi { get; set; }

    public int? RbticariSicilGazetesi { get; set; }

    public int? RbimzaSirkusu { get; set; }

    public int? RbbankaHesapBilgileri { get; set; }

    public string? Sifresi { get; set; }

    public string? WebSite { get; set; }

    public string? Fadres { get; set; }

    public int? Fsehir { get; set; }

    public int? Filce { get; set; }

    public string? Fsemt { get; set; }

    public string? FpostaKodu { get; set; }

    public short? Fulke { get; set; }

    public bool? EBulten { get; set; }

    public int? YmcagriDestekSuresi { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifre { get; set; }

    public string? UzakMasaIp { get; set; }

    public string? UmkullaniciAdi { get; set; }

    public string? Umsifre { get; set; }

    public bool? DovizFaturasi { get; set; }

    public byte? ParaBirimi { get; set; }

    public bool? AlisSatisKuru { get; set; }

    public decimal? KurOrani { get; set; }

    public int? BdsatisHesabi { get; set; }

    public byte? SyvadeKoduId { get; set; }

    public byte? SavadeKoduId { get; set; }

    public string? VadeBaslangici { get; set; }

    public bool? Tevkifatli { get; set; }

    public byte? VergiGrubuId { get; set; }

    public string? FiyatListesi { get; set; }

    public decimal? KrediDegerlendirmesi { get; set; }

    public decimal? KrediLimiti { get; set; }

    public string? KrediGorusu { get; set; }

    public string? OdemeGunu { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Onaylandi { get; set; }

    public DateTime? MusteriOlmaTarihi { get; set; }

    public bool? AlacakDekontlari { get; set; }

    public bool? BorcDekontlari { get; set; }

    public bool? MaliDurumlar { get; set; }

    public string? OzelTalimatlar { get; set; }

    public int? KonumId { get; set; }

    public decimal? SevkiyatAdresi { get; set; }

    public decimal? AmbarSevkiyatAdresi { get; set; }

    public short? SevkiyatSekli { get; set; }

    public byte? TeslimSartiId { get; set; }

    public int? AmbarKodu { get; set; }

    public byte? RotaBilgisi1 { get; set; }

    public byte? RotaBilgisi2 { get; set; }

    public byte? RotaBilgisi3 { get; set; }

    public string? TasimaOdemesi { get; set; }

    public bool? SecmeListesiGerekli { get; set; }

    public bool? PaketlemeListesiGerekli { get; set; }

    public bool? OzelMarkaGerekli { get; set; }

    public bool? MusteriUrunKodlariGerekli { get; set; }

    public bool? SevkiyatOncesiOnayGerekli { get; set; }

    public bool? DepoNumaralariGerekli { get; set; }

    public bool? DepartmanNumaralariGerekli { get; set; }

    public byte? SevkiyatSuresi { get; set; }

    public string? OzelSevkiyatTalimatlari { get; set; }

    public string? RotaNotu { get; set; }

    public decimal? Gpsenlem { get; set; }

    public decimal? Gpsboylam { get; set; }

    public bool? Iskonto { get; set; }

    public double? IskontoOrani { get; set; }

    public int? IskontoBdhesabi { get; set; }

    public string? IskontoNotu { get; set; }

    public double? KomisyonOrani { get; set; }

    public string? FtedarikciKodu { get; set; }

    public string? UtskurumKodu { get; set; }

    public bool? YeniMagzaIndirimi { get; set; }

    public double? YeniMagzaIndirimOrani { get; set; }

    public int? YmindirimBdhesabi { get; set; }

    public string? YmindirimNotu { get; set; }

    public bool? Ambar { get; set; }

    public double? AmbarOrani { get; set; }

    public int? AmbarIndirimiBdhesabi { get; set; }

    public string? AmbarIndirimNotu { get; set; }

    public int? IsOrtagi { get; set; }

    public string? TedarikciDegerlendirme { get; set; }

    public string? VarlikTuru { get; set; }

    public bool EfaturaMukellefi { get; set; }

    public string? EFaturaProfili { get; set; }

    public string? EFaturaSenaryo { get; set; }

    public string? AdiSoyadi { get; set; }

    public int? AlicilarHesapKodu { get; set; }

    public int? SaticilarHesapKodu { get; set; }

    public int? FyihracatAlacaklarHesapKoduId { get; set; }

    public int? FyihracatGelirlerHesapKoduId { get; set; }

    public int? FysatisHesabiId { get; set; }

    public int? FymasrafMerkeziId { get; set; }

    public byte? Ibanbanka1 { get; set; }

    public string? HesapNo1 { get; set; }

    public string? Ibanno1 { get; set; }

    public byte? Ibanno1ParaBirimi { get; set; }

    public byte? Ibanbanka2 { get; set; }

    public string? HesapNo2 { get; set; }

    public string? Ibanno2 { get; set; }

    public byte? Ibanno2ParaBirimi { get; set; }

    public byte? Ibanbanka3 { get; set; }

    public string? HesapNo3 { get; set; }

    public string? Ibanno3 { get; set; }

    public byte? Ibanno3ParaBirimi { get; set; }

    public byte? Ibanbanka4 { get; set; }

    public string? HesapNo4 { get; set; }

    public string? Ibanno4 { get; set; }

    public byte? Ibanno4ParaBirimi { get; set; }

    public string? EkAlan1 { get; set; }

    public string? EkAlan2 { get; set; }

    public string? EkAlan3 { get; set; }

    public string? EkAlan4 { get; set; }

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

    public DateTime? SonGuncellemeTarihi { get; set; }
}
