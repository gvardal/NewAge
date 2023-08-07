using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PsiparisTuru
{
    public byte Id { get; set; }

    public string? SiparisTuruKodu { get; set; }

    public string? SiparisTuru { get; set; }

    public string SiparisKoduTuru { get; set; } = null!;

    public bool? IthalatIhracat { get; set; }

    public bool? SubelerArasiSevkIrsaliyesi { get; set; }

    public bool? KonsinyeMal { get; set; }

    public bool? Numune { get; set; }

    public bool? Bedelsiz { get; set; }

    public bool? BirimFiyatTeklifi { get; set; }

    public bool? GenelTeklif { get; set; }

    /// <summary>
    /// Sipariş Onaylandığında Otomatik Olarak Rezervasyon Yapar.
    /// </summary>
    public bool? OtomatikRezervasyon { get; set; }

    public bool? B2b { get; set; }

    public bool? FinansOnayiGerekli { get; set; }

    public byte? ParaBirimiId { get; set; }

    public short? SevkiyatYontemiId { get; set; }

    /// <summary>
    /// 1-Ürün bazlı ÇKK 2-Lot No Bazlı ÇKK
    /// </summary>
    public byte? Ckkturu { get; set; }

    public int? MuhasebeHesapId { get; set; }

    public int? OnayYetkilisiId { get; set; }

    public string? TeklifRaporAdi { get; set; }

    public string? SiparisRaporAdi { get; set; }

    public string? ProformaFaturaAdi { get; set; }

    public short? TerminGunu { get; set; }

    public byte? TeklifGecerlilikGunu { get; set; }

    public byte? UretimPlaniTuruId { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public byte? MaliyetAnalizModeli { get; set; }

    public int? SablonProjeId { get; set; }

    public string? SiparisUretimPlaniRaporAdi { get; set; }

    public string? SiparisUretimPlaniRaporTuru { get; set; }

    public string? UretimPlaniRaporAdi { get; set; }

    public string? IsEmriRaporAdi { get; set; }

    public string? BarkodRaporAdi { get; set; }

    public string? SertifikaRaporAdi { get; set; }

    public string? PaketlemeRaporAdi { get; set; }

    public string? PaketlemeBarkodRaporAdi { get; set; }

    public string? CekiListesiBarkodRaporAdi { get; set; }

    public string? IrsaliyeRaporAdi { get; set; }

    public string? FaturaRaporAdi { get; set; }

    public string? TahsilatRaporAdi { get; set; }

    public string? RaporTuru { get; set; }

    public virtual PFymasrafMerkezi? MasrafMerkezi { get; set; }

    public virtual ICollection<Miyfirsatlar> Miyfirsatlars { get; set; } = new List<Miyfirsatlar>();

    public virtual FyhesapPlani? MuhasebeHesap { get; set; }

    public virtual Ikcalisanlar? OnayYetkilisi { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual PyprojeHavuzu? SablonProje { get; set; }

    public virtual PsevkiyatYontemi? SevkiyatYontemi { get; set; }

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual PUyuretimPlaniTuru? UretimPlaniTuru { get; set; }
}
