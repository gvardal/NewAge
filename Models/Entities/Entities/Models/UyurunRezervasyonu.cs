using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunRezervasyonu
{
    public long RezervasyonId { get; set; }

    public int? UrunId { get; set; }

    public int? KonumId { get; set; }

    public decimal? Miktar { get; set; }

    public long? SeriLotNoId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public long? MalzemeIstekFisiDetayiId { get; set; }

    public long? MalzemeIstekFisiLotNoId { get; set; }

    public int? SevkiyatPlaniId { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual UyisEmri? IsEmri { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual UymalzemeIstekFisiDetayi? MalzemeIstekFisiDetayi { get; set; }

    public virtual UymalzemeIstekFisiLotNo? MalzemeIstekFisiLotNo { get; set; }

    public virtual YmmusteriEnvanter? SeriLotNo { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual UyurunStogu? UyurunStogu { get; set; }
}
