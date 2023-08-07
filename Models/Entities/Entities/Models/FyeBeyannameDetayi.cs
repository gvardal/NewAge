using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyeBeyannameDetayi
{
    public int BeyannameDetayiId { get; set; }

    public int? BeyannameId { get; set; }

    public byte? Tipi { get; set; }

    public int? HesapPlaniId { get; set; }

    public decimal? Matrah { get; set; }

    public decimal? Kdvtutar { get; set; }

    public virtual FyeBeyanname? Beyanname { get; set; }
}
