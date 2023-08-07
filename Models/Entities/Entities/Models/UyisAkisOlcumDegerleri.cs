using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisAkisOlcumDegerleri
{
    public long IsAkisOlcumDegerId { get; set; }

    public int? IsAkisVeriId { get; set; }

    public string? OrnekSeriNo { get; set; }

    public decimal? Deger { get; set; }

    public bool? Sonuc { get; set; }

    public int? Onay { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? EklentiDosyaAdi2 { get; set; }

    public string? EklentiDosyaAdi3 { get; set; }

    public string? Aciklama { get; set; }

    public virtual UyisAkisVerileri? IsAkisVeri { get; set; }
}
