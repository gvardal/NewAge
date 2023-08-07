using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PfirmaBilgisi
{
    public byte Id { get; set; }

    public string? FirmaAdi { get; set; }

    public string? EnfirmaAdi { get; set; }

    public string? SubeKodu { get; set; }

    public string? VarlikTuru { get; set; }

    public byte? BagliOlduguKurulusId { get; set; }

    public string? Adres { get; set; }

    public string? PostKodu { get; set; }

    public int? Sehir { get; set; }

    public int? Ilce { get; set; }

    public short? Ulke { get; set; }

    public string? Telefon { get; set; }

    public string? Faks { get; set; }

    public string? EPosta { get; set; }

    public string? KayitliElektronikPostaKep { get; set; }

    public string? WebSitesi { get; set; }

    public byte[]? Logo { get; set; }

    public string? Aciklama { get; set; }

    public string? VergiDairesi { get; set; }

    public short? VergiDairesiId { get; set; }

    public string? VergiNo { get; set; }

    public string? NaceKodu { get; set; }

    public string? NaceKoduTanimi { get; set; }

    public string? TicaretSicilNo { get; set; }

    public string? SgksicilNo { get; set; }

    public string? MersisNo { get; set; }

    public string? Duns { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public string? Misyon { get; set; }

    public string? Vizyon { get; set; }

    public string? Degerler { get; set; }

    public string? Politikalar { get; set; }

    public string? FirmaTarihcesi { get; set; }

    public string? LisansAnahtari { get; set; }

    public int? PithalatDeposu { get; set; }

    public int? PilkMaddeMalzemeDeposu { get; set; }

    public int? PyariMamulDeposu { get; set; }

    public int? PmamulStokAmbari { get; set; }

    public int? PfasonDeposu { get; set; }

    public int? PfireDeposu { get; set; }

    public int? PredDeposu { get; set; }

    public int? PdemirbasDeposu { get; set; }

    public int? PcesitliSarfMalzemeDeposu { get; set; }

    public byte? PbankaHesabi { get; set; }

    public bool? FyfinansalYonetim { get; set; }

    public string? FyyevmiyeKayitNo { get; set; }

    public string? FytahsilatYontemi { get; set; }

    public bool? FytahsilatPlanlariOlusturma { get; set; }

    public string? FyfaturalandirmaYontemi { get; set; }

    public string? FykurAtamaYontemi { get; set; }

    public string? FyriskLimitiDenetimYontemi { get; set; }

    /// <summary>
    /// Alacak ve Borç Hesaplarının True olduğunda Ayrılarak 120 ler alacaklarda 320 ler borçlar hesabında gözükmesi sağlanıyor.
    /// </summary>
    public bool? FyalacakBorcHesaplariniAyirma { get; set; }

    /// <summary>
    /// İrsaliyenin Yevmiye Kaydı Yapılmadan Fatura kesilemez.
    /// </summary>
    public bool? FyirsaliyeYevmiyeSarti { get; set; }

    public bool? FyfaturaDetayiGruplandirma { get; set; }

    public bool? FyotomatikYevmiyeKaydi { get; set; }

    public bool? FybhfaturaOnayiGerekli { get; set; }

    public bool? FybhfaturaGenelMudurOnayiGerekli { get; set; }

    public string? FyotomatikFiyatlandirma { get; set; }

    public bool? Fyentegrasyon { get; set; }

    public string? FyentegrasyonTuru { get; set; }

    public byte? FybirimFiyatHassasiyeti { get; set; }

    public byte? FyvarsayilanParaBirimiId { get; set; }

    /// <summary>
    /// Alış=False Satış=True
    /// </summary>
    public bool? FyvarsayilanAlisSatisKuru { get; set; }

    public bool? FystandartMaliyetHesapla { get; set; }

    public string? FymalzemeMaliyetlendirmeYontemi { get; set; }

    public decimal? FysaatlikDirekIscilikUcreti { get; set; }

    public decimal? FygenelYonetimGiderleriKatsayisi { get; set; }

    public int? FystandartMaliyetSonUrunId { get; set; }

    public DateTime? FystandartMaliyetBaslangic { get; set; }

    public DateTime? FystandartMaliyetBitis { get; set; }

    /// <summary>
    /// Maliyet Hesaplaması Bittiğinde Tarih Güncellenir.
    /// </summary>
    public DateTime? FysonMaliyetHesaplamaTarihi { get; set; }

    public int? FydenklestirmeGelirHesabiId { get; set; }

    public int? FydenklestirmeGiderHesabiId { get; set; }

    public int? FydagitilacakFiyatArttirimHesabiId { get; set; }

    /// <summary>
    /// Cari Hesap Açılırken Vergi Numarası ile Aktif başka hesap olup olmadığının kontrolü yapılır.
    /// </summary>
    public bool? MiysacariHesapVergiNoKontrolu { get; set; }

    public string? MiysacariHesapVergiNoAtamaModeli { get; set; }

    public int? MiysacariHesapId { get; set; }

    public string? BybelgeNo { get; set; }

    public string? SssatisIrsaliyeOnEki { get; set; }

    public string? SssatisIrsaliyeNo { get; set; }

    public string? SsfasonIrsaliyeOnEki { get; set; }

    public string? SsfasonIrsaliyeNo { get; set; }

    public string? SssatiseFaturaOnEki { get; set; }

    public string? SssatiseFaturaNo { get; set; }

    public string? SssatiseArsivOnEki { get; set; }

    public string? SssatiseArsivNo { get; set; }

    public string? SssatisFaturaOnEki { get; set; }

    public string? SssatisFaturaNo { get; set; }

    public string? SssatisSiparisNo { get; set; }

    public string? SsalisSiparisNo { get; set; }

    public string? SasatinAlmaModeli { get; set; }

    public long? SagenelTalepNo { get; set; }

    public bool? SatalepOnayEposta { get; set; }

    public bool? SatalepFonOnayiGerekli { get; set; }

    /// <summary>
    /// 0 ise Teklif Değerlendirme esnasında 1 ise Sipariş Esnasında Limit değerler içinde değerlendirme yapılır
    /// </summary>
    public bool? SateklifSiparisOnayNoktasi { get; set; }

    public decimal? SatalepOnayTabani { get; set; }

    public decimal? SatalepOnayTavani { get; set; }

    public decimal? SamalzemeOnayTabani { get; set; }

    public decimal? SamalzemeOnayTavani { get; set; }

    public bool? SamalzemeDepoOnayi { get; set; }

    public string? IkbordroMuhasebeFisiModeli { get; set; }

    public bool? IkegitimOnayGerekli { get; set; }

    public string? UyuretimModeli { get; set; }

    public bool? UyotomatikMalzemeIstekFisi { get; set; }

    /// <summary>
    /// Eğer 0 ise üretim verisi girildikçe malzeme tüketimi gerçekleşir. 1 İse Üretim tamamlandığında otomatik tüketimler gerçekleşir.
    /// </summary>
    public bool? UyotomatikMalzemeTuketimSekli { get; set; }

    /// <summary>
    /// Malzeme Tüketim Modelinde Rassal, Fifo, Lifo ve Lefo şeklide politikalar oluşturulur. 
    /// </summary>
    public string? UymalzemeTuketimModeli { get; set; }

    /// <summary>
    /// 1-Üretim Sonu Otomatik Tüketim : Üretim Sonunda Tuketim Modeline Göre Lot Atama ,2-Tanımlı Lot Tüketimi: Tanımlı Lotu Tüketme ve 3-Planlı Lot Tüketimi :Üretim Öncesi Tuketim Modeline Göre Lot Atama
    /// </summary>
    public string? UymalzemeTuketimPolitikasi { get; set; }

    public bool? UyotomatikMiponayi { get; set; }

    public bool? UymalzemeIhtiyacPlaniOlustur { get; set; }

    public string? UybutunlesikMalzemeIstekFisi { get; set; }

    public string? UycizelgelemeModeli { get; set; }

    public short? UyoperasyonlarArasiBoslukSure { get; set; }

    public double? UyoperasyonlarArasiBoslukYuzde { get; set; }

    public bool? UyurunKonfigrasyonHammaddeOlusturma { get; set; }

    public bool? UystokRezervasyonu { get; set; }

    public bool? UyurunKoduKontrol { get; set; }

    /// <summary>
    /// Parçalı Sevkiyat Yapılırken Üretim Planı Kapanmamış olsa dahi sevk edebilme özelliği
    /// </summary>
    public bool? LyuretimdeSevkiyat { get; set; }

    /// <summary>
    /// Sevkiyat Kontrolü gerekli olup olmadığını kontrol eder. Gerekli ise sevkiyatta kontrol edilen miktar kadar İrsaliye oluşturur.
    /// </summary>
    public bool? LysevkiyatKontrol { get; set; }

    public bool? LyotomatikSevkiyatPlani { get; set; }

    public string? LylojistikYonetimModeli { get; set; }

    public string? YmmusteriEnvanterNo { get; set; }

    public int? PyprojeAksiyonlariUrunId { get; set; }

    public int? FymalinanMusteriCekleri { get; set; }

    public int? FympersonelGiderleriHesabi { get; set; }

    public int? Fymagi { get; set; }

    public int? Fymsgkyardimi { get; set; }

    public int? FympersoneleBorclar { get; set; }

    public int? FymkidemTazminatlari { get; set; }

    public int? FymihbarTazminatlari { get; set; }

    public int? FympersonelGelirVergisi { get; set; }

    public int? FympersonelDamgaVergisi { get; set; }

    public string? GnlsistemDosyaYolu { get; set; }

    public string? GnlscientaAdresi { get; set; }

    public DateTime? ScientaSonOtomatikGorevTarihi { get; set; }

    public string? Gnlscmadresi { get; set; }

    public DateTime? SatsonOtomatikGorevTarihi { get; set; }

    public string? Gnlb2cadresi { get; set; }

    public string? Gnlb2badresi { get; set; }

    public DateTime? B2bsonOtomatikGorevTarihi { get; set; }

    public string? Gnlhrmadresi { get; set; }

    public DateTime? BasarimSonOtomatikGorevTarihi { get; set; }

    public string? Gnlcrmadresi { get; set; }

    public DateTime? LeadsSonOtomatikGorevTarihi { get; set; }

    public string? Gnlqmsadresi { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual ICollection<FcekSenet> FcekSenets { get; set; } = new List<FcekSenet>();

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<FmiysacariHesapHareketleri> FmiysacariHesapHareketleris { get; set; } = new List<FmiysacariHesapHareketleri>();

    public virtual ICollection<FybankaHesabi> FybankaHesabis { get; set; } = new List<FybankaHesabi>();

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();

    public virtual ICollection<Fybutce> Fybutces { get; set; } = new List<Fybutce>();

    public virtual FyhesapPlani? FydagitilacakFiyatArttirimHesabi { get; set; }

    public virtual FyhesapPlani? FydenklestirmeGelirHesabi { get; set; }

    public virtual FyhesapPlani? FydenklestirmeGiderHesabi { get; set; }

    public virtual ICollection<FyfinansalDonemler> FyfinansalDonemlers { get; set; } = new List<FyfinansalDonemler>();

    public virtual ICollection<FyhesapFinansBilgisi> FyhesapFinansBilgisis { get; set; } = new List<FyhesapFinansBilgisi>();

    public virtual ICollection<FyhesapPlani> FyhesapPlanis { get; set; } = new List<FyhesapPlani>();

    public virtual ICollection<Fykasalar> Fykasalars { get; set; } = new List<Fykasalar>();

    public virtual FyhesapPlani? FymalinanMusteriCekleriNavigation { get; set; }

    public virtual FyhesapPlani? FympersonelGiderleriHesabiNavigation { get; set; }

    public virtual Uyurunler? FystandartMaliyetSonUrun { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual PparaBirimi? FyvarsayilanParaBirimi { get; set; }

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayis { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual ICollection<IihaberBandi> IihaberBandis { get; set; } = new List<IihaberBandi>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkfazlaMesai> IkfazlaMesais { get; set; } = new List<IkfazlaMesai>();

    public virtual ICollection<IkmaasOdeme> IkmaasOdemes { get; set; } = new List<IkmaasOdeme>();

    public virtual ICollection<Ikorganizasyonlar> Ikorganizasyonlars { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();

    public virtual Pilceler? IlceNavigation { get; set; }

    public virtual ICollection<KssatisSatinAlmaPlani> KssatisSatinAlmaPlanis { get; set; } = new List<KssatisSatinAlmaPlani>();

    public virtual ICollection<KsstratejikAmaclar> KsstratejikAmaclars { get; set; } = new List<KsstratejikAmaclar>();

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();

    public virtual ICollection<Kysurecler> Kysureclers { get; set; } = new List<Kysurecler>();

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();

    public virtual Miysahesaplar? MiysacariHesap { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual FybankaHesabi? PbankaHesabiNavigation { get; set; }

    public virtual Uykonum? PcesitliSarfMalzemeDeposuNavigation { get; set; }

    public virtual Uykonum? PdemirbasDeposuNavigation { get; set; }

    public virtual Uykonum? PfasonDeposuNavigation { get; set; }

    public virtual Uykonum? PfireDeposuNavigation { get; set; }

    public virtual Uykonum? PilkMaddeMalzemeDeposuNavigation { get; set; }

    public virtual Uykonum? PithalatDeposuNavigation { get; set; }

    public virtual Uykonum? PmamulStokAmbariNavigation { get; set; }

    public virtual Uykonum? PredDeposuNavigation { get; set; }

    public virtual Uykonum? PyariMamulDeposuNavigation { get; set; }

    public virtual Uyurunler? PyprojeAksiyonlariUrun { get; set; }

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual Pulkeler? UlkeNavigation { get; set; }

    public virtual ICollection<UyisEmriArsivi> UyisEmriArsivis { get; set; } = new List<UyisEmriArsivi>();

    public virtual ICollection<UyisEmri> UyisEmris { get; set; } = new List<UyisEmri>();

    public virtual ICollection<Uykonum> Uykonums { get; set; } = new List<Uykonum>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UystokAmbarFisi> UystokAmbarFisis { get; set; } = new List<UystokAmbarFisi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyurunKonumlari> UyurunKonumlaris { get; set; } = new List<UyurunKonumlari>();

    public virtual PFyvergiDaireleri? VergiDairesiNavigation { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
