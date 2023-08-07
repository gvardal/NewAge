using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Miyfirsatlar
{
    public int FirsatId { get; set; }

    public string? FirsatAdi { get; set; }

    public int? UrunId { get; set; }

    public decimal? Miktar { get; set; }

    public int? MusteriKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public int? KontakId { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Telefon1 { get; set; }

    public int? IsOrtagi { get; set; }

    public int? FirsatSahibi { get; set; }

    public string? IhaleNo { get; set; }

    public decimal? Tutar { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? YaklasikMaliyet { get; set; }

    public bool? Ozel { get; set; }

    public DateTime? KapanmaTarihi { get; set; }

    public string? IhaleYeri { get; set; }

    public byte? Durum { get; set; }

    public string? IhaleTuru { get; set; }

    public string? IhaleUsulu { get; set; }

    public byte? Turu { get; set; }

    public byte? SiparisTuruId { get; set; }

    public string? Cinsi { get; set; }

    public string? Onem { get; set; }

    public byte? Olasilik { get; set; }

    public string? Kaynagi { get; set; }

    public long? Kampanya { get; set; }

    public string? IsinMiktari { get; set; }

    public short? IsinSuresi { get; set; }

    public string? IsinYapilacagiYer { get; set; }

    public int? AnalizSorumlusuId { get; set; }

    public decimal? DosyaBedeli { get; set; }

    public bool? EImza { get; set; }

    public decimal? IhaleMasraflari { get; set; }

    public int? AltYukleniciId { get; set; }

    public string? Muhatap { get; set; }

    public string? Aciklama { get; set; }

    public bool? OnayaGonderildi { get; set; }

    public bool? Onay { get; set; }

    public string? Degerlendirme { get; set; }

    public int? DegerlendirenId { get; set; }

    public DateTime? DegerlendirmeTarihi { get; set; }

    public int? IhaleSonucBelgeId { get; set; }

    public int? SozlesmeDavetBelgeId { get; set; }

    public bool? SozlesmeEvraklari { get; set; }

    public int? SozlesmeBelgeId { get; set; }

    public bool? YerTeslimi { get; set; }

    public int? YerTeslimiBelgeId { get; set; }

    public bool? Sgkgirisleri { get; set; }

    public bool? TeknikPersonelBildirimi { get; set; }

    public bool? IsProgramiTeslimi { get; set; }

    public string? EklentiDosyaAdi1 { get; set; }

    public string? EklentiDosyaAdi2 { get; set; }

    public string? EklentiDosyaAdi3 { get; set; }

    public string? EklentiDosyaAdi4 { get; set; }

    public string? EklentiDosyaAdi5 { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public virtual Miysahesaplar? AltYuklenici { get; set; }

    public virtual Ikcalisanlar? AnalizSorumlusu { get; set; }

    public virtual PMiyfirsatDurumu? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? FirsatSahibiNavigation { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual Dybyevraklar? IhaleSonucBelge { get; set; }

    public virtual Miysahesaplar? IsOrtagiNavigation { get; set; }

    public virtual Miykampanyalar? KampanyaNavigation { get; set; }

    public virtual Ikcalisanlar? Kontak { get; set; }

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnalizis { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<MiyfirsatDetayi> MiyfirsatDetayis { get; set; } = new List<MiyfirsatDetayi>();

    public virtual ICollection<MiyihaleDokumanlari> MiyihaleDokumanlaris { get; set; } = new List<MiyihaleDokumanlari>();

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplaris { get; set; } = new List<MiyihaleTeminatMektuplari>();

    public virtual ICollection<MiyisbitirmeBelgeleri> MiyisbitirmeBelgeleris { get; set; } = new List<MiyisbitirmeBelgeleri>();

    public virtual ICollection<MiypmgorusmeSonuclari> MiypmgorusmeSonuclaris { get; set; } = new List<MiypmgorusmeSonuclari>();

    public virtual Miysahesaplar? MusteriKoduNavigation { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual ICollection<Pyprojeler> Pyprojelers { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual PsiparisTuru? SiparisTuru { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Dybyevraklar? SozlesmeBelge { get; set; }

    public virtual Dybyevraklar? SozlesmeDavetBelge { get; set; }

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual PMiyfirsatTuru? TuruNavigation { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual Dybyevraklar? YerTeslimiBelge { get; set; }
}
