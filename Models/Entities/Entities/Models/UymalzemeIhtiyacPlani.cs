using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymalzemeIhtiyacPlani
{
    public long MalzemeIhtiyacPlaniId { get; set; }

    public byte? FirmaId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? GenelTalepId { get; set; }

    public long? SasiparisDetayiId { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public long? ProjeMalzemeIstekFisiDetayiId { get; set; }

    public int? IlkMadMlzKategoriKoduId { get; set; }

    public int? IlkMadMalzemeKoduId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? TedarikEdilenMiktar { get; set; }

    public int? UretimOlcuBirimiId { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public int? TalepEdenId { get; set; }

    public byte? Durum { get; set; }

    public string? DosyaAdi { get; set; }

    public bool? DepoOnay { get; set; }

    public int? DepoOnaylayanId { get; set; }

    public DateTime? DepoOnayTarihi { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzeleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public bool? Secili { get; set; }

    public virtual Ikcalisanlar? DepoOnaylayan { get; set; }

    public virtual PSatalepDurumu? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzeleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Uyurunler? IlkMadMalzemeKodu { get; set; }

    public virtual UyurunKategorisi? IlkMadMlzKategoriKodu { get; set; }

    public virtual UyisEmri? IsEmri { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual UymalzemeIstekFisiDetayi? ProjeMalzemeIstekFisiDetayi { get; set; }

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? TalepEden { get; set; }

    public virtual PolcuBirimleri? UretimOlcuBirimi { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }
}
