using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyriskYonetimi
{
    public int RiskId { get; set; }

    public byte? FirmaId { get; set; }

    public string? RiskTuru { get; set; }

    public short? SurecId { get; set; }

    public short? DepartmanId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAksiyonId { get; set; }

    public int? UrunId { get; set; }

    public DateTime? BirimTarihi { get; set; }

    public int? RiskiBildirenId { get; set; }

    public string? TespitEdilenRisk { get; set; }

    public byte? DurumId { get; set; }

    public string? RiskinEtkileri { get; set; }

    public string? MevcutKontrolOnlemleri { get; set; }

    public int? KokNedenAnalizId { get; set; }

    public byte? GerceklesmeOlasiligi { get; set; }

    public byte? IseEtkisi { get; set; }

    public byte? RiskPuani { get; set; }

    public int? Dofid { get; set; }

    public string? FaaliyetSonucu { get; set; }

    public byte? FaaliyetSonucuGerceklesmeOlasiligi { get; set; }

    public byte? FaalisyetSonucuIseEtkisi { get; set; }

    public byte? FaaliyetSonucuRiskPuani { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikorganizasyonlar? Departman { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual KykokNedenAnalizi? KokNedenAnaliz { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual Ikcalisanlar? RiskiBildiren { get; set; }

    public virtual Kysurecler? Surec { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
