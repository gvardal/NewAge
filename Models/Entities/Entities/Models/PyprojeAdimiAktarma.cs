using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeAdimiAktarma
{
    public int ProjeAdimiId { get; set; }

    public int? KilometreTasiId { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? PlanlananBaslangic { get; set; }

    public DateTime? PlanlananBitis { get; set; }

    public short? KrediPuani { get; set; }

    public string? Sorumlu { get; set; }

    public string? ProjeTakimi { get; set; }

    public string? ProjeUnvani { get; set; }
}
