using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SysiparisAktarmaDetayli
{
    public long SiparisAktarmaDetayliId { get; set; }

    public string FirmaAdi { get; set; } = null!;

    public DateTime? SiparisTarihi { get; set; }

    public string? MusteriSatinAlmaNo { get; set; }

    public string? UrunKodu { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public decimal? Fiyat { get; set; }

    public string? Konu { get; set; }

    public string? Uyari { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public bool? Uygunluk { get; set; }

    public string? HesapAdi { get; set; }

    public string? VergiDairesi { get; set; }

    public string? VergiNo { get; set; }

    public string? Fadres { get; set; }

    public string? Fsehir { get; set; }

    public string? Filce { get; set; }

    public string? Telefon { get; set; }

    public string? SiparisDetayiAciklama { get; set; }

    public string? SiparisDetayiEkAlan1 { get; set; }

    public string? SiparisDetayiEkAlan2 { get; set; }

    public string? SiparisDetayiEkAlan3 { get; set; }
}
