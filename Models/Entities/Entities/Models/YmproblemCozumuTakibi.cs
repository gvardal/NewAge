using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmproblemCozumuTakibi
{
    public int Id { get; set; }

    public string? ProblemKodu { get; set; }

    public short? ProblemTuru { get; set; }

    public string? ProblemAciklamasi { get; set; }

    public string? IlgiliProses { get; set; }

    public string? ProblemCozumu { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public string? AramaKelimeleri { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual YmproblemTuru? ProblemTuruNavigation { get; set; }

    public virtual ICollection<YmproblemCozumuTakibiYorumlar> YmproblemCozumuTakibiYorumlars { get; set; } = new List<YmproblemCozumuTakibiYorumlar>();
}
