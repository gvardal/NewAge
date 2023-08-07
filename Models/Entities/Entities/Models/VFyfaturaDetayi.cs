using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFyfaturaDetayi
{
    public long FaturaDetayiId { get; set; }

    public long? FaturaId { get; set; }

    public short? SiraNo { get; set; }

    public int? UrunKoduId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Miktari { get; set; }

    public decimal? BirimFiyati { get; set; }

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
}
