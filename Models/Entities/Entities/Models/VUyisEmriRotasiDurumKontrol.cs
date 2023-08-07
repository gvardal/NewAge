using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyisEmriRotasiDurumKontrol
{
    public int? KonumId { get; set; }

    public int IsEmriRotaId { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public byte? RotaDurumu { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public short? IslemTuruId { get; set; }

    public short? GozSayisi { get; set; }
}
