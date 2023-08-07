using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFysonSatinAlmaTarihi
{
    public int UrunId { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public string? SeriSiraNo { get; set; }

    public string? FaturaTuru { get; set; }

    public long? RowNumber { get; set; }
}
