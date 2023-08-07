using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VgirisCikisPivot
{
    public DateTime Tarih { get; set; }

    public string? AdiSoyadi { get; set; }

    public string? Giris { get; set; }

    public string? Cikis { get; set; }

    public string? IzinTuruAdi { get; set; }

    public bool? CalisanTuru { get; set; }

    public long? BordroIzinId { get; set; }

    public string? GerekceTuru { get; set; }
}
