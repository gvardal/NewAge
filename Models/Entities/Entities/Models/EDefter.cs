using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class EDefter
{
    public long YevmiyeDefteriDetayiId { get; set; }

    public long YevmiyeDefteriId { get; set; }

    public DateTime? MaliDonemBaslangic { get; set; }

    public DateTime? MaliDonemBitis { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public DateTime? EklemeTarihi { get; set; }

    public string? KayitNo { get; set; }

    public string? IslemAciklamasi { get; set; }

    public string? SubeKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public string? FisTuru { get; set; }

    public string? EDefterKayitTuru { get; set; }

    public string? EDefterKayitTuruAciklama { get; set; }

    public decimal? IslemTutari { get; set; }

    public string? IslemReferansi { get; set; }

    public decimal BorcTutari { get; set; }

    public decimal AlacakTutari { get; set; }

    public string? HesapKodu { get; set; }

    public string? HesapAdi { get; set; }

    public string? AnaHesapAciklama { get; set; }

    public string? AnaHesapKodu { get; set; }

    public string? YevmiyeDetayiAciklama { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public string? VergiNo { get; set; }

    public string? Aciklama { get; set; }

    public string? DebitCreditCode { get; set; }
}
