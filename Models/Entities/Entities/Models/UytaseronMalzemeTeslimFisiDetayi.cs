using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UytaseronMalzemeTeslimFisiDetayi
{
    public int TaseronMalzemeTeslimFisiDetayiId { get; set; }

    public int? TaseronMalzemeTeslimFisiId { get; set; }

    public int? UrunId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public long? TeslimatPlaniId { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? TeslimAlinanMiktar { get; set; }

    public decimal? KalanMiktar { get; set; }

    public string? Aciklama { get; set; }

    public byte? DurumId { get; set; }

    public bool? SeciliTaseronFisiDetayi { get; set; }

    public virtual PUytaseronMalzemeTeslimDurumu? Durum { get; set; }

    public virtual UyisEmriRotasi? IsEmriRota { get; set; }

    public virtual UytaseronMalzemeTeslimFisi? TaseronMalzemeTeslimFisi { get; set; }

    public virtual SyteslimatPlani? TeslimatPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<UytaseronMalzemeTeslimHareketleri> UytaseronMalzemeTeslimHareketleris { get; set; } = new List<UytaseronMalzemeTeslimHareketleri>();
}
