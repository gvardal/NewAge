using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UykonumBolmeleri
{
    public int KonumBolmeId { get; set; }

    public int? KonumId { get; set; }

    public string? BolmeAdi { get; set; }

    public string? BolmeKodu { get; set; }

    public string? LokasyonX { get; set; }

    public string? LokasyonY { get; set; }

    public string? LokasyonZ { get; set; }

    public bool? TekLotUrunKullanilsin { get; set; }

    public string? MinimumMiktar { get; set; }

    public string? MaksimumMiktar { get; set; }

    public string? Rfid { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual ICollection<Uykonum> Uykonums { get; set; } = new List<Uykonum>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UymalzemeIstekFisiLotNo> UymalzemeIstekFisiLotNos { get; set; } = new List<UymalzemeIstekFisiLotNo>();

    public virtual ICollection<UystokHareketiLotNo> UystokHareketiLotNos { get; set; } = new List<UystokHareketiLotNo>();

    public virtual ICollection<UyurunStokDetayi> UyurunStokDetayis { get; set; } = new List<UyurunStokDetayi>();

    public virtual ICollection<YmmusteriBakimPlaniLotNo> YmmusteriBakimPlaniLotNos { get; set; } = new List<YmmusteriBakimPlaniLotNo>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
