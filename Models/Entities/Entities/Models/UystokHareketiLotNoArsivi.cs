using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UystokHareketiLotNoArsivi
{
    public long StokHareketiLotNoId { get; set; }

    public long? GirisStokHareketiLotNoId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public long? StokHareketiId { get; set; }

    public int? KonumBolmeId { get; set; }

    public decimal? Miktar { get; set; }

    public long? LotNo { get; set; }

    public string? Aciklama { get; set; }

    public decimal? BirimMaliyet { get; set; }

    public decimal? Toplam { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public bool? Arsiv { get; set; }
}
