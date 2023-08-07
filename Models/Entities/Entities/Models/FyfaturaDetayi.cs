using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyfaturaDetayi
{
    public long FaturaDetayiId { get; set; }

    public long? FaturaId { get; set; }

    public short? SiraNo { get; set; }

    public int? UrunKoduId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Miktari { get; set; }

    public decimal? BirimFiyati { get; set; }

    public decimal? DfiyatArttirimi { get; set; }

    public decimal? FiyatArttirimi { get; set; }

    public string? FiyatArttirimSebebi { get; set; }

    public int? OlcuBirimiId { get; set; }

    public double? IskontoOrani { get; set; }

    public byte? KdvOrani { get; set; }

    public string? VergiMuafiyetSebebiId { get; set; }

    public decimal? Kdvtutari { get; set; }

    public decimal? KdvtevkifatiTutari { get; set; }

    public string? TevkifatTuruId { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public decimal? IskontoTutari { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Dtoplam { get; set; }

    public decimal? DovizFiyati { get; set; }

    public decimal? Kur { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? BirimMaliyeti { get; set; }

    public int? CariHareketId { get; set; }

    public int? KonumId { get; set; }

    public int? TeslimEdilecekKonumId { get; set; }

    public byte? KullanimTuruId { get; set; }

    public int? MuhasebeHesapId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public byte? IsAlaniId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? SasiparisDetayiId { get; set; }

    public long? HareketReferansiId { get; set; }

    public long? IrsaliyeId { get; set; }

    public long? IrsaliyeDetayiId { get; set; }

    public long? BakimPlaniDetayiId { get; set; }

    public int? MusteriMalzemeTeslimFisiDetayiId { get; set; }

    public int? TaseronMalzemeTeslimHareketleriId { get; set; }

    public int? SahareketOzelKoduId { get; set; }

    public string? Raf { get; set; }

    public string? Bolme { get; set; }

    public string? Sira { get; set; }

    public string? PaketKapId { get; set; }

    public string? PaketKapNo { get; set; }

    public byte? PaketKapAdet { get; set; }

    public string? PaketKapMarka { get; set; }

    public string? GumrukTakipNo { get; set; }

    public byte? UrunMensei { get; set; }

    public int? MusteriTemsilcisiId { get; set; }

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

    public virtual FmiysacariHesapHareketleri? CariHareket { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual ICollection<FyfaturaDetayiArttirimIndirim> FyfaturaDetayiArttirimIndirims { get; set; } = new List<FyfaturaDetayiArttirimIndirim>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FyyevmiyeDefteriDetayiMasrafMerkezleri> FyyevmiyeDefteriDetayiMasrafMerkezleris { get; set; } = new List<FyyevmiyeDefteriDetayiMasrafMerkezleri>();

    public virtual SateklifSiparisTeslimatHareketi? HareketReferansi { get; set; }

    public virtual ICollection<FyfaturaDetayi> InverseIrsaliyeDetayi { get; set; } = new List<FyfaturaDetayi>();

    public virtual Fyfatura? Irsaliye { get; set; }

    public virtual FyfaturaDetayi? IrsaliyeDetayi { get; set; }

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PMiysavergiTuru? KdvOraniNavigation { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual FyhesapPlani? MuhasebeHesap { get; set; }

    public virtual UymusteriMalzemeTeslimFisiDetayi? MusteriMalzemeTeslimFisiDetayi { get; set; }

    public virtual Ikcalisanlar? MusteriTemsilcisi { get; set; }

    public virtual PolcuBirimleri? OlcuBirimi { get; set; }

    public virtual PLypaketKapCinsleri? PaketKap { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual PFyfaturaHareketOzelKodlari? SahareketOzelKodu { get; set; }

    public virtual SateklifSiparisDetayi? SasiparisDetayi { get; set; }

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketis { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UytaseronMalzemeTeslimHareketleri? TaseronMalzemeTeslimHareketleri { get; set; }

    public virtual Uykonum? TeslimEdilecekKonum { get; set; }

    public virtual PFytevkifatTurleri? TevkifatTuru { get; set; }

    public virtual Uyurunler? UrunKodu { get; set; }

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual PFyvergiIstisnaSebebi? VergiMuafiyetSebebi { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();
}
