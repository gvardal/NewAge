using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkcalisanlarSifreler
{
    public long CalisanSifreId { get; set; }

    public int? CalisanId { get; set; }

    public string? Sifre { get; set; }

    public DateTime? EklemeTarihi { get; set; }
}
