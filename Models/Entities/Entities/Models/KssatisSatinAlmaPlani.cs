using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KssatisSatinAlmaPlani
{
    public int SatisPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public short? ButcePlaniId { get; set; }

    public string? MaliYil { get; set; }

    public int? UrunId { get; set; }

    public int? MusteriTemsilcisiId { get; set; }

    public int? MusteriId { get; set; }

    public bool? SatisSatinAlma { get; set; }

    public decimal? OncekiDonemMiktari1Ay { get; set; }

    public decimal? Miktari1Ay { get; set; }

    public decimal? BirimFiyati1Ay { get; set; }

    public decimal? IskontoOrani1Ay { get; set; }

    public decimal? UretSatinAlOrani1Ay { get; set; }

    public decimal? OncekiDonemMiktari2Ay { get; set; }

    public decimal? Miktari2Ay { get; set; }

    public decimal? BirimFiyati2Ay { get; set; }

    public decimal? IskontoOrani2Ay { get; set; }

    public decimal? UretSatinAlOrani2Ay { get; set; }

    public decimal? OncekiDonemMiktari3Ay { get; set; }

    public decimal? Miktari3Ay { get; set; }

    public decimal? BirimFiyati3Ay { get; set; }

    public decimal? IskontoOrani3Ay { get; set; }

    public decimal? UretSatinAlOrani3Ay { get; set; }

    public decimal? OncekiDonemMiktari4Ay { get; set; }

    public decimal? Miktari4Ay { get; set; }

    public decimal? BirimFiyati4Ay { get; set; }

    public decimal? IskontoOrani4Ay { get; set; }

    public decimal? UretSatinAlOrani4Ay { get; set; }

    public decimal? OncekiDonemMiktari5Ay { get; set; }

    public decimal? Miktari5Ay { get; set; }

    public decimal? BirimFiyati5Ay { get; set; }

    public decimal? IskontoOrani5Ay { get; set; }

    public decimal? UretSatinAlOrani5Ay { get; set; }

    public decimal? OncekiDonemMiktari6Ay { get; set; }

    public decimal? Miktari6Ay { get; set; }

    public decimal? BirimFiyati6Ay { get; set; }

    public decimal? IskontoOrani6Ay { get; set; }

    public decimal? UretSatinAlOrani6Ay { get; set; }

    public decimal? OncekiDonemMiktari7Ay { get; set; }

    public decimal? Miktari7Ay { get; set; }

    public decimal? BirimFiyati7Ay { get; set; }

    public decimal? IskontoOrani7Ay { get; set; }

    public decimal? UretSatinAlOrani7Ay { get; set; }

    public decimal? OncekiDonemMiktari8Ay { get; set; }

    public decimal? Miktari8Ay { get; set; }

    public decimal? BirimFiyati8Ay { get; set; }

    public decimal? IskontoOrani8Ay { get; set; }

    public decimal? UretSatinAlOrani8Ay { get; set; }

    public decimal? OncekiDonemMiktari9Ay { get; set; }

    public decimal? Miktari9Ay { get; set; }

    public decimal? BirimFiyati9Ay { get; set; }

    public decimal? IskontoOrani9Ay { get; set; }

    public decimal? UretSatinAlOrani9Ay { get; set; }

    public decimal? OncekiDonemMiktari10Ay { get; set; }

    public decimal? Miktari10Ay { get; set; }

    public decimal? BirimFiyati10Ay { get; set; }

    public decimal? IskontoOrani10Ay { get; set; }

    public decimal? UretSatinAlOrani10Ay { get; set; }

    public decimal? OncekiDonemMiktari11Ay { get; set; }

    public decimal? Miktari11Ay { get; set; }

    public decimal? BirimFiyati11Ay { get; set; }

    public decimal? IskontoOrani11Ay { get; set; }

    public decimal? UretSatinAlOrani11Ay { get; set; }

    public decimal? OncekiDonemMiktari12Ay { get; set; }

    public decimal? Miktari12Ay { get; set; }

    public decimal? BirimFiyati12Ay { get; set; }

    public decimal? IskontoOrani12Ay { get; set; }

    public decimal? UretSatinAlOrani12Ay { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual KsbutcePlani? ButcePlani { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Miysahesaplar? Musteri { get; set; }

    public virtual Ikcalisanlar? MusteriTemsilcisi { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
