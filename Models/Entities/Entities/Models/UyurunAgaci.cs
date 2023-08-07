using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunAgaci
{
    public long UrunAgaciId { get; set; }

    public long? UstUrunAgaciId { get; set; }

    public string? RevizyonNo { get; set; }

    public int? UrunId { get; set; }

    public int? ProjeId { get; set; }

    public float? StandartSure { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public decimal? KullanilanMiktar { get; set; }

    public decimal? FireMiktari { get; set; }

    public bool? TamSayi { get; set; }

    public bool? OtomatikTuketim { get; set; }

    public bool? Ozel { get; set; }

    public bool? YanYarimamul { get; set; }

    public long? PaketId { get; set; }

    public string? Aciklama { get; set; }

    public string? OpsiyonGrubu { get; set; }

    public short? VarsayilanMiktar { get; set; }

    public short? MinimumMiktar { get; set; }

    public short? MaksimumMiktar { get; set; }

    public int? UrunKategorisiId { get; set; }

    public string? Turu { get; set; }

    public string? Cap { get; set; }

    public string? En { get; set; }

    public string? Boy { get; set; }

    public string? Kalinlik { get; set; }

    public string? Skalinlik { get; set; }

    public int? MalzemeId { get; set; }

    public string? BoyutI { get; set; }

    public string? BoyutIi { get; set; }

    public string? BoyutIii { get; set; }

    public string? BoyutIv { get; set; }

    public string? BoyutV { get; set; }

    public string? BoyutVi { get; set; }

    public string? Adet { get; set; }

    public string? OzgulAgirlik { get; set; }

    public short? Seviye { get; set; }

    public string? UretimHatti { get; set; }

    public int? TeslimAlinacakKonum { get; set; }

    public int? TeslimEdilecekKonum { get; set; }

    public string? RotaGrubuId { get; set; }

    public string? Sdohash { get; set; }

    public string? SdocriticalHash { get; set; }

    public long? SablonUrunAgaci { get; set; }

    public int? SablonUrunId { get; set; }

    public string? SmartBoxFonksiyonu { get; set; }

    public short? ParcaSayisi { get; set; }

    public byte? RotaSayisi { get; set; }

    public bool? Arsiv { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<UyurunAgaci> InversePaket { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunAgaci> InverseUstUrunAgaci { get; set; } = new List<UyurunAgaci>();

    public virtual Uyurunler? Malzeme { get; set; }

    public virtual UyurunAgaci? Paket { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual Uyurunler? SablonUrun { get; set; }

    public virtual UyurunAgaciHavuzu? SablonUrunAgaciNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual Uykonum? TeslimAlinacakKonumNavigation { get; set; }

    public virtual Uykonum? TeslimEdilecekKonumNavigation { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual UyurunKategorisi? UrunKategorisi { get; set; }

    public virtual UyurunAgaci? UstUrunAgaci { get; set; }

    public virtual ICollection<UyurunAgaciKullanilanOpsiyonlar> UyurunAgaciKullanilanOpsiyonlars { get; set; } = new List<UyurunAgaciKullanilanOpsiyonlar>();
}
