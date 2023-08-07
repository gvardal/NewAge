using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriBakimPlaniDegisenParcalar
{
    public long DegisenParcalarId { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public long? BakimPlaniMusteriEnvanterId { get; set; }

    public long? BakimPlaniLotNoId { get; set; }

    public int? UrunId { get; set; }

    public string? SeriNo { get; set; }

    public byte? Adet { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? ToplamFiyat { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? BirimMaliyeti { get; set; }

    public string? Aciklama { get; set; }

    public virtual YmmusteriBakimPlaniLotNo? BakimPlaniLotNo { get; set; }

    public virtual YmmusteriBakimPlaniUrun? BakimPlaniMusteriEnvanter { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual SasatinAlmaTalebi? SatinAlmaTalebi { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
