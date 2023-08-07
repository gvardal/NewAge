using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkunvanRaporlari
{
    public int RaporId { get; set; }

    public short? SorumluUnvanId { get; set; }

    public string RaporAdi { get; set; } = null!;

    public short? RaporUretimZamani { get; set; }

    public DateTime? SonRaporTarihi { get; set; }

    public int ScientaRaporId { get; set; }

    public virtual Ikunvanlar? SorumluUnvan { get; set; }
}
