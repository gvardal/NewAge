using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VMusteriEnvanterListesi
{
    public long MusteriEnvanterId { get; set; }

    public string? BarkodNo { get; set; }

    public string? UrunKoduAdi { get; set; }

    public string? FirmaAdi { get; set; }

    public string? SubeAdi { get; set; }

    public string? SehirAdi { get; set; }

    public string? Ad { get; set; }

    public string? Telefon1 { get; set; }

    public string? CihazinYeri { get; set; }

    public DateTime? GarantiBaslangicTarihi { get; set; }

    public DateTime? GarantiBitisTarihi { get; set; }

    public DateTime? SonKontrolTarihi { get; set; }

    public DateTime? GelecekKontrolTarihi { get; set; }

    public byte? SonYapilanIslem { get; set; }

    public int SubeId { get; set; }

    public int? UrunId { get; set; }

    public int? FirmaId { get; set; }

    public string? HesapKodu { get; set; }

    public string? Fsemt { get; set; }

    public string? VergiNo { get; set; }

    public string? Adi { get; set; }

    public DateTime? SonServisTarihi { get; set; }

    public string? RotaAdi { get; set; }
}
