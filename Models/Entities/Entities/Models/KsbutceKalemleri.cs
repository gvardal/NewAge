using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsbutceKalemleri
{
    public int ButceKalemiId { get; set; }

    public int? OncekiButceKalemiId { get; set; }

    public short? ButcePlaniId { get; set; }

    public int? ProjeId { get; set; }

    public string? ButceKodu { get; set; }

    public string? ButceKalemAdi { get; set; }

    public string? ButceKalemTuru { get; set; }

    public int? ButceSahibiId { get; set; }

    public int? ButceSorumlusuId { get; set; }

    public byte? KdvOraniId { get; set; }

    public decimal? AmortismanOrani { get; set; }

    public string? AmortismanTipi { get; set; }

    public string? AmortismanDagitimTuru { get; set; }

    public decimal? Tutari1Ay { get; set; }

    public decimal? Tutari2Ay { get; set; }

    public decimal? Tutari3Ay { get; set; }

    public decimal? Tutari4Ay { get; set; }

    public decimal? Tutari5Ay { get; set; }

    public decimal? Tutari6Ay { get; set; }

    public decimal? Tutari7Ay { get; set; }

    public decimal? Tutari8Ay { get; set; }

    public decimal? Tutari9Ay { get; set; }

    public decimal? Tutari10Ay { get; set; }

    public decimal? Tutari11Ay { get; set; }

    public decimal? Tutari12Ay { get; set; }

    public decimal? AmortismanTutari1Ay { get; set; }

    public decimal? AmortismanTutari2Ay { get; set; }

    public decimal? AmortismanTutari3Ay { get; set; }

    public decimal? AmortismanTutari4Ay { get; set; }

    public decimal? AmortismanTutari5Ay { get; set; }

    public decimal? AmortismanTutari6Ay { get; set; }

    public decimal? AmortismanTutari7Ay { get; set; }

    public decimal? AmortismanTutari8Ay { get; set; }

    public decimal? AmortismanTutari9Ay { get; set; }

    public decimal? AmortismanTutari10Ay { get; set; }

    public decimal? AmortismanTutari11Ay { get; set; }

    public decimal? AmortismanTutari12Ay { get; set; }

    public decimal? Kdvbutcesi1Ay { get; set; }

    public decimal? Kdvbutcesi2Ay { get; set; }

    public decimal? Kdvbutcesi3Ay { get; set; }

    public decimal? Kdvbutcesi4Ay { get; set; }

    public decimal? Kdvbutcesi5Ay { get; set; }

    public decimal? Kdvbutcesi6Ay { get; set; }

    public decimal? Kdvbutcesi7Ay { get; set; }

    public decimal? Kdvbutcesi8Ay { get; set; }

    public decimal? Kdvbutcesi9Ay { get; set; }

    public decimal? Kdvbutcesi10Ay { get; set; }

    public decimal? Kdvbutcesi11Ay { get; set; }

    public decimal? Kdvbutcesi12Ay { get; set; }

    public virtual KsbutcePlani? ButcePlani { get; set; }

    public virtual ICollection<KsbutceKalemleri> InverseOncekiButceKalemi { get; set; } = new List<KsbutceKalemleri>();

    public virtual PMiysavergiTuru? KdvOrani { get; set; }

    public virtual KsbutceKalemleri? OncekiButceKalemi { get; set; }

    public virtual Pyprojeler? Proje { get; set; }
}
