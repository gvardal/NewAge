using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeAdimlari
{
    public int ProjeAdimiId { get; set; }

    public int? ProjeKodu { get; set; }

    public int? OncekiProjeAdimi { get; set; }

    public int? MusteriIstekSikayetId { get; set; }

    public string? Konu { get; set; }

    public string? KısaAcıklama { get; set; }

    public string? IsinAdi { get; set; }

    public string? TeslimHukumleri { get; set; }

    public byte? ProjeAdimiDurumuId { get; set; }

    public byte? ProjeAdimiTuruId { get; set; }

    public string? Onem { get; set; }

    public string? Url { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public int? PlanlananSure { get; set; }

    public int? StandartSure { get; set; }

    public short? TamamlanmaOrani { get; set; }

    public string? Renk { get; set; }

    public int? Sorumlu { get; set; }

    public short? ProjeTakimi { get; set; }

    public short? ProjeUnvani { get; set; }

    public int? KilometreTasi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public int? GerceklesenSure { get; set; }

    public string? VarsaSapmaAciklamasi { get; set; }

    public decimal? ButceKaydi { get; set; }

    public decimal? TahiminiMaliyeti { get; set; }

    public short? KrediPuani { get; set; }

    public short? GerceklesenKrediPuani { get; set; }

    public string? Onculler { get; set; }

    public string? Yorumlar { get; set; }

    public string? RedNedeni { get; set; }

    public string? FaturaDurumu { get; set; }

    public long? FaturaNo { get; set; }

    public decimal? GerceklesmeMaliyeti { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? FaturaNoNavigation { get; set; }

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmets { get; set; } = new List<FdemirbasZimmet>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<PyprojeAdimlari> InverseKilometreTasiNavigation { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeAdimlari> InverseOncekiProjeAdimiNavigation { get; set; } = new List<PyprojeAdimlari>();

    public virtual PyprojeAdimlari? KilometreTasiNavigation { get; set; }

    public virtual YmmusteriIstekSikayetleri? MusteriIstekSikayet { get; set; }

    public virtual PyprojeAdimlari? OncekiProjeAdimiNavigation { get; set; }

    public virtual PPyprojeAdimiDurumu? ProjeAdimiDurumu { get; set; }

    public virtual PPyprojeAdimiTuru? ProjeAdimiTuru { get; set; }

    public virtual Pyprojeler? ProjeKoduNavigation { get; set; }

    public virtual PPyprojeTakimlari? ProjeTakimiNavigation { get; set; }

    public virtual PPyprojeGorevleri? ProjeUnvaniNavigation { get; set; }

    public virtual ICollection<PyaksiyonBelgeleri> PyaksiyonBelgeleris { get; set; } = new List<PyaksiyonBelgeleri>();

    public virtual ICollection<PyaksiyonDokumanlari> PyaksiyonDokumanlaris { get; set; } = new List<PyaksiyonDokumanlari>();

    public virtual ICollection<PyprojeAdimiSorumlulari> PyprojeAdimiSorumlularis { get; set; } = new List<PyprojeAdimiSorumlulari>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();

    public virtual ICollection<PyprojeInsanKaynagi> PyprojeInsanKaynagis { get; set; } = new List<PyprojeInsanKaynagi>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnalizis { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SorumluNavigation { get; set; }

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UyuretimPlaniArsivi> UyuretimPlaniArsivis { get; set; } = new List<UyuretimPlaniArsivi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();
}
