using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BankaHatalari
{
    public int BankaHataId { get; set; }

    public int? SiparisId { get; set; }

    public string? HataMesaji { get; set; }

    public string? HataMesaji2 { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public virtual Sysiparisler? Siparis { get; set; }
}
