using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MizanKayitlari
{
    public int? AnaHesapKodu { get; set; }

    public decimal BorcTutari { get; set; }

    public decimal AlacakTutari { get; set; }

    public short? MaliYil { get; set; }

    public byte? MaliAy { get; set; }

    public string? HesapTuru { get; set; }

    public string? HesapKoduAdi { get; set; }

    public string? OncekiHesapKoduAdi { get; set; }

    public bool? Aktif { get; set; }
}
