using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSatedarikciSatinAlmaSozlesmeler
{
    public DateTime? SozlesmeTarihi { get; set; }

    public DateTime? GecerlilikBaslangicTarihi { get; set; }

    public DateTime? GecerlilikBitisTarihi { get; set; }

    public int CariHesapId { get; set; }

    public string? HesapKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public short SozlesmeId { get; set; }

    public byte? SozlesmeTuruId { get; set; }

    public string? SozlesmeTuru { get; set; }

    public bool? AlisSatis { get; set; }

    public decimal? SozlesmeBedeli { get; set; }

    public string? Iso4127kodu { get; set; }
}
