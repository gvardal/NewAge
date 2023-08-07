using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UysgrafikTasarim
{
    public int GrafikTasarimId { get; set; }

    public int? AmbalajMalzemeId { get; set; }

    public DateTime? GecerlilikTarihi { get; set; }

    public string? RevizyonBilgisi { get; set; }

    public int? AjansId { get; set; }

    public string? RevizyonNedeni { get; set; }

    public byte? DurumId { get; set; }

    public byte? SilindirKliseSayisi { get; set; }

    public string? RenkliCiktiDosyasi { get; set; }

    public string? RenkliCiktiNot { get; set; }

    public byte? BaskiSilindirKliseSayisi { get; set; }

    public string? BaskiDosyasi { get; set; }

    public string? BaskiNot { get; set; }

    public virtual Miysahesaplar? Ajans { get; set; }

    public virtual UysambalajMalzemeleri? AmbalajMalzeme { get; set; }
}
