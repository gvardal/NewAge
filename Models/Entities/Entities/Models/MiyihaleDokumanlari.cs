using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiyihaleDokumanlari
{
    public int IhaleDokumanId { get; set; }

    public int? FirsatId { get; set; }

    public byte? BelgeTuruId { get; set; }

    public bool? Hazirlandi { get; set; }

    public int? HazirlayanId { get; set; }

    public DateTime? HazirlamaTarihi { get; set; }

    public bool? KontrolEdildi { get; set; }

    public int? KontrolEdenId { get; set; }

    public DateTime? KontrolTarihi { get; set; }

    public string? HazirlikAciklamasi { get; set; }

    public string? KontrolAciklamasi { get; set; }

    public virtual PMiybelgeTurleri? BelgeTuru { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual Ikcalisanlar? Hazirlayan { get; set; }

    public virtual Ikcalisanlar? KontrolEden { get; set; }
}
