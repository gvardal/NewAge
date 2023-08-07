using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymalzemeIstekFisiDetayi
{
    public long MalzemeIstekFisiDetayiId { get; set; }

    public long? MalzemeIstekFisiId { get; set; }

    public int IlkMaddeVeMalzemeNo { get; set; }

    public int? KonumId { get; set; }

    public int? KonumBolmeId { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public int? Birim { get; set; }

    public decimal? PlanlananBirimFiyat { get; set; }

    public decimal? PlanlananTutar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? GerceklesenBirimFiyat { get; set; }

    public decimal? GerceklesenTutar { get; set; }

    public DateTime? GerceklesmeTarihi { get; set; }

    public decimal? FireMiktari { get; set; }

    public decimal? Bakiye { get; set; }

    public string? Aciklama { get; set; }

    public bool? Gerceklesti { get; set; }

    public bool? OtomatikTuketim { get; set; }

    public string? SmartBoxFonksiyonu { get; set; }

    public int? MuhasebeHesapPlaniId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public int? SonErisenId { get; set; }

    public virtual PolcuBirimleri? BirimNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uyurunler IlkMaddeVeMalzemeNoNavigation { get; set; } = null!;

    public virtual Uykonum? Konum { get; set; }

    public virtual UykonumBolmeleri? KonumBolme { get; set; }

    public virtual UymalzemeIstekFisi? MalzemeIstekFisi { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual FyhesapPlani? MuhasebeHesapPlani { get; set; }

    public virtual Ikcalisanlar? SonErisen { get; set; }

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisiLotNo> UymalzemeIstekFisiLotNos { get; set; } = new List<UymalzemeIstekFisiLotNo>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();
}
