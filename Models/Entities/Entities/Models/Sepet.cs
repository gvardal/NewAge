using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Sepet
{
    public int SepetId { get; set; }

    public int? KullaniciId { get; set; }

    public string? OturumId { get; set; }

    public DateTime? Tarih { get; set; }

    public int? SiparisId { get; set; }

    public int? UrunId { get; set; }

    public decimal? Miktar { get; set; }

    public string? Aciklama { get; set; }

    public int? OlcuBirimi { get; set; }

    public decimal? BirimFiyat { get; set; }

    public decimal? ToplamFiyat { get; set; }

    public double? IskontoOrani { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? Kullanici { get; set; }

    public virtual PolcuBirimleri? OlcuBirimiNavigation { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
