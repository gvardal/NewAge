using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisAkisSoruGruplari
{
    public short SoruGrubuId { get; set; }

    public string? SoruGrubuKodu { get; set; }

    public string? Aciklama { get; set; }

    public string? SoruGrubuTuru { get; set; }

    /// <summary>
    /// 1-İş Başlangıcı
    /// 2-Vardiya Başı
    /// 3-Rassal
    /// 4-Vardiya Sonu
    /// 5-İş Sonu
    /// 6-Bağımsız
    /// </summary>
    public string? OlcumTuruId { get; set; }

    public byte? IlgiliStandart { get; set; }

    public short? IlgiliSurecId { get; set; }

    public int? IlgiliKonumId { get; set; }

    public byte[]? ResimDosyaAdi { get; set; }

    public string? PdfdosyaYolu { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual Uykonum? IlgiliKonum { get; set; }

    public virtual PKystandart? IlgiliStandartNavigation { get; set; }

    public virtual Kysurecler? IlgiliSurec { get; set; }

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorularis { get; set; } = new List<UyisAkisSorulari>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviIsAkisSoruGrubuIdaraNavigations { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviIsAkisSoruGrubuIdsonNavigations { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviIsAkisSoruGrubus { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiIsAkisSoruGrubuIdaraNavigations { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiIsAkisSoruGrubuIdsonNavigations { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiIsAkisSoruGrubus { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<Uykonum> Uykonums { get; set; } = new List<Uykonum>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiIsAkisSoruGrubuIdaraNavigations { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiIsAkisSoruGrubus { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<Uyurunler> UyurunlerCikisKaliteKontrolSoruGrubus { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerGirdiKaliteKontrolSoruGrubus { get; set; } = new List<Uyurunler>();
}
