using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdksbordroIzinTuru
{
    public string BordroIzinTuruId { get; set; } = null!;

    public string? Aciklama { get; set; }

    public bool? Ucretli { get; set; }

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzins { get; set; } = new List<IkpdksbordroIzin>();
}
