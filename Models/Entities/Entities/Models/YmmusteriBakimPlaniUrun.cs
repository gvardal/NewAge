using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriBakimPlaniUrun
{
    public long BakimPlaniDetayiId { get; set; }

    public int? BakimPlaniId { get; set; }

    public short? SiraNo { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public long? TeslimatPlaniId { get; set; }

    public int? UrunId { get; set; }

    public decimal? Miktar { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public int? KontrolEdenId { get; set; }

    public decimal? KontrolEdilenMiktar { get; set; }

    public decimal? RedEdilenMiktar { get; set; }

    public bool? UrunKodu { get; set; }

    public bool? KasaKodu { get; set; }

    public bool? MusteriKodu { get; set; }

    public byte? ServisTuru { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonuc { get; set; }

    public long? PaketlemeId { get; set; }

    public string? PaketKapId { get; set; }

    public string? PaketKapNo { get; set; }

    public byte? PaketKapAdet { get; set; }

    public string? PaketKapMarka { get; set; }

    public decimal? PaketAgirligi { get; set; }

    public string? GumrukTakipNo { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual YmmusteriBakimPlani? BakimPlani { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual FyfaturaDetayi? FaturaDetayi { get; set; }

    public virtual Ikcalisanlar? KontrolEden { get; set; }

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual PLypaketKapCinsleri? PaketKap { get; set; }

    public virtual YmmusteriBakimPlaniPaketleme? Paketleme { get; set; }

    public virtual PYmservisTuru? ServisTuruNavigation { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual SyteslimatPlani? TeslimatPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniDegisenParcalar> YmmusteriBakimPlaniDegisenParcalars { get; set; } = new List<YmmusteriBakimPlaniDegisenParcalar>();

    public virtual ICollection<YmmusteriBakimPlaniLotNo> YmmusteriBakimPlaniLotNos { get; set; } = new List<YmmusteriBakimPlaniLotNo>();

    public virtual ICollection<YmmusteriBakimPlaniPaketleme> YmmusteriBakimPlaniPaketlemes { get; set; } = new List<YmmusteriBakimPlaniPaketleme>();
}
