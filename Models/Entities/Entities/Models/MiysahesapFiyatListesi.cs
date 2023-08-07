using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiysahesapFiyatListesi
{
    public int MiysahesapFiyatListesiId { get; set; }

    public int UrunId { get; set; }

    public int HesapId { get; set; }

    public decimal MinMiktar { get; set; }

    public decimal MaksMiktar { get; set; }

    public DateTime GecerlilikBaslangicTarihi { get; set; }

    public DateTime? GecerlilikBitisTarihi { get; set; }

    public short? SozlesmeId { get; set; }

    public string? UrunKodu { get; set; }

    public string? UrunAdi { get; set; }

    public byte? OncelikSirasi { get; set; }

    public decimal? SiparisOrani { get; set; }

    public byte? UrunDegerlendirmesi { get; set; }

    public bool? OncelikOtomatik { get; set; }

    public decimal Fiyat { get; set; }

    public byte ParaBirimiId { get; set; }

    public byte? VergiGrubuId { get; set; }

    public decimal? SiparisKatsayisi { get; set; }

    public string? MusteriBarkodRaporAdi { get; set; }

    public string? Uyari { get; set; }

    public bool? AlisSatis { get; set; }

    public byte? TedarikSuresi { get; set; }

    public byte? BirlestirilecekGunSayisi { get; set; }

    /// <summary>
    /// Sipariş Verilirken Otomatik Sipariş Birleştirilecek gün sayısı
    /// </summary>
    public string? MevcutMuayenePlani { get; set; }

    public byte? MevcutPeriyod { get; set; }

    public byte? MevcutKabul { get; set; }

    public byte? MevcutRed { get; set; }

    public byte? MevcutSartliKabul { get; set; }

    public byte? YogundanNormaleKabul { get; set; }

    public byte? NormaldenYogunaRed { get; set; }

    public byte? NormaldenYogunaSartliKabul { get; set; }

    public byte? NormaldenGevsekeKabul { get; set; }

    public byte? GevsektenNormaleRed { get; set; }

    public byte? GevsektenNormaleSartliKabul { get; set; }

    public byte? GevsektenPeriyodigeKabul { get; set; }

    public byte? PeriyodFrekansi { get; set; }

    public byte? PeriyodiktenNormaleRed { get; set; }

    public byte? PeriyodiktenNormaleSartliKabul { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miysahesaplar Hesap { get; set; } = null!;

    public virtual PparaBirimi ParaBirimi { get; set; } = null!;

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Sysasozlesmeler? Sozlesme { get; set; }

    public virtual Uyurunler Urun { get; set; } = null!;

    public virtual PFyvergiGrubu? VergiGrubu { get; set; }
}
