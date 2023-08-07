using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SateklifSiparisTeslimatHareketi
{
    public long HareketReferansiId { get; set; }

    public long? TeklifSiparisDetayiId { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? GerceklesenUretimMiktari { get; set; }

    public decimal? UygunsuzMiktar { get; set; }

    public int? KonumId { get; set; }

    public string? Aciklama { get; set; }

    public long? IrsaliyeNo { get; set; }

    public long? IrsaliyeDetayiId { get; set; }

    public string? KontrolSonucu { get; set; }

    public byte? KullanimTuruId { get; set; }

    public long? UygunsuzUrunHizmetId { get; set; }

    public int? TeslimEdenTedarikciId { get; set; }

    public int? TeslimAlanCalisanId { get; set; }

    public bool? OnKabul { get; set; }

    public DateTime? GirdiKaliteKontrolTarihi { get; set; }

    public int? GirdiKaliteKontrolCalisanId { get; set; }

    /// <summary>
    /// Teslim alma sonrasında irsaliye/irsaliyeli fatura oluşturmak için SATeslimalınacakSiparisDetayi için irsaliyelendirielcek teslimat detaylarının seçili olup alt tabloya aktarılmasını temsil eder.
    /// </summary>
    public bool? Secildi { get; set; }

    public bool? Irsaliyelendirildi { get; set; }

    public bool? Faturalandirildi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<FyefaturaDetay> FyefaturaDetays { get; set; } = new List<FyefaturaDetay>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual Ikcalisanlar? GirdiKaliteKontrolCalisan { get; set; }

    public virtual FyfaturaDetayi? IrsaliyeDetayi { get; set; }

    public virtual Fyfatura? IrsaliyeNoNavigation { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<SagirdiKontrolSonucu> SagirdiKontrolSonucus { get; set; } = new List<SagirdiKontrolSonucu>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual SateklifSiparisDetayi? TeklifSiparisDetayi { get; set; }

    public virtual Ikcalisanlar? TeslimAlanCalisan { get; set; }

    public virtual Ikcalisanlar? TeslimEdenTedarikci { get; set; }

    public virtual KyuygunsuzUrunHizmet? UygunsuzUrunHizmet { get; set; }

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
