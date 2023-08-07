using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyfaturaHareketOzelKodlari
{
    public int HareketOzelKoduId { get; set; }

    public int? UrunHizmetId { get; set; }

    public string? HareketOzelKodu { get; set; }

    public string? Aciklama { get; set; }

    public int? FislemTuruId { get; set; }

    public string? HareketOzelKoduTuru { get; set; }

    public decimal? MatrahKaysayisi { get; set; }

    public int? KkegmuhasebeHesapId { get; set; }

    public int? KkegkdvmuhasebeHesapId { get; set; }

    public virtual PFislemTuru? FislemTuru { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual FyhesapPlani? KkegkdvmuhasebeHesap { get; set; }

    public virtual FyhesapPlani? KkegmuhasebeHesap { get; set; }

    public virtual Uyurunler? UrunHizmet { get; set; }
}
