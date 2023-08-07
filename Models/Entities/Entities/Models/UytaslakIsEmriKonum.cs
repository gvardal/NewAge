using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UytaslakIsEmriKonum
{
    public long? UretimPlaniId { get; set; }

    public long? IsEmriId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public short? KonumId { get; set; }

    public float? IslemSuresi { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public Guid TaslakIsEmriId { get; set; }

    public byte? Oncelik { get; set; }

    public int? MakinaId { get; set; }

    public int? EkipmanId { get; set; }

    public float? Puanlama { get; set; }

    public int? CalisanId { get; set; }
}
