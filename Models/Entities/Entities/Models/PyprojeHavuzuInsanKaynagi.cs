using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeHavuzuInsanKaynagi
{
    public int Id { get; set; }

    public int? ProjeKodu { get; set; }

    public int? CalisanKodu { get; set; }

    public short? ProjeGorevi { get; set; }

    public string? GorevAldıgıSaat { get; set; }

    public short? ProjeTakimi { get; set; }

    public virtual Ikcalisanlar? CalisanKoduNavigation { get; set; }

    public virtual PPyprojeGorevleri? ProjeGoreviNavigation { get; set; }

    public virtual PyprojeHavuzu? ProjeKoduNavigation { get; set; }

    public virtual PPyprojeTakimlari? ProjeTakimiNavigation { get; set; }
}
