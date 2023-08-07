using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SateklifSiparisDetayi
{
    public long TeklifSiparisDetayiId { get; set; }

    public int? TeklifSiparisId { get; set; }

    public long? GenelTalepId { get; set; }

    public long? MalzemeIhtiyacPlaniId { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public long? SatisSiparisDetayiId { get; set; }

    public int? ProjeId { get; set; }

    public int? MalzemeUrunAdi { get; set; }

    public string? SanalUrunKodu { get; set; }

    public string? SanalUrunAdi { get; set; }

    public int? KategoriAdi { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? KalanMiktar { get; set; }

    public int? Birim { get; set; }

    public decimal? Iimiktar { get; set; }

    public int? IiolcuBirimiId { get; set; }

    public decimal? BirimFiyat { get; set; }

    public double? IskontoOrani { get; set; }

    public byte? DurumId { get; set; }

    public byte? Kdvorani { get; set; }

    public decimal? Kdvtutari { get; set; }

    public decimal? Dkdvtutari { get; set; }

    public decimal? KdvtevkifatiTutari { get; set; }

    public string? TevkifatTuruId { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public decimal? ToplamFiyat { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? EnErkenTerminTarihi { get; set; }

    public byte? ParaBirimi { get; set; }

    public decimal? DovizKarsiligi { get; set; }

    public decimal? KurOrani { get; set; }

    public string? Aciklama { get; set; }

    public string? EkAciklama { get; set; }

    public string? GizliAciklama { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? Tdfiyat { get; set; }

    public string? TdodemeKosulu { get; set; }

    public string? TdurunKalitesi { get; set; }

    public string? TdteslimZamani { get; set; }

    public bool? TeklifOnayi { get; set; }

    public bool? SiparisOnayi { get; set; }

    public string? SiparisRedSebebi { get; set; }

    public int? SiparisiOnaylayanId { get; set; }

    public DateTime? SiparisOnayTarihi { get; set; }

    public int? MuhasebeHesapId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PolcuBirimleri? BirimNavigation { get; set; }

    public virtual PSatalepDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual PolcuBirimleri? IiolcuBirimi { get; set; }

    public virtual UyurunKategorisi? KategoriAdiNavigation { get; set; }

    public virtual PMiysavergiTuru? KdvoraniNavigation { get; set; }

    public virtual UymalzemeIhtiyacPlani? MalzemeIhtiyacPlani { get; set; }

    public virtual Uyurunler? MalzemeUrunAdiNavigation { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual FyhesapPlani? MuhasebeHesap { get; set; }

    public virtual PparaBirimi? ParaBirimiNavigation { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketis { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual SasatinAlmaTalebi? SatinAlmaTalebi { get; set; }

    public virtual SysiparisDetayi? SatisSiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SiparisiOnaylayan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual SateklifSipari? TeklifSiparis { get; set; }

    public virtual PFytevkifatTurleri? TevkifatTuru { get; set; }
}
