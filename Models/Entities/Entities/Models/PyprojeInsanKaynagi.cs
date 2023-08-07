using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeInsanKaynagi
{
    public int Id { get; set; }

    public int? ProjeKodu { get; set; }

    public int? CalisanKodu { get; set; }

    public short? ProjeGorevi { get; set; }

    public string? Renk { get; set; }

    public string? GorevAldigiSaat { get; set; }

    public short? ProjeTakimi { get; set; }

    public int? ProjeAdimiId { get; set; }

    public string? ProjeGorevAciklamasi { get; set; }

    public decimal? AdamAyOrani { get; set; }

    public short? Ay { get; set; }

    public decimal? ToplamAdamAy { get; set; }

    public decimal? AylikMaliyet { get; set; }

    public decimal? Toplam { get; set; }

    public virtual Ikcalisanlar? CalisanKoduNavigation { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual PPyprojeGorevleri? ProjeGoreviNavigation { get; set; }

    public virtual Pyprojeler? ProjeKoduNavigation { get; set; }

    public virtual PPyprojeTakimlari? ProjeTakimiNavigation { get; set; }
}
