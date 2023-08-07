using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriBakimPlaniPaketleme
{
    public long PaketlemeId { get; set; }

    public long? BakimPlaniDetayiId { get; set; }

    public int? SiparisId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? TeslimatPlaniId { get; set; }

    public int? UrunId { get; set; }

    public string? PaketlemeKodu { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public bool? UygunlukDurumu { get; set; }

    public string? KutuNo { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? PaketlemeTarihi { get; set; }

    public int? KontrolEdenId { get; set; }

    public string? PaketKapId { get; set; }

    public string? PaketKapNo { get; set; }

    public byte? PaketKapAdet { get; set; }

    public string? PaketKapMarka { get; set; }

    public decimal? PaketAgirligi { get; set; }

    public decimal? PaketKapGenislik { get; set; }

    public decimal? PaketKapYukseklik { get; set; }

    public decimal? PaketKapUzunluk { get; set; }

    public bool? PaketOnay { get; set; }

    public int? PaketOnaylayan { get; set; }

    public string? Aciklama { get; set; }

    public string? Aciklama2 { get; set; }

    public string? EklentiDosyaAdi1 { get; set; }

    public string? EklentiDosyaAdi2 { get; set; }

    public string? EklentiDosyaAdi3 { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual YmmusteriBakimPlaniUrun? BakimPlaniDetayi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? KontrolEden { get; set; }

    public virtual Ikcalisanlar? PaketOnaylayanNavigation { get; set; }

    public virtual Sysiparisler? Siparis { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual SyteslimatPlani? TeslimatPlani { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();
}
