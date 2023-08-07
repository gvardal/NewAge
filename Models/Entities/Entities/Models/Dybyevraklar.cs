using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Dybyevraklar
{
    public int EvrakId { get; set; }

    public byte? FirmaId { get; set; }

    /// <summary>
    /// 1=Doküman,2=Belge,3=Firma Tanıtımları,4=Urun Tasarımları,5=Proje Ekleri 
    /// </summary>
    public byte? EvrakTuru { get; set; }

    public string? EvrakNo { get; set; }

    public string? EvrakAdi { get; set; }

    public short? KategoriId { get; set; }

    public byte? DurumId { get; set; }

    public string? Aciklama { get; set; }

    public string? Etiketler { get; set; }

    public string? DosyaYolu { get; set; }

    public string? DosyaAdi { get; set; }

    public string? DosyaUzantisi { get; set; }

    public string? DosyaMetinVerisi { get; set; }

    public short? DyrevizyonNo { get; set; }

    public DateTime? DyrevizyonTarihi { get; set; }

    public int? DyoncekiDokumanId { get; set; }

    public int? DyhazirlayanId { get; set; }

    public byte? DyilgiliStandartId { get; set; }

    public string? DymaddeNo { get; set; }

    public DateTime? DyyayinTarihi { get; set; }

    public bool? DyonayOzelligi { get; set; }

    public string? DysonRevizyonDetayi { get; set; }

    public string? DyrevizyonDetayi { get; set; }

    public DateTime? DyonayaSunusTarihi { get; set; }

    public int? DyonaylayanId { get; set; }

    public DateTime? DyonayTarihi { get; set; }

    public string? DyonayAciklamasi { get; set; }

    public bool? Dyonay { get; set; }

    public short? DyonaySureciId { get; set; }

    public DateTime? DyiptalTarihi { get; set; }

    public int? DyiptalEdenId { get; set; }

    public string? DyiptalAciklamasi { get; set; }

    /// <summary>
    /// ÇOK GİZLİ”, “GİZLİ”, &quot;KURUMİÇİ&quot; ve “TASNİF DIŞI”
    /// Çeklinde gruplandırılır. Tasnif Dışı herkes görebilir.
    /// Kurum içi sadece şifket içi paylaşılabilir.
    /// Çok Gizli ve Gizli Paylaşılamaz
    /// 
    /// </summary>
    public string? DybygizlilikDerecesi { get; set; }

    public bool? BygidenGelenEvrak { get; set; }

    public int? ByilgiliKurumId { get; set; }

    public int? ByprojeId { get; set; }

    public int? ByfirsatId { get; set; }

    public int? BysiparisId { get; set; }

    public int? BysateklifSiparisId { get; set; }

    public int? ByefaturaId { get; set; }

    public string? EvrakNotu { get; set; }

    public int? NotEkleyenId { get; set; }

    public string? EvrakDegerlendirme { get; set; }

    public int? DegerlendirenId { get; set; }

    public int? ByilgiliDokumanId { get; set; }

    public DateTime? ByhavaleTarihi { get; set; }

    public int? ByhavaleEdenId { get; set; }

    public DateTime? BysaklamaSuresi { get; set; }

    public int? UrunId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Fyefatura? Byefatura { get; set; }

    public virtual Miyfirsatlar? Byfirsat { get; set; }

    public virtual Ikcalisanlar? ByhavaleEden { get; set; }

    public virtual Dybyevraklar? ByilgiliDokuman { get; set; }

    public virtual Miysahesaplar? ByilgiliKurum { get; set; }

    public virtual Pyprojeler? Byproje { get; set; }

    public virtual Sysiparisler? Bysiparis { get; set; }

    public virtual Ikcalisanlar? Degerlendiren { get; set; }

    public virtual PDybydurum? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<DybyevrakBirimUnvanDagitimi> DybyevrakBirimUnvanDagitimis { get; set; } = new List<DybyevrakBirimUnvanDagitimi>();

    public virtual ICollection<DybyevrakDagitimListesi> DybyevrakDagitimListesis { get; set; } = new List<DybyevrakDagitimListesi>();

    public virtual ICollection<DybyiliskiliEvraklar> DybyiliskiliEvraklarEvraks { get; set; } = new List<DybyiliskiliEvraklar>();

    public virtual ICollection<DybyiliskiliEvraklar> DybyiliskiliEvraklarIliskiliEvraks { get; set; } = new List<DybyiliskiliEvraklar>();

    public virtual ICollection<DybyonayListesi> DybyonayListesis { get; set; } = new List<DybyonayListesi>();

    public virtual Ikcalisanlar? Dyhazirlayan { get; set; }

    public virtual PKystandart? DyilgiliStandart { get; set; }

    public virtual Ikcalisanlar? DyiptalEden { get; set; }

    public virtual Kysurecler? DyonaySureci { get; set; }

    public virtual Ikcalisanlar? Dyonaylayan { get; set; }

    public virtual Dybyevraklar? DyoncekiDokuman { get; set; }

    public virtual ICollection<DyrevizyonTalebi> DyrevizyonTalebis { get; set; } = new List<DyrevizyonTalebi>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmets { get; set; } = new List<FdemirbasZimmet>();

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Dybyevraklar> InverseByilgiliDokuman { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<Dybyevraklar> InverseDyoncekiDokuman { get; set; } = new List<Dybyevraklar>();

    public virtual DybyevrakKategorileri? Kategori { get; set; }

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarIhaleSonucBelges { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarSozlesmeBelges { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarSozlesmeDavetBelges { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miyfirsatlar> MiyfirsatlarYerTeslimiBelges { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarRbbankaHesapBilgileriNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarRbimzaSirkusuNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarRbticariSicilGazetesiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<Miysahesaplar> MiysahesaplarRbvergiLevhasiNavigations { get; set; } = new List<Miysahesaplar>();

    public virtual Ikcalisanlar? NotEkleyen { get; set; }

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<UyurunRotasi> UyurunRotasiKontrolTalimatis { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiUretimTalimatiDokumanis { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
