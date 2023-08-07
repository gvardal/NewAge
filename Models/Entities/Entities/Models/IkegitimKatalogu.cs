using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkegitimKatalogu
{
    public int EgitimId { get; set; }

    public short? EgitimKategorisiId { get; set; }

    public byte[]? EgitimResim { get; set; }

    public string? EgitimKodu { get; set; }

    public string? EgitimAdi { get; set; }

    /// <summary>
    /// 1-İç Eğitim
    /// 2-Dış Eğitim
    /// 3-e-Öğrenme
    /// 4-Müşteri Eğitimi
    /// 5-Müşteri e-Öğrenme
    /// </summary>
    public byte? EgitimTuruId { get; set; }

    public DateTime? GecerlilikBaslangicTarihi { get; set; }

    public DateTime? GecerlilikBitisTarihi { get; set; }

    public string? EgitimAmaci { get; set; }

    public string? EgitimOzeti { get; set; }

    public string? HedefKitle { get; set; }

    public string? Gereksinimler { get; set; }

    public string? Kazanimlar { get; set; }

    public short? KazanilanYetenek { get; set; }

    public byte? GecmeNotu { get; set; }

    public bool? VideoTuru { get; set; }

    public string? VideoGomuluKod { get; set; }

    public string? VideoDosyaYolu { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public bool? Aktif { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual PIkegitimKategorileri? EgitimKategorisi { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<IkegitimEogrenmeTakip> IkegitimEogrenmeTakips { get; set; } = new List<IkegitimEogrenmeTakip>();

    public virtual ICollection<IkegitimIhtiyaclari> IkegitimIhtiyaclaris { get; set; } = new List<IkegitimIhtiyaclari>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesis { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimPlanlama> IkegitimPlanlamas { get; set; } = new List<IkegitimPlanlama>();

    public virtual PIkozelYetenekler? KazanilanYetenekNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorularis { get; set; } = new List<UyisAkisSorulari>();
}
