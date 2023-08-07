using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyaksiyonHavuzuRiskleri
{
    public long Id { get; set; }

    public int? ProjeAdimi { get; set; }

    public int? Bildiren { get; set; }

    public DateTime? BildirimTarihi { get; set; }

    public string? RiskinAdi { get; set; }

    public double? Olasilik { get; set; }

    public string? RiskSahibi { get; set; }

    public string? Oncelik { get; set; }

    public string? Durum { get; set; }

    public string? RiskFaktoru { get; set; }

    public string? OngorulenCozumSuresi { get; set; }

    public int? Dof { get; set; }

    public virtual Ikcalisanlar? BildirenNavigation { get; set; }

    public virtual PyprojeAdimlariHavuzu? ProjeAdimiNavigation { get; set; }
}
