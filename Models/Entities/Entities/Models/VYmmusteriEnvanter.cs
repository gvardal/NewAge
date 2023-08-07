using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VYmmusteriEnvanter
{
    public long MusteriEnvanterId { get; set; }

    public string? EnvanterTuru { get; set; }

    public byte[]? UrunResmi { get; set; }

    public byte? FirmaId { get; set; }

    public int? MusteriId { get; set; }

    public int? Musteri1Id { get; set; }

    public int? Musteri2Id { get; set; }

    public int? TedarikciId { get; set; }

    public DateTime? StokGirisTarihi { get; set; }

    public int? UrunId { get; set; }

    public string? EnvanterNo { get; set; }

    public string? BarkodNo { get; set; }

    public string? LotNo { get; set; }

    public string? PaletBarkodu { get; set; }

    public int? MusteriMalzemeTeslimFisiDetayiId { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public int? SiparisId { get; set; }

    public long? HareketReferansiId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public long? BelgeId { get; set; }

    public int? EvrakId { get; set; }

    public int? KonumId { get; set; }

    public int? KonumBolmeId { get; set; }

    public long? IsciZamanKartiId { get; set; }

    public DateTime? GarantiBaslangicTarihi { get; set; }

    public DateTime? GarantiBitisTarihi { get; set; }

    public DateTime? SonKontrolTarihi { get; set; }

    public DateTime? GelecekKontrolTarihi { get; set; }

    public byte? SonYapilanIslem { get; set; }

    public string? CihazinYeri { get; set; }

    public string? Aciklama { get; set; }

    public string? LisansKodu { get; set; }

    public bool? SonUrunKontrolGovde { get; set; }

    public bool? SonUrunKontrolPaket { get; set; }

    public bool? SonUrunKontrolIcAksam { get; set; }

    public bool? SonUrunKontrolEvrak { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? RezervasyonMiktari { get; set; }

    public decimal? TuketilenMiktar { get; set; }

    public decimal? KullanilabilirMiktar { get; set; }

    public decimal? BirimMaliyet { get; set; }

    public string? KontrolSonucu { get; set; }

    public bool? Onay { get; set; }

    public DateTime? SonServisTarihi { get; set; }

    public DateTime? UretimTarihi { get; set; }

    public DateTime? SonTuketimTarihi { get; set; }

    public byte? KontrolPeriyodu { get; set; }

    public byte? GarantiSuresi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonGuncellemeTarihi { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }
}
