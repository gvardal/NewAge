using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiyihaleTeminatMektuplari
{
    public int TeminatMektubuId { get; set; }

    public int? FirsatId { get; set; }

    public string? MektupNo { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? GercerlilikTarihi { get; set; }

    public string? IsinAdi { get; set; }

    public int? HesapId { get; set; }

    public byte? BankaHesabiId { get; set; }

    public decimal? Tutari { get; set; }

    public byte? ParaBirimiId { get; set; }

    public DateTime? MasrafTarihi { get; set; }

    public decimal? Masraf { get; set; }

    public double? YillikOrani { get; set; }

    public byte? TuruId { get; set; }

    public byte? DurumId { get; set; }

    public DateTime? KurumdanAlmaTarihi { get; set; }

    public int? AlmaSorumluId { get; set; }

    public DateTime? IadeTarihi { get; set; }

    public int? IadeSorumluId { get; set; }

    public long? BelgeId { get; set; }

    public long? IadeBelgeId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? AlmaSorumlu { get; set; }

    public virtual FybankaHesabi? BankaHesabi { get; set; }

    public virtual PFbankalar? BankaHesabiNavigation { get; set; }

    public virtual PMiyteminatMektupDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual Ikcalisanlar? IadeSorumlu { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual PMiyteminatMektupTuru? Turu { get; set; }
}
