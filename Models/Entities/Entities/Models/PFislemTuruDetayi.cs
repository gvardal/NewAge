using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFislemTuruDetayi
{
    public int IslemTuruDetayiId { get; set; }

    public int? IslemTuruId { get; set; }

    public string? AnaHesapKodu { get; set; }

    public bool? AylaraGore { get; set; }

    public decimal? Yuzde { get; set; }

    public int? MuhasebeHesapPlaniId { get; set; }

    public string? Borc { get; set; }

    public string? Alacak { get; set; }

    public string? Aciklama { get; set; }

    public string? Etiket { get; set; }

    public virtual PFislemTuru? IslemTuru { get; set; }

    public virtual FyhesapPlani? MuhasebeHesapPlani { get; set; }
}
