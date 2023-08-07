using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Fybutce
{
    public int ButceId { get; set; }

    public short? ButcePlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public int? HesapPlaniId { get; set; }

    public string? ButceAciklamasi { get; set; }

    public string? MaliYil { get; set; }

    public decimal? PlanlananTutar { get; set; }

    public decimal? GerceklesenTutar { get; set; }

    public int? SorumluId { get; set; }

    public DateTime? TalepTarihi { get; set; }

    public bool? Aktif { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarih { get; set; }

    public decimal? Planlanan1Ay { get; set; }

    public decimal? Gerceklesen1Ay { get; set; }

    public decimal? Planlanan2Ay { get; set; }

    public decimal? Gerceklesen2Ay { get; set; }

    public decimal? Planlanan3Ay { get; set; }

    public decimal? Gerceklesen3Ay { get; set; }

    public decimal? Planlanan4Ay { get; set; }

    public decimal? Gerceklesen4Ay { get; set; }

    public decimal? Planlanan5Ay { get; set; }

    public decimal? Gerceklesen5Ay { get; set; }

    public decimal? Planlanan6Ay { get; set; }

    public decimal? Gerceklesen6Ay { get; set; }

    public decimal? Planlanan7Ay { get; set; }

    public decimal? Gerceklesen7Ay { get; set; }

    public decimal? Planlanan8Ay { get; set; }

    public decimal? Gerceklesen8Ay { get; set; }

    public decimal? Planlanan9Ay { get; set; }

    public decimal? Gerceklesen9Ay { get; set; }

    public decimal? Planlanan10Ay { get; set; }

    public decimal? Gerceklesen10Ay { get; set; }

    public decimal? Planlanan11Ay { get; set; }

    public decimal? Gerceklesen11Ay { get; set; }

    public decimal? Planlanan12Ay { get; set; }

    public decimal? Gerceklesen12Ay { get; set; }

    public virtual KsbutcePlani? ButcePlani { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual FyhesapPlani? HesapPlani { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? Sorumlu { get; set; }
}
