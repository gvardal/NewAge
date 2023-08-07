using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UystokHareketi
{
    public long StokHareketiId { get; set; }

    public int UrunId { get; set; }

    public int KonumId { get; set; }

    public DateTime HareketTarihi { get; set; }

    public string StokHareketiTuruId { get; set; } = null!;

    public decimal Miktar { get; set; }

    public decimal? Iimiktar { get; set; }

    public decimal? AyrilmisMiktar { get; set; }

    public decimal? Bakiye { get; set; }

    public decimal? BirimMaliyet { get; set; }

    public decimal? GerceklesenMaliyet { get; set; }

    public string? Aciklama { get; set; }

    public long? IrsaliyeDetayiId { get; set; }

    public int? SatinAlmaSiparisId { get; set; }

    public int? SatisSiparisId { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public long? UretimVerisiId { get; set; }

    public long? MalzemeIstekFisiId { get; set; }

    public long? MalzemeIstekFisiDetayiId { get; set; }

    public int? StokAmbarFisiId { get; set; }

    public long? TeslimatPlaniId { get; set; }

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

    public bool? Arsiv { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual FyfaturaDetayi? IrsaliyeDetayi { get; set; }

    public virtual UyisEmri? IsEmri { get; set; }

    public virtual Uykonum Konum { get; set; } = null!;

    public virtual UymalzemeIstekFisi? MalzemeIstekFisi { get; set; }

    public virtual UymalzemeIstekFisiDetayi? MalzemeIstekFisiDetayi { get; set; }

    public virtual SateklifSipari? SatinAlmaSiparis { get; set; }

    public virtual Sysiparisler? SatisSiparis { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UystokAmbarFisi? StokAmbarFisi { get; set; }

    public virtual UystokHareketiTuru StokHareketiTuru { get; set; } = null!;

    public virtual SyteslimatPlani? TeslimatPlani { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual UyuretimVerileri? UretimVerisi { get; set; }

    public virtual Uyurunler Urun { get; set; } = null!;

    public virtual ICollection<UysarfMalzemeZimmet> UysarfMalzemeZimmetTeslimAlinanStokHarekets { get; set; } = new List<UysarfMalzemeZimmet>();

    public virtual ICollection<UysarfMalzemeZimmet> UysarfMalzemeZimmetTeslimEdilenStokHarekets { get; set; } = new List<UysarfMalzemeZimmet>();

    public virtual ICollection<UystokHareketiLotNo> UystokHareketiLotNos { get; set; } = new List<UystokHareketiLotNo>();
}
