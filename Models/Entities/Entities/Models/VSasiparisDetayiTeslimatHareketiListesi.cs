using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSasiparisDetayiTeslimatHareketiListesi
{
    public long HareketReferansiId { get; set; }

    public long TeklifSiparisDetayiId { get; set; }

    public int SiparisId { get; set; }

    public byte? FirmaId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public int? MalzemeUrunAdi { get; set; }

    public int? TedarikciKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public bool? Secildi { get; set; }

    public bool? Irsaliyelendirildi { get; set; }

    public string? SiparisDetayiAciklama { get; set; }

    public int? ProjeId { get; set; }

    public string? TeslimatHareketiAciklama { get; set; }
}
