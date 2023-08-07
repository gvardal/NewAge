using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyeBeyanname
{
    public int BeyannameId { get; set; }

    public byte? DonemTipi { get; set; }

    public int? FinansalDonemId { get; set; }

    public string? DuzenleyenVkn { get; set; }

    public string? DuzenleyenTc { get; set; }

    public string? DuzenleyenUnvani { get; set; }

    public string? DuzenleyenAdi { get; set; }

    public string? DuzenleyenTicSicNo { get; set; }

    public string? DuzenleyenEposta { get; set; }

    public string? DuzenleyenTelefon { get; set; }

    public int? Matrah01Id { get; set; }

    public int? Matrah08Id { get; set; }

    public int? Matrah18Id { get; set; }

    public int? Kdv01id { get; set; }

    public int? Kdv08id { get; set; }

    public int? Kdv18id { get; set; }

    public virtual ICollection<FyeBeyannameDetayi> FyeBeyannameDetayis { get; set; } = new List<FyeBeyannameDetayi>();

    public virtual FyhesapPlani? Kdv01 { get; set; }

    public virtual FyhesapPlani? Kdv08 { get; set; }

    public virtual FyhesapPlani? Kdv18 { get; set; }

    public virtual FyhesapPlani? Matrah01 { get; set; }

    public virtual FyhesapPlani? Matrah08 { get; set; }

    public virtual FyhesapPlani? Matrah18 { get; set; }
}
