using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunStokDetayi
{
    public int UrunStokDetayiId { get; set; }

    public int? UrunId { get; set; }

    public int? KonumId { get; set; }

    public int? KonumBolmeId { get; set; }

    public string? Boyut { get; set; }

    public decimal? Miktar { get; set; }

    /// <summary>
    /// Beybi Lot Numarası test amaçlı depo cu için koyuldu kaldırılması planlanıyor 19.01.2019
    /// </summary>
    public string? BarkodNo { get; set; }

    public long? MusteriEnvanterId { get; set; }

    public decimal? En { get; set; }

    public decimal? Boy { get; set; }

    public decimal? Yukseklik { get; set; }

    public decimal? Iimiktar { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual UykonumBolmeleri? KonumBolme { get; set; }

    public virtual YmmusteriEnvanter? MusteriEnvanter { get; set; }

    public virtual UyurunStogu? UyurunStogu { get; set; }
}
