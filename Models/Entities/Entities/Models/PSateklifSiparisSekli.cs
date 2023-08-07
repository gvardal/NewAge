using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSateklifSiparisSekli
{
    public byte TeklifSiparisSekliId { get; set; }

    public string? TeklifSiparisSekli { get; set; }

    public bool? GenelTeklif { get; set; }

    public string? TeklifRaporAdi { get; set; }

    public string? SiparisOnizlemeRaporAdi { get; set; }

    public string? SiparisRaporAdi { get; set; }

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();
}
