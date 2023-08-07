using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UytasarimBilgileri
{
    public int TasarimBilgisiId { get; set; }

    public int? UrunId { get; set; }

    public string? TasarimKodu { get; set; }

    public short? RevizyonNo { get; set; }

    public byte? TasarimTuru { get; set; }

    public string? CizimDosyasi { get; set; }

    public string? ResimDosyasi { get; set; }
}
