using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Uyurunler
{
    public int UrunId { get; set; }

    public string? Adi { get; set; }

    public string? UrunKodu { get; set; }

    public byte? RevizyonNo { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public string? ResimNo { get; set; }

    public string? UrunAciklamasi { get; set; }

    public string? Teknik1 { get; set; }

    public string? Teknik2 { get; set; }

    public string? Teknik3 { get; set; }

    public string? Etiketler { get; set; }

    public int? UrunKategorisiId { get; set; }

    public short? UrunMarkasiId { get; set; }

    public short? UrunGrubuId { get; set; }

    public string? Gtipkodu { get; set; }

    public byte[]? UrunResim { get; set; }

    public string? UrunTeknikDokumani { get; set; }

    public string? UrunMontajSemasi { get; set; }

    public string? UrunMontajTalimati { get; set; }

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

    public bool? Secili { get; set; }

    public int? SecenId { get; set; }

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

    public virtual FyhesapPlani? ArGeMuhasebeHesap { get; set; }

    public virtual ICollection<BydegisenParcaListesi> BydegisenParcaListesis { get; set; } = new List<BydegisenParcaListesi>();

    public virtual UyisAkisSoruGruplari? CikisKaliteKontrolSoruGrubu { get; set; }

    public virtual Uyurunler? DevamUrunu { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<FyefaturaDetay> FyefaturaDetays { get; set; } = new List<FyefaturaDetay>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FysatilanMalinMaliyetDetayi> FysatilanMalinMaliyetDetayis { get; set; } = new List<FysatilanMalinMaliyetDetayi>();

    public virtual ICollection<FysatilanMalinMaliyeti> FysatilanMalinMaliyetis { get; set; } = new List<FysatilanMalinMaliyeti>();

    public virtual UyisAkisSoruGruplari? GirdiKaliteKontrolSoruGrubu { get; set; }

    public virtual PolcuBirimleri? IisatinAlmaOlcuBirimi { get; set; }

    public virtual PolcuBirimleri? IiuretimOlcuBirimi { get; set; }

    public virtual ICollection<Uyurunler> InverseDevamUrunu { get; set; } = new List<Uyurunler>();

    public virtual PMiysavergiTuru? KdvoraniNavigation { get; set; }

    public virtual PGnltanimlar? KkdilgiliOrgan { get; set; }

    public virtual ICollection<KssatisSatinAlmaPlani> KssatisSatinAlmaPlanis { get; set; } = new List<KssatisSatinAlmaPlani>();

    public virtual ICollection<KsstokVarsayimlari> KsstokVarsayimlaris { get; set; } = new List<KsstokVarsayimlari>();

    public virtual ICollection<Ksswotanalizi> Ksswotanalizis { get; set; } = new List<Ksswotanalizi>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual FyhesapPlani? MaliyetMuhasebeHesap { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnalizis { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<Miyfirsatlar> Miyfirsatlars { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<MiykampanyaUrunler> MiykampanyaUrunlers { get; set; } = new List<MiykampanyaUrunler>();

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesis { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual PUyolcuBirimiTurleri? OlcuBirimiTuru { get; set; }

    public virtual ICollection<PFyfaturaHareketOzelKodlari> PFyfaturaHareketOzelKodlaris { get; set; } = new List<PFyfaturaHareketOzelKodlari>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiFystandartMaliyetSonUruns { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPyprojeAksiyonlariUruns { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PyprojeHavuzu> PyprojeHavuzus { get; set; } = new List<PyprojeHavuzu>();

    public virtual ICollection<Pyprojeler> Pyprojelers { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<RymalzemeBilgiGuvenlikFormlari> RymalzemeBilgiGuvenlikFormlaris { get; set; } = new List<RymalzemeBilgiGuvenlikFormlari>();

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual PolcuBirimleri? SatinAlmaOlcuBirimi { get; set; }

    public virtual PparaBirimi? SatinAlmaParaBirimi { get; set; }

    public virtual PparaBirimi? SatisParaBirimi { get; set; }

    public virtual Ikcalisanlar? Secen { get; set; }

    public virtual ICollection<Sepet> Sepets { get; set; } = new List<Sepet>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FyhesapPlani? StokMuhasebeHesap { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlanis { get; set; } = new List<SyteslimatPlani>();

    public virtual ICollection<SyurunAciklamalari> SyurunAciklamalaris { get; set; } = new List<SyurunAciklamalari>();

    public virtual PFytevkifatTurleri? TevkifatTuru { get; set; }

    public virtual PolcuBirimleri? UretimOlcuBirimi { get; set; }

    public virtual PUyurunGruplari? UrunGrubu { get; set; }

    public virtual ICollection<UrunIlgiliUrun> UrunIlgiliUrunIlgiliUruns { get; set; } = new List<UrunIlgiliUrun>();

    public virtual ICollection<UrunIlgiliUrun> UrunIlgiliUrunUruns { get; set; } = new List<UrunIlgiliUrun>();

    public virtual UyurunKategorisi? UrunKategorisi { get; set; }

    public virtual UyurunMarkasi? UrunMarkasi { get; set; }

    public virtual ICollection<UrunResimleri> UrunResimleris { get; set; } = new List<UrunResimleri>();

    public virtual PUyurunTuru? UrunTuruNavigation { get; set; }

    public virtual ICollection<UrunYorumlari> UrunYorumlaris { get; set; } = new List<UrunYorumlari>();

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsivis { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsivis { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasis { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmri> UyisEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<UyislemTuru> UyislemTurus { get; set; } = new List<UyislemTuru>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UymusteriMalzemeTeslimFisiDetayi> UymusteriMalzemeTeslimFisiDetayis { get; set; } = new List<UymusteriMalzemeTeslimFisiDetayi>();

    public virtual ICollection<UysambalajBilgisi> UysambalajBilgisiMalzemes { get; set; } = new List<UysambalajBilgisi>();

    public virtual ICollection<UysambalajBilgisi> UysambalajBilgisiUruns { get; set; } = new List<UysambalajBilgisi>();

    public virtual UysambalajMalzemeleri? UysambalajMalzemeleriAmbalajMalzeme { get; set; }

    public virtual ICollection<UysambalajMalzemeleri> UysambalajMalzemeleriMalzemes { get; set; } = new List<UysambalajMalzemeleri>();

    public virtual ICollection<UysarfMalzemeZimmet> UysarfMalzemeZimmets { get; set; } = new List<UysarfMalzemeZimmet>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisiDetayi> UytaseronMalzemeTeslimFisiDetayis { get; set; } = new List<UytaseronMalzemeTeslimFisiDetayi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyurunAgaciAktarma> UyurunAgaciAktarmaAnaUrunNavigations { get; set; } = new List<UyurunAgaciAktarma>();

    public virtual ICollection<UyurunAgaciAktarma> UyurunAgaciAktarmaUruns { get; set; } = new List<UyurunAgaciAktarma>();

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzuAnaUruns { get; set; } = new List<UyurunAgaciHavuzu>();

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzuUruns { get; set; } = new List<UyurunAgaciHavuzu>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciMalzemes { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunAgaciPlanlama> UyurunAgaciPlanlamaUruns { get; set; } = new List<UyurunAgaciPlanlama>();

    public virtual ICollection<UyurunAgaciPlanlama> UyurunAgaciPlanlamaYedekUruns { get; set; } = new List<UyurunAgaciPlanlama>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciSablonUruns { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciUruns { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunEkipmanlari> UyurunEkipmanlaris { get; set; } = new List<UyurunEkipmanlari>();

    public virtual ICollection<UyurunKonumlari> UyurunKonumlaris { get; set; } = new List<UyurunKonumlari>();

    public virtual ICollection<UyurunOzellikleri> UyurunOzellikleris { get; set; } = new List<UyurunOzellikleri>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiFasonUruns { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiUruns { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunStogu> UyurunStogus { get; set; } = new List<UyurunStogu>();

    public virtual ICollection<UyyerineKullanilacakUrunler> UyyerineKullanilacakUrunlerUruns { get; set; } = new List<UyyerineKullanilacakUrunler>();

    public virtual ICollection<UyyerineKullanilacakUrunler> UyyerineKullanilacakUrunlerYedekUruns { get; set; } = new List<UyyerineKullanilacakUrunler>();

    public virtual Uykonum? VarsayilanSevkiyatKonum { get; set; }

    public virtual FyhesapPlani? YdsatisMuhasebeHesap { get; set; }

    public virtual FyhesapPlani? YisatisIadeMuhasebeHesap { get; set; }

    public virtual FyhesapPlani? YisatisMuhasebeHesap { get; set; }

    public virtual ICollection<Ymcanlilar> Ymcanlilars { get; set; } = new List<Ymcanlilar>();

    public virtual ICollection<YmmusteriBakimPlaniDegisenParcalar> YmmusteriBakimPlaniDegisenParcalars { get; set; } = new List<YmmusteriBakimPlaniDegisenParcalar>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemes { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleris { get; set; } = new List<YmmusteriIstekSikayetleri>();
}
