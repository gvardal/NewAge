using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikyetkiler
{
    public int Id { get; set; }

    public string? Yetki { get; set; }

    public string? YetkiAciklamasi { get; set; }

    public virtual ICollection<IkkullaniciYetkileri> IkkullaniciYetkileris { get; set; } = new List<IkkullaniciYetkileri>();

    public virtual ICollection<IkunvanYetkileri> IkunvanYetkileris { get; set; } = new List<IkunvanYetkileri>();
}
