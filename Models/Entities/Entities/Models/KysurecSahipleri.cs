using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KysurecSahipleri
{
    public int HaberBandiIzleyicileriId { get; set; }

    public int? CalisanId { get; set; }

    public short? OrganizasyonId { get; set; }

    public short? UnvanId { get; set; }

    public short? SurecId { get; set; }

    public int? OnaySirasi { get; set; }

    public string? Role { get; set; }

    public bool? EPosta { get; set; }

    public bool? Android { get; set; }

    public bool? Ios { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual ICollection<KysurecSahipleri> InverseOnaySirasiNavigation { get; set; } = new List<KysurecSahipleri>();

    public virtual KysurecSahipleri? OnaySirasiNavigation { get; set; }

    public virtual Kysurecler? Surec { get; set; }
}
