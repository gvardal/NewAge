using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymusteriMalzemeTeslimFisiDetayi
{
    public int MusteriMalzemeTeslimFisiDetayiId { get; set; }

    public int? MusteriMalzemeTeslimFisiId { get; set; }

    public int? UrunId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public decimal? Miktar { get; set; }

    public short? FireMiktari { get; set; }

    public string? Aciklama { get; set; }

    public byte? DurumId { get; set; }

    public virtual PUytaseronMalzemeTeslimDurumu? Durum { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual UyisEmriRotasi? IsEmriRota { get; set; }

    public virtual UymusteriMalzemeTeslimFisi? MusteriMalzemeTeslimFisi { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
