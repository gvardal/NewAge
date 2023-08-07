using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KsbutcePlani
{
    public short ButcePlaniId { get; set; }

    public short? KurumsalStratejiId { get; set; }

    public string? ButceDonemi { get; set; }

    public string? MaliYil { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public decimal? TahminiKur1Ay { get; set; }

    public decimal? TahminiKur2Ay { get; set; }

    public decimal? TahminiKur3Ay { get; set; }

    public decimal? TahminiKur4Ay { get; set; }

    public decimal? TahminiKur5Ay { get; set; }

    public decimal? TahminiKur6Ay { get; set; }

    public decimal? TahminiKur7Ay { get; set; }

    public decimal? TahminiKur8Ay { get; set; }

    public decimal? TahminiKur9Ay { get; set; }

    public decimal? TahminiKur10Ay { get; set; }

    public decimal? TahminiKur11Ay { get; set; }

    public decimal? TahminiKur12Ay { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual ICollection<Fybutce> Fybutces { get; set; } = new List<Fybutce>();

    public virtual ICollection<KsbutceKalemleri> KsbutceKalemleris { get; set; } = new List<KsbutceKalemleri>();

    public virtual ICollection<KsinsanKaynagi> KsinsanKaynagis { get; set; } = new List<KsinsanKaynagi>();

    public virtual ICollection<KssatisSatinAlmaPlani> KssatisSatinAlmaPlanis { get; set; } = new List<KssatisSatinAlmaPlani>();

    public virtual ICollection<KsstokVarsayimlari> KsstokVarsayimlaris { get; set; } = new List<KsstokVarsayimlari>();

    public virtual KskurumsalStratejiler? KurumsalStrateji { get; set; }
}
