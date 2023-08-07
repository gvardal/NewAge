using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunAgaciHavuzu
{
    public long UrunAgaciId { get; set; }

    public long? UstUrunAgaciId { get; set; }

    public int? UrunId { get; set; }

    public float? StandartSure { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public decimal? KullanilanMiktar { get; set; }

    public bool? OtomatikTuketim { get; set; }

    public bool? Ozel { get; set; }

    public long? PaketId { get; set; }

    public string? Aciklama { get; set; }

    public short? OpsiyonGrubu { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public short? Seviye { get; set; }

    public int? TeslimAlinacakKonum { get; set; }

    public int? TeslimEdilecekKonum { get; set; }

    public int? AnaUrunId { get; set; }

    public decimal? VarsayilanAdet { get; set; }

    public decimal? MinimumAdet { get; set; }

    public decimal? MaximumAdet { get; set; }

    public int? OpsiyonGrubuSecenekId { get; set; }

    public byte? OlcuHesapTuru { get; set; }

    public string? SmartBoxFonksiyonu { get; set; }

    public virtual Uyurunler? AnaUrun { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<UyurunAgaciHavuzu> InverseUstUrunAgaci { get; set; } = new List<UyurunAgaciHavuzu>();

    public virtual PUyopsiyonGrubu? OpsiyonGrubuNavigation { get; set; }

    public virtual PUyopsiyonGrubuSecenekleri? OpsiyonGrubuSecenek { get; set; }

    public virtual Uykonum? TeslimAlinacakKonumNavigation { get; set; }

    public virtual Uykonum? TeslimEdilecekKonumNavigation { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual UyurunAgaciHavuzu? UstUrunAgaci { get; set; }

    public virtual ICollection<UyurunAgaci> UyurunAgacis { get; set; } = new List<UyurunAgaci>();
}
