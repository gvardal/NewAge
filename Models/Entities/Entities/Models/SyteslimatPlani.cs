using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SyteslimatPlani
{
    public long SevkiyatPlaniId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public short? RevizyonNo { get; set; }

    public short? SiraNo { get; set; }

    public int? UrunId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Miktar { get; set; }

    public int? OlcuBirimiId { get; set; }

    public decimal? BirimFiyati { get; set; }

    public byte? KdvOrani { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? TaserondakiMiktar { get; set; }

    public decimal? PaketlenmisMiktar { get; set; }

    public decimal? SevkEdilenMiktar { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public byte? TeslimSartiId { get; set; }

    public int? KonumId { get; set; }

    public byte? DurumId { get; set; }

    public bool? SeciliFason { get; set; }

    public bool? SeciliBarkod { get; set; }

    public bool? SeciliPaket { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual PSysiparisDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual PolcuBirimleri? OlcuBirimi { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UytaseronMalzemeTeslimFisiDetayi> UytaseronMalzemeTeslimFisiDetayis { get; set; } = new List<UytaseronMalzemeTeslimFisiDetayi>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemes { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();
}
