using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFyfaturalar
{
    public long FaturaId { get; set; }

    public int? FinansalDonemId { get; set; }

    public string? MaliYil { get; set; }

    public string? MaliAy { get; set; }

    public string? MaliDonem { get; set; }

    public long? BagliFaturaId { get; set; }

    public long? IadeFaturaId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public byte? IsAlani { get; set; }

    public string? FaturaTuruId { get; set; }

    public string? FaturaKoduTuru { get; set; }

    public short? TicariIslemGrubu { get; set; }

    public string? Aciklama { get; set; }

    public int? ProjeId { get; set; }

    public string? ProjeKoduAdi { get; set; }

    public bool? EFatura { get; set; }

    public string? ProfilTipi { get; set; }

    public string? SenaryoTipi { get; set; }

    public string? GumrukBeyannameId { get; set; }

    public int? SiparisKodu { get; set; }

    public int? SasiparisId { get; set; }

    public int? MusteriMalzemeTeslimFisiId { get; set; }

    public int? TaseronMalzemeTeslimFisiId { get; set; }

    public int? MusteriKoduId { get; set; }

    public string? CariHesapKodu { get; set; }

    public string? CariHesapAdi { get; set; }

    public string? SeriSiraNo { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public string? Konu { get; set; }

    public string? MusteriSatinAlmaNo { get; set; }

    public string? FaturaAciklamasi { get; set; }

    public string? GizliAciklama { get; set; }

    public int? AmbarSevkiyatAdresiId { get; set; }

    public string? AmbarSevkiyatAdresiAdi { get; set; }

    public string? AmbarSevkiyatAdresi { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Dtoplam { get; set; }

    public decimal? IskontoluToplam { get; set; }

    public decimal? DiskontoluToplam { get; set; }

    public decimal? Kdvtevkifati { get; set; }

    public decimal? Dkdvtevkifati { get; set; }

    public decimal? Kdvtoplami { get; set; }

    public decimal? Dkdvduzeltme { get; set; }

    public decimal? Dkdvtoplami { get; set; }

    public byte? StopajKoduId { get; set; }

    public string? StopajKoduAdi { get; set; }

    public decimal? StopajTutari { get; set; }

    public decimal? DstopajTutari { get; set; }

    public decimal? SigortaTutari { get; set; }

    public decimal? DsigortaTutari { get; set; }

    public decimal? NavlunTutari { get; set; }

    public decimal? DnavlunTutari { get; set; }

    public decimal? Fobtutari { get; set; }

    public decimal? Dfobtutari { get; set; }

    public decimal? ToplamDuzeltme { get; set; }

    public decimal? DtoplamDuzeltme { get; set; }

    public decimal? GenelToplam { get; set; }

    public decimal? DgenelToplam { get; set; }

    public DateTime? IrsDuzenlemeTarihi { get; set; }

    public DateTime? IrsFiiliSevkTarihi { get; set; }

    public bool? DovizFaturasi { get; set; }

    public byte? ParaBirimiId { get; set; }

    public string? ParaBirimi { get; set; }

    public decimal? Kuru { get; set; }

    public byte? RparaBirimi { get; set; }

    public string? RaporlamaParaBirimi { get; set; }

    public decimal? Rkuru { get; set; }

    public byte? SyvadeKoduId { get; set; }

    public string? SatisVadeKodu { get; set; }

    public string? SatisVadeKoduAciklama { get; set; }

    public byte? SavadeKoduId { get; set; }

    public string? SatinalmaVadeKodu { get; set; }

    public string? SatinalmaVadeKoduAciklama { get; set; }

    public bool? FaturaOnayi { get; set; }

    public int? FaturayiOnaylayanId { get; set; }

    public string? FaturaOnaylayan { get; set; }

    public DateTime? FaturaOnayTarihi { get; set; }

    public bool? FaturaOnayGonderildi { get; set; }

    public bool? IptalEdildi { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public string? EfaturaSonucId { get; set; }

    public DateTime? EfaturaSonucTarih { get; set; }

    public int? EfaturaSendedCount { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public string? MasrafMerkeziKodu { get; set; }

    public string? MasrafMerkeziAdi { get; set; }
}
