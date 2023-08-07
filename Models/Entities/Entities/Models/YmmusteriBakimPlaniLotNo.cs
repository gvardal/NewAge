using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriBakimPlaniLotNo
{
    public long BakimPlaniLotNoId { get; set; }

    public long? BakimPlaniDetayiId { get; set; }

    public long? EnvanterId { get; set; }

    public string? BarkodNo { get; set; }

    public byte? YapilanIslem { get; set; }

    public string? UrunKontrolGovde { get; set; }

    public string? UrunKontrolPaket { get; set; }

    public string? UrunKontrolIcAksam { get; set; }

    public string? UrunKontrolEvrak { get; set; }

    public int? KonumBolmeId { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? KontrolEdilenMiktar { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public int? KontrolEdenId { get; set; }

    public byte? ServisTuru { get; set; }

    public bool? Garanti { get; set; }

    public bool? YillikBakimAnlasmasi { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonuc { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual YmmusteriBakimPlaniUrun? BakimPlaniDetayi { get; set; }

    public virtual YmmusteriEnvanter? Envanter { get; set; }

    public virtual UykonumBolmeleri? KonumBolme { get; set; }

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual PYmservisTuru? ServisTuruNavigation { get; set; }

    public virtual PYmyapilanIslem? YapilanIslemNavigation { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniDegisenParcalar> YmmusteriBakimPlaniDegisenParcalars { get; set; } = new List<YmmusteriBakimPlaniDegisenParcalar>();
}
