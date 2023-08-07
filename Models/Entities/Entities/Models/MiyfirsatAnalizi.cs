using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiyfirsatAnalizi
{
    public int FirsatAnalizId { get; set; }

    public int FirsatId { get; set; }

    public int? FirsatDetayiId { get; set; }

    public string? FaaliyetAdi { get; set; }

    public string? FaaliyetTuru { get; set; }

    public short? MaliyetTuruId { get; set; }

    public int? UrunId { get; set; }

    public string? SanalUrunKodu { get; set; }

    public string? SanalUrunAdi { get; set; }

    public string? Turu { get; set; }

    public string? Adet { get; set; }

    public string? Cap { get; set; }

    public string? En { get; set; }

    public string? Boy { get; set; }

    public string? Kalinlik { get; set; }

    public string? OzgulAgirlik { get; set; }

    public decimal? FireOrani { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birim { get; set; }

    public decimal? VardiyaAdet { get; set; }

    public short? AdamSayisi { get; set; }

    public decimal? OperasyonAdedi { get; set; }

    public decimal? SetupSuresi { get; set; }

    public decimal? SetupAdedi { get; set; }

    public decimal? BirimFiyati { get; set; }

    public decimal? DovizFiyati { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? Kur { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Dtoplam { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PolcuBirimleri? BirimNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miyfirsatlar Firsat { get; set; } = null!;

    public virtual MiyfirsatDetayi? FirsatDetayi { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
