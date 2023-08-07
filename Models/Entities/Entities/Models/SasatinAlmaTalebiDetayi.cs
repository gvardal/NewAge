using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SasatinAlmaTalebiDetayi
{
    public int SatinAlmaTalebiDetayiId { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public int? UrunKategorisiId { get; set; }

    public int? UrunId { get; set; }

    public byte[]? UrunFotografi { get; set; }

    public decimal? TalepEdilenMiktar { get; set; }

    public decimal? BirimFiyat { get; set; }

    public decimal? DovizFiyati { get; set; }

    public decimal? TahminiButce { get; set; }

    public decimal? DtahminiButce { get; set; }

    public byte? ParaBirimiId { get; set; }

    public byte? Durumu { get; set; }

    public string? Aciklama { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PSatalepDurumu? DurumuNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual SasatinAlmaTalebi? SatinAlmaTalebi { get; set; }

    public virtual SateklifSiparisDetayi? SiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual UyurunKategorisi? UrunKategorisi { get; set; }
}
