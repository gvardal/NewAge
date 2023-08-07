using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiysavergiTuru
{
    public byte VergiTuruId { get; set; }

    public string? VergiTuru { get; set; }

    public decimal? Oran { get; set; }

    public bool? Tevkifat { get; set; }

    public decimal? AliciOrani { get; set; }

    public decimal? SaticiOrani { get; set; }

    public int? SatinAlmaHesapKoduId { get; set; }

    public int? SatinAlmaTevkifatHesapKoduId { get; set; }

    public int? SatinAlmaOdenecekHesapKoduId { get; set; }

    public int? SatinAlmaIadeHesapKoduId { get; set; }

    public int? SatisHesapKoduId { get; set; }

    public int? SatisHesapTevkifatKoduId { get; set; }

    public int? SatisOdenecekHesapKoduId { get; set; }

    public int? SatisIadeHesapKoduId { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<KsbutceKalemleri> KsbutceKalemleris { get; set; } = new List<KsbutceKalemleri>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual FyhesapPlani? SatinAlmaHesapKodu { get; set; }

    public virtual FyhesapPlani? SatinAlmaIadeHesapKodu { get; set; }

    public virtual FyhesapPlani? SatinAlmaOdenecekHesapKodu { get; set; }

    public virtual FyhesapPlani? SatinAlmaTevkifatHesapKodu { get; set; }

    public virtual FyhesapPlani? SatisHesapKodu { get; set; }

    public virtual FyhesapPlani? SatisHesapTevkifatKodu { get; set; }

    public virtual FyhesapPlani? SatisIadeHesapKodu { get; set; }

    public virtual FyhesapPlani? SatisOdenecekHesapKodu { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
