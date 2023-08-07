using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SasatinAlmaTalebi
{
    public int SatinAlmaTalebiId { get; set; }

    public byte? FirmaId { get; set; }

    public DateTime? TalepTarihi { get; set; }

    public long? GenelTalepId { get; set; }

    public bool? TalepTuru { get; set; }

    /// <summary>
    /// True= Yatırım Gideri False=Operasyonel Gider
    /// </summary>
    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? ProjeMaliyetAnaliziId { get; set; }

    public int? UrunHizmetAdi { get; set; }

    public int? UrunHizmetKategorisi { get; set; }

    public byte[]? UrunFotografi { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? TalepEdilenMiktar { get; set; }

    public int? Birim { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public byte? Durumu { get; set; }

    public string? Aciklama { get; set; }

    public string? TalepNedeni { get; set; }

    public int? TalepEden { get; set; }

    public short? DepartmanId { get; set; }

    public decimal? TahminiButce { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? DtahminiButce { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public bool? OnayaGonderildi { get; set; }

    public bool? FonYoneticisiOnayi { get; set; }

    public int? OnaylayanFonYoneticisiId { get; set; }

    public DateTime? FonYoneticisiOnayTarihi { get; set; }

    public string? FonYoneticisiAciklama { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Onay { get; set; }

    public string? RedSebebi { get; set; }

    public int? IptalEden { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PolcuBirimleri? BirimNavigation { get; set; }

    public virtual ICollection<BydegisenParcaListesi> BydegisenParcaListesis { get; set; } = new List<BydegisenParcaListesi>();

    public virtual Ikorganizasyonlar? Departman { get; set; }

    public virtual PSatalepDurumu? DurumuNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Ikcalisanlar? IptalEdenNavigation { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? OnaylayanFonYoneticisi { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual PyprojeMaliyetAnalizi? ProjeMaliyetAnalizi { get; set; }

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? TalepEdenNavigation { get; set; }

    public virtual Uyurunler? UrunHizmetAdiNavigation { get; set; }

    public virtual UyurunKategorisi? UrunHizmetKategorisiNavigation { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniDegisenParcalar> YmmusteriBakimPlaniDegisenParcalars { get; set; } = new List<YmmusteriBakimPlaniDegisenParcalar>();
}
