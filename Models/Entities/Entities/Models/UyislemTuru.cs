using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyislemTuru
{
    public short IslemTuruId { get; set; }

    public byte? FaaliyetTuruId { get; set; }

    public string Ad { get; set; } = null!;

    public string? Aciklama { get; set; }

    /// <summary>
    /// Kontrol ve Hazılık vb. İşlemleri
    /// </summary>
    public bool? ProsesIslemTuru { get; set; }

    public double? FireOrani { get; set; }

    public string? Kodu { get; set; }

    public string? KoduAdi { get; set; }

    public bool? OncekiIslemKontrolu { get; set; }

    public bool? TaseronIslemi { get; set; }

    public bool? KesimIslemi { get; set; }

    public int? VarsayilanFasonUrunId { get; set; }

    public bool? PaketlemeIslemi { get; set; }

    public short? OncelikSirasi { get; set; }

    public bool? Aktif { get; set; }

    public string? RaporAdi { get; set; }

    public decimal? VardiyaAdet { get; set; }

    public short? AdamSayisi { get; set; }

    public decimal? OperasyonAdedi { get; set; }

    public decimal? SetupSuresi { get; set; }

    public decimal? SetupAdedi { get; set; }

    public string? EkAlan { get; set; }

    public string? EkAlan1 { get; set; }

    public virtual PUyfaaliyetTuru? FaaliyetTuru { get; set; }

    public virtual ICollection<UycalisanIslemTuru> UycalisanIslemTurus { get; set; } = new List<UycalisanIslemTuru>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsivis { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasis { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyislemUyumu> UyislemUyumuBirincilIslemTurus { get; set; } = new List<UyislemUyumu>();

    public virtual ICollection<UyislemUyumu> UyislemUyumuIkincilIslemTurus { get; set; } = new List<UyislemUyumu>();

    public virtual ICollection<UykonumIslemTuru> UykonumIslemTurus { get; set; } = new List<UykonumIslemTuru>();

    public virtual ICollection<UymakinaIslemTuru> UymakinaIslemTurus { get; set; } = new List<UymakinaIslemTuru>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyurunRotasi> UyurunRotasis { get; set; } = new List<UyurunRotasi>();

    public virtual Uyurunler? VarsayilanFasonUrun { get; set; }

    public virtual ICollection<Fdemirba> Ekipmen { get; set; } = new List<Fdemirba>();

    public virtual ICollection<UyfireTuru> FireTurus { get; set; } = new List<UyfireTuru>();
}
