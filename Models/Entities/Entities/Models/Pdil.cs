using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Pdil
{
    public int Id { get; set; }

    public string? Dil { get; set; }

    public string? KulturId { get; set; }

    public virtual ICollection<IkyabanciDil> IkyabanciDils { get; set; } = new List<IkyabanciDil>();

    public virtual ICollection<SyurunAciklamalari> SyurunAciklamalaris { get; set; } = new List<SyurunAciklamalari>();

    public virtual ICollection<SyurunKategorisiAciklamalari> SyurunKategorisiAciklamalaris { get; set; } = new List<SyurunKategorisiAciklamalari>();
}
