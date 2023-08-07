using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSasatinAlmaSurecTakibi
{
    public int SiparisId { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TeklifTarihi { get; set; }

    public string? KontrolSonucu { get; set; }

    public decimal? UygunsuzMiktar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public byte? FirmaId { get; set; }

    public bool? TedarikciKabul { get; set; }

    public DateTime? TedarikciKabulTarihi { get; set; }

    public int? TedarikciKabulEden { get; set; }

    public int? TeklifAlanId { get; set; }

    public int? SiparisAlanId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int Id { get; set; }

    public string? FirmaAdi { get; set; }

    public string? HesapKodu { get; set; }

    public string? TalepDurumu { get; set; }

    public decimal? SiparisEdilenMiktar { get; set; }

    public decimal? SiparisGerceklesenMiktar { get; set; }

    public decimal? SiparisKalanMiktar { get; set; }
}
