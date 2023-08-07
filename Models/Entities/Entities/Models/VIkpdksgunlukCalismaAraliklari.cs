using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VIkpdksgunlukCalismaAraliklari
{
    public DateTime Tarih { get; set; }

    public DateTime? BaslamaSaati { get; set; }

    public DateTime? CikisZamani { get; set; }

    public string? MesaiTuruId { get; set; }

    public int? VardiyaSayisi { get; set; }
}
