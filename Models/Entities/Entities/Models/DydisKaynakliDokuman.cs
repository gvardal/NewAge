using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DydisKaynakliDokuman
{
    public decimal Id { get; set; }

    public string? DokumanNo { get; set; }

    public string? DokumanAdi { get; set; }

    public string? RevNo { get; set; }

    public DateTime? YayinTarihi { get; set; }

    public string? TeminYeri { get; set; }

    public string? GuncelligiKontrolYontemi { get; set; }

    public short? IlgiliBirim { get; set; }

    public string? Durumu { get; set; }

    public string? DosyaAdi { get; set; }

    public byte[]? DosyaBinary { get; set; }

    public int? BelirleyenKullaniciId { get; set; }

    public virtual Ikcalisanlar? BelirleyenKullanici { get; set; }

    public virtual Ikorganizasyonlar? IlgiliBirimNavigation { get; set; }
}
