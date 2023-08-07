using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFyfatura
{
    public long FaturaId { get; set; }

    public int? FinansalDonemId { get; set; }

    public long? BagliFaturaId { get; set; }

    public long? IadeFaturaId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public bool? ParcaliSevkiyat { get; set; }

    public string? FaturaTuruId { get; set; }

    public short? TicariIslemGrubuId { get; set; }

    public int? ProjeId { get; set; }

    public bool? EFatura { get; set; }

    public string? ProfilTipi { get; set; }

    public string? SenaryoTipi { get; set; }

    public string? GumrukBeyannameId { get; set; }

    public int? SiparisKodu { get; set; }

    public int? SasiparisId { get; set; }

    public int? MusteriMalzemeTeslimFisiId { get; set; }

    public int? TaseronMalzemeTeslimFisiId { get; set; }

    public int? MusteriKoduId { get; set; }

    public string? SeriSiraNo { get; set; }

    public string? SonSeriSiraNo { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public string? Konu { get; set; }

    public string? MusteriSatinAlmaNo { get; set; }

    public string? Aciklama { get; set; }

    public string? GizliAciklama { get; set; }

    public bool? Earsiv { get; set; }

    public int? AmbarSevkiyatAdresiId { get; set; }

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

    public decimal? StopajTutari { get; set; }

    public decimal? DstopajTutari { get; set; }

    public decimal? SigortaTutari { get; set; }

    public decimal? DsigortaTutari { get; set; }

    public decimal? DagitilacakFiyatArttirimi { get; set; }

    public decimal? DdagitilacakFiyatArttirimi { get; set; }

    public string? DagitilacakFiyatArttirimSebebi { get; set; }

    public decimal? FiyatArttirimi { get; set; }

    public decimal? DfiyatArttirimi { get; set; }

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

    public short? SevkiyatYontemiId { get; set; }

    public byte? TeslimSartiId { get; set; }

    public int? SevkEmriId { get; set; }

    public int? TasiyiciFirmaId { get; set; }

    public string? GonderiKodu { get; set; }

    public int? IrsTeslimEden { get; set; }

    public int? IrsDagitimElemani { get; set; }

    public short? IrsAracPlakasi { get; set; }

    public string? IrsSoforTcno { get; set; }

    public string? IrsSoforAdi { get; set; }

    public string? IrsSoforSoyadi { get; set; }

    public string? IrsAracPlakaNo { get; set; }

    public string? IrsDorsePlakasi { get; set; }

    public string? IrsSateslimEden { get; set; }

    public string? IrsSaaracPlakasi { get; set; }

    public int? IrsSateslimAlan { get; set; }

    public string? IrsTeslimAlan { get; set; }

    public bool? DovizFaturasi { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? Kuru { get; set; }

    public byte? RparaBirimi { get; set; }

    public decimal? Rkuru { get; set; }

    public byte? SyvadeKoduId { get; set; }

    public byte? SavadeKoduId { get; set; }

    public decimal? Hacim { get; set; }

    public byte? AmbalajAdedi { get; set; }

    public decimal? BrutAgirlik { get; set; }

    public decimal? NetAgirlik { get; set; }

    public bool? MalzemeTeslimFisi { get; set; }

    public int? MusteriTemsilcisiId { get; set; }

    public bool? Yazdirildi { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public int? YazdiranCalisanId { get; set; }

    public bool? OtomatikYevmiyeKaydi { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public int? YevmiyeKaydiYapanId { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public int? VarsayilanMasrafMerkeziId { get; set; }

    public bool? FaturaOnayi { get; set; }

    public string? RedSebebi { get; set; }

    public int? FaturayiOnaylayanId { get; set; }

    public DateTime? FaturaOnayTarihi { get; set; }

    public bool? FaturaOnayGonderildi { get; set; }

    public DateTime? FaturaOnayGonderimTarihi { get; set; }

    public int? FaturaOnayGonderenId { get; set; }

    public DateTime? FaturaGenelMudurOnayTarihi { get; set; }

    public bool? FaturaGenelMudurOnayi { get; set; }

    public int? FaturaOnaylayanGenelMudurId { get; set; }

    public bool? IptalEdildi { get; set; }

    public DateTime? IptalTarihi { get; set; }

    public int? IptalEdenCalisanId { get; set; }

    public long? BelgeId { get; set; }

    public int? EvrakId { get; set; }

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

    public string? GenelToplamYazi { get; set; }

    public bool? Gonderildi { get; set; }

    public string? EfaturaSonucId { get; set; }

    public DateTime? EfaturaSonucTarih { get; set; }

    public int? EfaturaSendedCount { get; set; }
}
