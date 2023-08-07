using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SateklifSipari
{
    public int SiparisId { get; set; }

    public byte? FirmaId { get; set; }

    public int? FirsatId { get; set; }

    public int? TeklifSiparisTuru { get; set; }

    public byte? TeklifSiparisSekliId { get; set; }

    public int? ProjeKodu { get; set; }

    public int? TedarikciKodu { get; set; }

    public DateTime? TeklifTarihi { get; set; }

    public int? IhaleId { get; set; }

    public DateTime? IhaleTarihi { get; set; }

    public string? Konu { get; set; }

    public string? TedarikciSiparisNo { get; set; }

    public int? YetkiliId { get; set; }

    public byte? Durum { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string? Aciklama { get; set; }

    public string? GizliAciklama { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? TeklifGecerlilikTarihi { get; set; }

    public byte? OdemeSekli { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? KurOrani { get; set; }

    public bool? SabitKur { get; set; }

    public byte? RparaBirimi { get; set; }

    public decimal? Rkuru { get; set; }

    public short? SevkiyatSekliId { get; set; }

    public byte? TeslimSartiId { get; set; }

    public decimal? Tasima { get; set; }

    public decimal? Dtasima { get; set; }

    public decimal? Yukleme { get; set; }

    public decimal? Dyukleme { get; set; }

    public decimal? AraToplam { get; set; }

    public decimal? DaraToplam { get; set; }

    public decimal? VergiTutari { get; set; }

    public decimal? DvergiTutari { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Dtoplam { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public int? TalepEden { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Onay { get; set; }

    public bool? TedarikciKabul { get; set; }

    public DateTime? TedarikciKabulTarihi { get; set; }

    public int? TedarikciKabulEden { get; set; }

    public int? TeklifAlanId { get; set; }

    public int? SiparisAlanId { get; set; }

    public bool? Yazdirildi { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public int? YazdiranId { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public long? BelgeId { get; set; }

    public int? IsOrtagiKodu { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PSatalepDurumu? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual Saihaleler? Ihale { get; set; }

    public virtual Miysahesaplar? IsOrtagiKoduNavigation { get; set; }

    public virtual PSavadeler? OdemeSekliNavigation { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Pyprojeler? ProjeKoduNavigation { get; set; }

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual SasatinAlmaTalebi? SatinAlmaTalebi { get; set; }

    public virtual PsevkiyatYontemi? SevkiyatSekli { get; set; }

    public virtual Ikcalisanlar? SiparisAlan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Sysasozlesmeler> Sysasozlesmelers { get; set; } = new List<Sysasozlesmeler>();

    public virtual Ikcalisanlar? TalepEdenNavigation { get; set; }

    public virtual Ikcalisanlar? TedarikciKabulEdenNavigation { get; set; }

    public virtual Miysahesaplar? TedarikciKoduNavigation { get; set; }

    public virtual Ikcalisanlar? TeklifAlan { get; set; }

    public virtual PSateklifSiparisSekli? TeklifSiparisSekli { get; set; }

    public virtual PSateklifSiparisTuru? TeklifSiparisTuruNavigation { get; set; }

    public virtual PLyteslimSarti? TeslimSarti { get; set; }

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual Ikcalisanlar? Yetkili { get; set; }
}
