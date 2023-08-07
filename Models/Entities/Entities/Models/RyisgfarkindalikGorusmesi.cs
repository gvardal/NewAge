using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RyisgfarkindalikGorusmesi
{
    public int IsggorusmeId { get; set; }

    public DateTime? GorusmeTarihi { get; set; }

    public int? GorusenId { get; set; }

    public int? GorusulenId { get; set; }

    /// <summary>
    /// 1-10 arasi puanlandirma
    /// </summary>
    public byte? Puan { get; set; }

    public string? GorusulenKonular { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? Gorusen { get; set; }

    public virtual Ikcalisanlar? Gorusulen { get; set; }
}
