using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UystokHareketiArsivi
{
    public long StokHareketiId { get; set; }

    public int? UrunId { get; set; }

    public int? KonumId { get; set; }

    public DateTime? HareketTarihi { get; set; }

    public string? StokHareketiTuruId { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Iimiktar { get; set; }

    public decimal? AyrilmisMiktar { get; set; }

    public decimal? Bakiye { get; set; }

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
}
