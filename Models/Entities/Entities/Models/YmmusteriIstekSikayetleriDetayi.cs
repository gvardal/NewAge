using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriIstekSikayetleriDetayi
{
    public int MusteriIstekSikayetDetayiId { get; set; }

    public int? MusteriIstekSikayetId { get; set; }

    public DateTime? Tarih { get; set; }

    public int? IlgiliId { get; set; }

    public string? Aciklama { get; set; }

    public string? DosyaEkiAdi { get; set; }

    public virtual Ikcalisanlar? Ilgili { get; set; }

    public virtual YmmusteriIstekSikayetleri? MusteriIstekSikayet { get; set; }
}
