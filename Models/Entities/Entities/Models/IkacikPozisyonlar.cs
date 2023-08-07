using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkacikPozisyonlar
{
    public long Id { get; set; }

    public string? ReferansKodu { get; set; }

    public string? PozisyonAdi { get; set; }

    public string? IsTanimi { get; set; }

    public string? ArananNitelikler { get; set; }

    public byte? IsAlaniId { get; set; }

    public string? CalismaSekli { get; set; }

    public bool? CalisanTuru { get; set; }

    public int? Sehir { get; set; }

    public short? Ulke { get; set; }

    /// <summary>
    /// 1-Onayda 2-Onaylandı 3-Aktif 4-İptal Edildi 5-İşe Alındı 6-Uygun Aday Bulunamadı
    /// </summary>
    public byte? DurumId { get; set; }

    public bool? Onaylandi { get; set; }

    public short? BirimId { get; set; }

    public short? Unvan { get; set; }

    public string? IlanVerilenKurum { get; set; }

    public decimal? IlanUcreti { get; set; }

    public DateTime? YayinlamaTarihi { get; set; }

    public DateTime? SonBasvuruTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarhi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikorganizasyonlar? Birim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<IkisBasvurulari> IkisBasvurularis { get; set; } = new List<IkisBasvurulari>();

    public virtual ICollection<IkoryantasyonTakip> IkoryantasyonTakips { get; set; } = new List<IkoryantasyonTakip>();

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Pulkeler? UlkeNavigation { get; set; }

    public virtual Ikunvanlar? UnvanNavigation { get; set; }
}
