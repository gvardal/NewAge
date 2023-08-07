using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Mizan
{
    public string? HesapKodu { get; set; }

    public string? HesapAdi { get; set; }

    public decimal Borc { get; set; }

    public decimal Alacak { get; set; }
}
