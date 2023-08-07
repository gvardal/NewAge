using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSateklifSiparisTuru
{
    public int TeklifSiparisTuruId { get; set; }

    public string? TeklifSiparisTuruKodu { get; set; }

    public string? TeklifSiparisTuru { get; set; }

    public string? TeklifSiparisKoduTuru { get; set; }

    public bool? IthalatIhracat { get; set; }

    public bool? SubelerArasiSevkIrsaliyesi { get; set; }

    public bool? KonsinyeMal { get; set; }

    public bool? Numune { get; set; }

    public bool? Bedelsiz { get; set; }

    public byte? ParaBirimiId { get; set; }

    public string? TeklifRaporAdi { get; set; }

    public string? SiparisRaporAdi { get; set; }

    public int? OnayYetkilisiId { get; set; }

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();
}
