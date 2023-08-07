using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DybyonayListesi
{
    public int OnayId { get; set; }

    public byte? OnaySirasi { get; set; }

    public int? EvrakId { get; set; }

    public int? CalisanId { get; set; }

    public DateTime? OnayaSunusTarihi { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Onay { get; set; }

    public string? OnayAciklamasi { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Dybyevraklar? Evrak { get; set; }
}
