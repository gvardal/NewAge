using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Afisler
{
    public int AfisId { get; set; }

    public byte? AfisKonumId { get; set; }

    public bool? YeniPencere { get; set; }

    public string? Baglanti { get; set; }

    public string? DosyaUzantisi { get; set; }

    public string? Afis { get; set; }

    public short? Sira { get; set; }

    public bool? Aktif { get; set; }

    public virtual AfisKonumu? AfisKonum { get; set; }
}
