using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymalzemeIstekFisiLotNo
{
    public long Id { get; set; }

    public long? MalzemeIstekFisiDetayiId { get; set; }

    public DateTime? Tarih { get; set; }

    public int? TalepEdenCalisanId { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public decimal? Miktar { get; set; }

    public long? LotNo { get; set; }

    public string? Aciklama { get; set; }

    public int? KonumBolmeId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public virtual UykonumBolmeleri? KonumBolme { get; set; }

    public virtual YmmusteriEnvanter? LotNoNavigation { get; set; }

    public virtual UymalzemeIstekFisiDetayi? MalzemeIstekFisiDetayi { get; set; }

    public virtual Ikcalisanlar? TalepEdenCalisan { get; set; }

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();
}
