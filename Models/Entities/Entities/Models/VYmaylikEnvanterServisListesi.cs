using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VYmaylikEnvanterServisListesi
{
    public int Id { get; set; }

    public string? SubeAdi { get; set; }

    public string? AdiSoyadi { get; set; }

    public string? FirmaAdi { get; set; }

    public string? HesapTuru { get; set; }

    public string? MusteriDurumu { get; set; }

    public string? Telefon1 { get; set; }

    public string? EPosta { get; set; }

    public string? Fadres { get; set; }

    public int? TupSayisi { get; set; }

    public DateTime? GelecekKontrolTarihi { get; set; }

    public int? KontrolSuresi { get; set; }
}
